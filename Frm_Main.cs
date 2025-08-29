namespace ComparadorSchema
{
    public partial class Frm_Main : Form
    {
        string stgConn1 = string.Empty;
        string stgConn2 = string.Empty;
        string nomeBanco1 = string.Empty;
        string nomeBanco2 = string.Empty;


        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_IniciarComparacao_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelecionarBancos_Click(object sender, EventArgs e)
        {
            using var f = new Frm_SelecionarBancos();
            if (f.ShowDialog() == DialogResult.OK && f.DadosSelecionados)
            {
                stgConn1 = f.StringConexaoBanco1;
                stgConn2 = f.StringConexaoBanco2;
                nomeBanco1 = f.NomeBanco1;
                nomeBanco2 = f.NomeBanco2;

                lbl_Banco1.Text = nomeBanco1;
                lbl_Banco2.Text = nomeBanco2;
            }
        }
    }
}
