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
            lbl_Banco1 = new Label();
            lbl_Banco2 = new Label();
            btn_SelecionarBancos = new Button();
            label1 = new Label();
            label2 = new Label();
            gbox_TabelasBanco1 = new GroupBox();
            list_TabelasBanco1 = new ListBox();
            label4 = new Label();
            lbl_TblSelectBanco1 = new Label();
            gbox_TabelasBanco2 = new GroupBox();
            list_TabelasBanco2 = new ListBox();
            label5 = new Label();
            lbl_TblSelectBanco2 = new Label();
            gbox_TabelasBanco1.SuspendLayout();
            gbox_TabelasBanco2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Banco1
            // 
            lbl_Banco1.AutoSize = true;
            lbl_Banco1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_Banco1.Location = new Point(111, 21);
            lbl_Banco1.Name = "lbl_Banco1";
            lbl_Banco1.Size = new Size(15, 15);
            lbl_Banco1.TabIndex = 4;
            lbl_Banco1.Text = "- ";
            // 
            // lbl_Banco2
            // 
            lbl_Banco2.AutoSize = true;
            lbl_Banco2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_Banco2.Location = new Point(111, 45);
            lbl_Banco2.Name = "lbl_Banco2";
            lbl_Banco2.Size = new Size(12, 15);
            lbl_Banco2.TabIndex = 4;
            lbl_Banco2.Text = "-";
            // 
            // btn_SelecionarBancos
            // 
            btn_SelecionarBancos.Location = new Point(12, 68);
            btn_SelecionarBancos.Name = "btn_SelecionarBancos";
            btn_SelecionarBancos.Size = new Size(134, 27);
            btn_SelecionarBancos.TabIndex = 0;
            btn_SelecionarBancos.Text = "Selecionar Bancos";
            btn_SelecionarBancos.UseVisualStyleBackColor = true;
            btn_SelecionarBancos.Click += btn_SelecionarBancos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Primeiro banco:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "Segundo banco:";
            // 
            // gbox_TabelasBanco1
            // 
            gbox_TabelasBanco1.Controls.Add(list_TabelasBanco1);
            gbox_TabelasBanco1.Controls.Add(label4);
            gbox_TabelasBanco1.Controls.Add(lbl_TblSelectBanco1);
            gbox_TabelasBanco1.Location = new Point(213, 21);
            gbox_TabelasBanco1.Name = "gbox_TabelasBanco1";
            gbox_TabelasBanco1.Size = new Size(236, 242);
            gbox_TabelasBanco1.TabIndex = 6;
            gbox_TabelasBanco1.TabStop = false;
            gbox_TabelasBanco1.Text = "Tabelas Banco 1";
            // 
            // list_TabelasBanco1
            // 
            list_TabelasBanco1.FormattingEnabled = true;
            list_TabelasBanco1.Location = new Point(6, 24);
            list_TabelasBanco1.Name = "list_TabelasBanco1";
            list_TabelasBanco1.Size = new Size(224, 184);
            list_TabelasBanco1.TabIndex = 0;
            list_TabelasBanco1.Tag = "TblBanco1";
            list_TabelasBanco1.SelectedIndexChanged += list_TabelasBanco1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 211);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Tabela Selec:";
            // 
            // lbl_TblSelectBanco1
            // 
            lbl_TblSelectBanco1.AutoSize = true;
            lbl_TblSelectBanco1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_TblSelectBanco1.Location = new Point(86, 211);
            lbl_TblSelectBanco1.Name = "lbl_TblSelectBanco1";
            lbl_TblSelectBanco1.Size = new Size(12, 15);
            lbl_TblSelectBanco1.TabIndex = 4;
            lbl_TblSelectBanco1.Text = "-";
            // 
            // gbox_TabelasBanco2
            // 
            gbox_TabelasBanco2.Controls.Add(list_TabelasBanco2);
            gbox_TabelasBanco2.Controls.Add(label5);
            gbox_TabelasBanco2.Controls.Add(lbl_TblSelectBanco2);
            gbox_TabelasBanco2.Location = new Point(476, 21);
            gbox_TabelasBanco2.Name = "gbox_TabelasBanco2";
            gbox_TabelasBanco2.Size = new Size(236, 242);
            gbox_TabelasBanco2.TabIndex = 6;
            gbox_TabelasBanco2.TabStop = false;
            gbox_TabelasBanco2.Text = "Tabelas Banco 2";
            // 
            // list_TabelasBanco2
            // 
            list_TabelasBanco2.FormattingEnabled = true;
            list_TabelasBanco2.Location = new Point(6, 22);
            list_TabelasBanco2.Name = "list_TabelasBanco2";
            list_TabelasBanco2.Size = new Size(224, 184);
            list_TabelasBanco2.TabIndex = 0;
            list_TabelasBanco2.Tag = "TblBanco2";
            list_TabelasBanco2.SelectedIndexChanged += list_TabelasBanco2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 211);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 5;
            label5.Text = "Tabela Selec:";
            // 
            // lbl_TblSelectBanco2
            // 
            lbl_TblSelectBanco2.AutoSize = true;
            lbl_TblSelectBanco2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_TblSelectBanco2.Location = new Point(86, 211);
            lbl_TblSelectBanco2.Name = "lbl_TblSelectBanco2";
            lbl_TblSelectBanco2.Size = new Size(12, 15);
            lbl_TblSelectBanco2.TabIndex = 4;
            lbl_TblSelectBanco2.Text = "-";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 623);
            Controls.Add(gbox_TabelasBanco2);
            Controls.Add(gbox_TabelasBanco1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Banco2);
            Controls.Add(lbl_Banco1);
            Controls.Add(btn_SelecionarBancos);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comparador de Schemas";
            gbox_TabelasBanco1.ResumeLayout(false);
            gbox_TabelasBanco1.PerformLayout();
            gbox_TabelasBanco2.ResumeLayout(false);
            gbox_TabelasBanco2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Banco1;
        private Label lbl_Banco2;
        private Button btn_SelecionarBancos;
        private Label label1;
        private Label label2;
        private GroupBox gbox_TabelasBanco1;
        private GroupBox gbox_TabelasBanco2;
        private ListBox list_TabelasBanco1;
        private ListBox list_TabelasBanco2;
        private Label label4;
        private Label lbl_TblSelectBanco1;
        private Label label5;
        private Label lbl_TblSelectBanco2;
    }
}
