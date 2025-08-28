namespace ComparadorSchema
{
    public partial class Frm_Main : Form
    {
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
            f.ShowDialog();
        }
    }
}
