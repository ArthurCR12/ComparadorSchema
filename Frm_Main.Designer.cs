namespace ComparadorSchema
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_IniciarComparacao = new Button();
            lbl_Atual = new Label();
            lbl_NovaVersao = new Label();
            btn_SelecionarBancos = new Button();
            SuspendLayout();
            // 
            // btn_IniciarComparacao
            // 
            btn_IniciarComparacao.Location = new Point(12, 189);
            btn_IniciarComparacao.Name = "btn_IniciarComparacao";
            btn_IniciarComparacao.Size = new Size(226, 36);
            btn_IniciarComparacao.TabIndex = 0;
            btn_IniciarComparacao.Text = "Iniciar Comparação";
            btn_IniciarComparacao.UseVisualStyleBackColor = true;
            btn_IniciarComparacao.Click += btn_IniciarComparacao_Click;
            // 
            // lbl_Atual
            // 
            lbl_Atual.AutoSize = true;
            lbl_Atual.Location = new Point(12, 107);
            lbl_Atual.Name = "lbl_Atual";
            lbl_Atual.Size = new Size(41, 15);
            lbl_Atual.TabIndex = 4;
            lbl_Atual.Text = "Atual: ";
            // 
            // lbl_NovaVersao
            // 
            lbl_NovaVersao.AutoSize = true;
            lbl_NovaVersao.Location = new Point(12, 138);
            lbl_NovaVersao.Name = "lbl_NovaVersao";
            lbl_NovaVersao.Size = new Size(78, 15);
            lbl_NovaVersao.TabIndex = 4;
            lbl_NovaVersao.Text = "Nova Versão :";
            // 
            // btn_SelecionarBancos
            // 
            btn_SelecionarBancos.Location = new Point(12, 52);
            btn_SelecionarBancos.Name = "btn_SelecionarBancos";
            btn_SelecionarBancos.Size = new Size(226, 36);
            btn_SelecionarBancos.TabIndex = 0;
            btn_SelecionarBancos.Text = "Selecionar Bancos";
            btn_SelecionarBancos.UseVisualStyleBackColor = true;
            btn_SelecionarBancos.Click += btn_SelecionarBancos_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 520);
            Controls.Add(lbl_NovaVersao);
            Controls.Add(lbl_Atual);
            Controls.Add(btn_SelecionarBancos);
            Controls.Add(btn_IniciarComparacao);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comparador de Schemas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_IniciarComparacao;
        private Label lbl_Atual;
        private Label lbl_NovaVersao;
        private Button btn_SelecionarBancos;
    }
}
