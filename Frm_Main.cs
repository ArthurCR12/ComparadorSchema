using Dapper;
using MySql.Data.MySqlClient;

namespace ComparadorSchema
{
    public partial class Frm_Main : Form
    {
        string nomeBanco1 = string.Empty;
        string nomeBanco2 = string.Empty;

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
                connBanco1 = new(f.StringConexaoBanco1);
                connBanco2 = new(f.StringConexaoBanco2);
                nomeBanco1 = f.NomeBanco1;
                nomeBanco2 = f.NomeBanco2;

                lbl_Banco1.Text = nomeBanco1;
                lbl_Banco2.Text = nomeBanco2;
                BuscarTabelas();
            }
        }

        private void BuscarTabelas()
        {
            try
            {
                var resTbl1 = connBanco1.Query<string>("SHOW TABLES;").ToList();
                list_TabelasBanco1.DataSource = resTbl1;
                list_TabelasBanco1.ClearSelected();

                var resTbl2 = connBanco2.Query<string>("SHOW TABLES;").ToList();
                list_TabelasBanco2.DataSource = resTbl2;
                list_TabelasBanco2.ClearSelected();
            }
            catch (Exception ex)
            {
                MsgHandler.Erro("Erro ao buscar tabelas: " + ex.Message);
            }
        }
        private void BuscarSchemaTabela(int bd, string tbl, string database)
        {
            try
            {
                string sql = $@"
                    SELECT 
                        COLUMN_NAME,
                        DATA_TYPE,
                        IS_NULLABLE,
                        COLUMN_KEY,
                        COLUMN_DEFAULT,
                        EXTRA
                    FROM INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME = '{tbl}' AND TABLE_SCHEMA = '{database}';";
                if (bd == 1)
                {                    
                    var res = connBanco1.Query<TabelaSchema>(sql);
                    dgv_InfoTabelaBd1.DataSource = res;
                }
            }
            catch (Exception ex)
            {

                throw;
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
            }
        }

        private void list_TabelasBanco1_DoubleClick(object sender, EventArgs e)
        {
            if (list_TabelasBanco1.SelectedItem != null)
            {
                BuscarSchemaTabela(1, list_TabelasBanco1.SelectedItem.ToString()!, nomeBanco1);
            }
        }
    }
}
