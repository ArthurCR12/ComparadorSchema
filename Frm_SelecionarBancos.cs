using Dapper;
using MySql.Data.MySqlClient;

namespace ComparadorSchema
{
    public partial class Frm_SelecionarBancos : Form
    {
        string conString1 = string.Empty;
        string conString2 = string.Empty;


        public Frm_SelecionarBancos()
        {
            InitializeComponent();
        }

        private void Frm_SelecionarBancos_Load(object sender, EventArgs e)
        {

        }

        private void btn_TesteCon1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ServerPrimeiro.Text))
            {
                MessageBox.Show("Informe um Server");
                txt_ServerPrimeiro.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_PortPrimeiro.Text))
            {
                MessageBox.Show("Informe uma Porta");
                txt_PortPrimeiro.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_UserNamePrimeiro.Text))
            {
                MessageBox.Show("Informe um User Name");
                txt_UserNamePrimeiro.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_PasswordPrimeiro.Text))
            {
                MessageBox.Show("Informe uma Senha");
                txt_PasswordPrimeiro.Focus();
                return;
            }

            string server = txt_ServerPrimeiro.Text.Trim();
            string port = txt_PortPrimeiro.Text.Trim();
            string userName = txt_UserNamePrimeiro.Text.Trim();
            string password = txt_PasswordPrimeiro.Text.Trim();
            
            conString1 = $"Server={server};Port={port};Uid={userName};Pwd={password};";

            try
            {
                using var con = new MySqlConnection(conString1);
                var result = con.Query<string>("SHOW DATABASES;").ToList();

                list_Primeiro.DataSource = result;


                list_Primeiro.Items.Clear();
                foreach (var banco in result)
                {
                    list_Primeiro.Items.Add(new ListViewItem(banco));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }

        }

        private void btn_TesteCon2_Click(object sender, EventArgs e)
        {

        }



    }
}
