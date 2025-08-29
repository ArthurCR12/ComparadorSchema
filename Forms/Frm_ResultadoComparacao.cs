using ComparadorSchema.Classes;

namespace ComparadorSchema;

public partial class Frm_ResultadoComparacao : Form
{
    public Frm_ResultadoComparacao()
    {
        InitializeComponent();
    }

    private void btn_GerarSQL_Click(object sender, EventArgs e)
    {

    }

    private void btn_CopiarSQL_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(txt_SqlGerado.Text))
            {
                Clipboard.SetText(txt_SqlGerado.Text);
                MsgHandler.Success("Resultado copiado para a área de transfência!");
            }
        }
        catch (Exception ex)
        {
            MsgHandler.Erro($"Erro ao copiar: {ex.Message}");
        }
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
