using Dapper;
using MySql.Data.MySqlClient;

namespace ComparadorSchema
{
    public partial class Frm_SelecionarBancos : Form
    {
        string banco1 = string.Empty;
        string banco2 = string.Empty;

        public Frm_SelecionarBancos()
        {
            InitializeComponent();
        }

        private void Frm_SelecionarBancos_Load(object sender, EventArgs e)
        {

        }

        private bool VerificarCampos(Control ctl)
        {
            foreach (Control control in ctl.Controls)
            {
                if (control is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MsgHandler.Warning($@"O campo ""{txt.Tag}"" deve ser preenchido!");
                        txt.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private string GerarStringConexao(Control ctl)
        {
            string server = "", port = "", userName = "", password = "";

            if (VerificarCampos(ctl))
            {
                foreach (Control control in ctl.Controls)
                {
                    if (control is TextBox txt)
                    {
                        switch (txt.Tag?.ToString())
                        {
                            case "Server":
                                server = txt.Text;
                                break;
                            case "Port":
                                port = txt.Text;
                                break;
                            case "User Name":
                                userName = txt.Text;
                                break;
                            case "Password":
                                password = txt.Text;
                                break;
                        }
                    }

                }
                return $"Server={server};Port={port};Uid={userName};Pwd={password};";
            }
            return string.Empty;
        }

        private void BuscarBancos(Control ctl)
        {
            if (VerificarCampos(ctl))
            {
                var strConn = GerarStringConexao(ctl);
                try
                {
                    using var c = new MySqlConnection(strConn);
                    var res = c.Query<string>("SHOW DATABASES;").ToList();

                    if (ctl is Panel p)
                    {
                        if (p.Name == panel_Primeiro.Name)
                        {
                            list_Primeiro.DataSource = res;
                            list_Primeiro.ClearSelected();
                        }
                        if (p.Name == panel_Segundo.Name)
                        {
                            list_Segundo.DataSource = res;
                            list_Segundo.ClearSelected();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MsgHandler.Erro("Erro ao conectar: " + ex.Message);
                }
            }
        }

        private void btn_TesteCon1_Click(object sender, EventArgs e)
        {
            BuscarBancos(panel_Primeiro);

        }

        private void btn_TesteCon2_Click(object sender, EventArgs e)
        {
            BuscarBancos(panel_Segundo);
        }

        private void list_Primeiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Primeiro.SelectedItem != null && list_Primeiro.SelectedIndex >= 0)
            {
                lbl_PrimeiroBanco.Text = $"1° Banco selecionado: {list_Primeiro.SelectedItem}";
                banco1 = list_Primeiro.SelectedItem!.ToString()!;
            }
            else
            {
                lbl_PrimeiroBanco.Text = "Nenhum banco selecionado";
                banco1 = string.Empty;
            }
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            //TODO retornar com os dados
        }

        private void list_Segundo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Segundo.SelectedItem != null && list_Segundo.SelectedIndex >= 0)
            {
                lbl_SegundoBanco.Text = $"2° Banco selecionado: {list_Segundo.SelectedItem}";
                banco1 = list_Segundo.SelectedItem!.ToString()!;
            }
            else
            {
                lbl_SegundoBanco.Text = "Nenhum banco selecionado";
                banco2 = string.Empty;
            }
        }
    }
}
