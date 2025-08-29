using ComparadorSchema.Classes;
using Dapper;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ComparadorSchema
{
    public partial class Frm_Main : Form
    {
        private const string SHOW_TABLES_QUERY = "SHOW TABLES;";
        private const string SCHEMA_QUERY = @"
            SELECT 
                COLUMN_NAME,
                DATA_TYPE,
                IS_NULLABLE,
                COLUMN_KEY,
                COLUMN_DEFAULT,
                EXTRA
            FROM INFORMATION_SCHEMA.COLUMNS
            WHERE TABLE_NAME = @tableName AND TABLE_SCHEMA = @database
            ORDER BY ORDINAL_POSITION;";
        private const string FOREIGN_KEYS_QUERY = @"
            SELECT k.COLUMN_NAME, k.REFERENCED_TABLE_NAME, k.REFERENCED_COLUMN_NAME, r.CONSTRAINT_NAME
            FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE k
            JOIN INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS r
            ON k.CONSTRAINT_NAME = r.CONSTRAINT_NAME
            WHERE k.TABLE_NAME = @tableName AND k.TABLE_SCHEMA = @database
            AND k.REFERENCED_TABLE_NAME IS NOT NULL;";
        private const string DATA_QUERY = "SELECT * FROM `{0}`.`{1}` LIMIT 10;";

        private string nomeBanco1 = string.Empty;
        private string nomeBanco2 = string.Empty;
        private MySqlConnection connBanco1 = null!;
        private MySqlConnection connBanco2 = null!;


        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_SelecionarBancos_Click(object sender, EventArgs e)
        {
            using var f = new Frm_SelecionarBancos();
            if (f.ShowDialog() == DialogResult.OK && f.DadosSelecionados)
            {
                connBanco1?.Dispose();
                connBanco2?.Dispose();

                connBanco1 = new(f.StringConexaoBanco1);
                connBanco2 = new(f.StringConexaoBanco2);
                nomeBanco1 = f.NomeBanco1;
                nomeBanco2 = f.NomeBanco2;

                gbox_TabelasBanco1.Text = $"Tbl 1:{nomeBanco1}";
                gbox_TabelasBanco2.Text = $"Tbl 2:{nomeBanco2}";
                _ = BuscarTabelasAsync();
            }
        }

        private bool ValidarConexoes()
        {
            if (connBanco1 == null || connBanco2 == null)
            {
                MsgHandler.Warning("Selecione os bancos de dados primeiro.");
                return false;
            }
            try
            {
                if (connBanco1.State != System.Data.ConnectionState.Open) connBanco1.Open();
                if (connBanco2.State != System.Data.ConnectionState.Open) connBanco2.Open();
                return true;
            }
            catch (Exception ex)
            {
                MsgHandler.Erro("Erro ao conectar com os bancos: " + ex.Message);
                return false;
            }
        }

        private async Task BuscarTabelasAsync()
        {
            try
            {
                if (!ValidarConexoes()) return;

                var task1 = connBanco1.QueryAsync<string>(SHOW_TABLES_QUERY);
                var task2 = connBanco2.QueryAsync<string>(SHOW_TABLES_QUERY);

                await Task.WhenAll(task1, task2);

                list_TabelasBanco1.DataSource = task1.Result.ToList();
                list_TabelasBanco1.ClearSelected();

                list_TabelasBanco2.DataSource = task2.Result.ToList();
                list_TabelasBanco2.ClearSelected();

                //DestacarDiferencasTabelas();
            }
            catch (Exception ex)
            {
                MsgHandler.Erro("Erro ao buscar tabelas: " + ex.Message);
            }
        }
        private async Task<List<TabelaSchema>> BuscarSchemaTabelaAsync(int banco, string tabela, string database)
        {
            try
            {
                var conn = banco == 1 ? connBanco1 : connBanco2;
                var res = await conn.QueryAsync<TabelaSchema>(SCHEMA_QUERY, new { tableName = tabela, database = database });
                var lista = res.ToList();

                if (banco == 1) dgv_InfoTabelaBd1.DataSource = lista;
                else dgv_InfoTabelaBd2.DataSource = lista;

                return lista;
            }
            catch (Exception ex)
            {
                MsgHandler.Erro("Erro ao buscar schema da tabela: " + ex.Message);
                return new List<TabelaSchema>();
            }
        }
        private async Task<List<ForeignKeySchema>> BuscarForeingKeysAsync(int banco, string tabela, string database)
        {
            try
            {
                var conn = banco == 1 ? connBanco1 : connBanco2;
                var res = await conn.QueryAsync<ForeignKeySchema>(FOREIGN_KEYS_QUERY, new { tableName = tabela, database = database });
                var lista = res.ToList();

                if (banco == 1) dgv_InfoFKBanco1.DataSource = lista;
                else dgv_InfoFKBanco2.DataSource = lista;

                return lista;
            }
            catch (Exception ex)
            {
                MsgHandler.Erro($"Erro ao buscar foreign keys da tabela {tabela}: " + ex.Message);
                return new List<ForeignKeySchema>();
            }
        }
        private async Task BuscarDadosAsync(int banco, string tabela, string database)
        {
            try
            {
                var conn = banco == 1 ? connBanco1 : connBanco2;
                var sql = string.Format(DATA_QUERY, database, tabela);
                var res = await conn.QueryAsync(sql);

                if (banco == 1) dgv_DadosTblBd1.DataSource = res.ToList();
                else dgv_DadosTblBd2.DataSource = res.ToList();
            }
            catch (Exception ex)
            {
                MsgHandler.Erro($"Erro ao buscar dados da tabela {tabela}: " + ex.Message);
            }
        }
        private async Task CarregarDadosTabelaAsync(int banco, string tabela)
        {
            try
            {
                if (!ValidarConexoes()) return;

                var database = banco == 1 ? nomeBanco1 : nomeBanco2;
                await BuscarSchemaTabelaAsync(banco, tabela, database);
                await BuscarForeingKeysAsync(banco, tabela, database);
                await BuscarDadosAsync(banco, tabela, database);
                
            }
            catch (Exception ex)
            {
                MsgHandler.Erro($"Erro ao carregar dados da tabela {tabela}: " + ex.Message);
            }
        }
        private void LimparDadosBanco(int banco)
        {
            if (banco == 1)
            {
                dgv_InfoTabelaBd1.DataSource = null;
                dgv_InfoFKBanco1.DataSource = null;
                dgv_DadosTblBd1.DataSource = null;
            }
            else
            {
                dgv_InfoTabelaBd2.DataSource = null;
                dgv_InfoFKBanco2.DataSource = null;
                dgv_DadosTblBd2.DataSource = null;
            }
        }

        private void list_TabelasBanco1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_TabelasBanco1.SelectedItem != null && list_TabelasBanco1.SelectedIndex >= 0)
            {
                lbl_TblSelectBanco1.Text = list_TabelasBanco1.SelectedItem.ToString();
            }
            else
            {
                lbl_TblSelectBanco1.Text = "";
                LimparDadosBanco(1);
            }
        }
        private void list_TabelasBanco2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_TabelasBanco2.SelectedItem != null && list_TabelasBanco2.SelectedIndex >= 0)
            {
                lbl_TblSelectBanco2.Text = list_TabelasBanco2.SelectedItem.ToString();
            }
            else
            {
                lbl_TblSelectBanco2.Text = "";
                LimparDadosBanco(2);
            }
        }
        private async void list_TabelasBanco1_DoubleClick(object sender, EventArgs e)
        {
            if (list_TabelasBanco1.SelectedItem != null)
            {
                string tabela = list_TabelasBanco1.SelectedItem.ToString()!;
                await CarregarDadosTabelaAsync(1, tabela);
            }
        }
        private async void list_TabelasBanco2_DoubleClick(object sender, EventArgs e)
        {
            if (list_TabelasBanco2.SelectedItem != null)
            {
                string tabela = list_TabelasBanco2.SelectedItem.ToString()!;
                await CarregarDadosTabelaAsync(2, tabela);
            }

        }
    }
}
