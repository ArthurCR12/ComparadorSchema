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
            lbl_Banco1 = new Label();
            lbl_Banco2 = new Label();
            btn_SelecionarBancos = new Button();
            label1 = new Label();
            label2 = new Label();
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
            // lbl_Banco1
            // 
            lbl_Banco1.AutoSize = true;
            lbl_Banco1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_Banco1.Location = new Point(111, 108);
            lbl_Banco1.Name = "lbl_Banco1";
            lbl_Banco1.Size = new Size(15, 15);
            lbl_Banco1.TabIndex = 4;
            lbl_Banco1.Text = "- ";
            // 
            // lbl_Banco2
            // 
            lbl_Banco2.AutoSize = true;
            lbl_Banco2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_Banco2.Location = new Point(111, 143);
            lbl_Banco2.Name = "lbl_Banco2";
            lbl_Banco2.Size = new Size(12, 15);
            lbl_Banco2.TabIndex = 4;
            lbl_Banco2.Text = "-";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Primeiro banco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "Segundo banco:";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 520);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Banco2);
            Controls.Add(lbl_Banco1);
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
        private Label lbl_Banco1;
        private Label lbl_Banco2;
        private Button btn_SelecionarBancos;
        private Label label1;
        private Label label2;
    }
}
