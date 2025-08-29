namespace ComparadorSchema
{
    partial class Frm_ResultadoComparacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_Fechar = new Button();
            btn_GerarSQL = new Button();
            btn_CopiarSQL = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txt_SqlGerado = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_Result = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Fechar);
            panel1.Controls.Add(btn_GerarSQL);
            panel1.Controls.Add(btn_CopiarSQL);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 483);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 100);
            panel1.TabIndex = 1;
            // 
            // btn_Fechar
            // 
            btn_Fechar.Location = new Point(656, 51);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(87, 37);
            btn_Fechar.TabIndex = 0;
            btn_Fechar.Text = "Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // btn_GerarSQL
            // 
            btn_GerarSQL.Location = new Point(12, 11);
            btn_GerarSQL.Name = "btn_GerarSQL";
            btn_GerarSQL.Size = new Size(87, 37);
            btn_GerarSQL.TabIndex = 0;
            btn_GerarSQL.Text = "Gerar SQL";
            btn_GerarSQL.UseVisualStyleBackColor = true;
            btn_GerarSQL.Click += btn_GerarSQL_Click;
            // 
            // btn_CopiarSQL
            // 
            btn_CopiarSQL.Location = new Point(12, 54);
            btn_CopiarSQL.Name = "btn_CopiarSQL";
            btn_CopiarSQL.Size = new Size(87, 37);
            btn_CopiarSQL.TabIndex = 0;
            btn_CopiarSQL.Text = "Copiar SQL";
            btn_CopiarSQL.UseVisualStyleBackColor = true;
            btn_CopiarSQL.Click += btn_CopiarSQL_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txt_SqlGerado, 0, 1);
            tableLayoutPanel1.Controls.Add(txt_Result, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(755, 483);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txt_SqlGerado
            // 
            txt_SqlGerado.Dock = DockStyle.Fill;
            txt_SqlGerado.ForeColor = Color.FromArgb(50, 50, 50);
            txt_SqlGerado.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_SqlGerado.LabelTitle = false;
            txt_SqlGerado.LabelTitleText = "";
            txt_SqlGerado.Location = new Point(3, 244);
            txt_SqlGerado.Multiline = true;
            txt_SqlGerado.Name = "txt_SqlGerado";
            txt_SqlGerado.OnEnterBackColor = Color.AliceBlue;
            txt_SqlGerado.OnLeaveBackColor = Color.White;
            txt_SqlGerado.SelectAllTextOnEnter = false;
            txt_SqlGerado.Size = new Size(749, 236);
            txt_SqlGerado.TabIndex = 0;
            txt_SqlGerado.TabOnEnter = true;
            txt_SqlGerado.ValidateAsDate = false;
            txt_SqlGerado.WarningMessageDate = "Invalid date format.";
            // 
            // txt_Result
            // 
            txt_Result.Dock = DockStyle.Fill;
            txt_Result.ForeColor = Color.FromArgb(50, 50, 50);
            txt_Result.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_Result.LabelTitle = false;
            txt_Result.LabelTitleText = "";
            txt_Result.Location = new Point(3, 3);
            txt_Result.Multiline = true;
            txt_Result.Name = "txt_Result";
            txt_Result.OnEnterBackColor = Color.AliceBlue;
            txt_Result.OnLeaveBackColor = Color.White;
            txt_Result.SelectAllTextOnEnter = false;
            txt_Result.Size = new Size(749, 235);
            txt_Result.TabIndex = 0;
            txt_Result.TabOnEnter = true;
            txt_Result.ValidateAsDate = false;
            txt_Result.WarningMessageDate = "Invalid date format.";
            // 
            // Frm_ResultadoComparacao2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 583);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "Frm_ResultadoComparacao2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resultado da Comparacao";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btn_GerarSQL;
        private Button btn_CopiarSQL;
        private TableLayoutPanel tableLayoutPanel1;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_SqlGerado;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_Result;
        private Button btn_Fechar;
    }
}