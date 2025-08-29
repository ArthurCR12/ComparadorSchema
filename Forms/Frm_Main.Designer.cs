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
            btn_SelecionarBancos = new Button();
            gbox_TabelasBanco1 = new GroupBox();
            list_TabelasBanco1 = new ListBox();
            label4 = new Label();
            lbl_TblSelectBanco1 = new Label();
            gbox_TabelasBanco2 = new GroupBox();
            list_TabelasBanco2 = new ListBox();
            label5 = new Label();
            lbl_TblSelectBanco2 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            dgv_DadosTblBd1 = new DataGridView();
            dgv_InfoFKBanco1 = new DataGridView();
            dgv_InfoTabelaBd1 = new DataGridView();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgv_DadosTblBd2 = new DataGridView();
            dgv_InfoFKBanco2 = new DataGridView();
            dgv_InfoTabelaBd2 = new DataGridView();
            gbox_TabelasBanco1.SuspendLayout();
            gbox_TabelasBanco2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosTblBd1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoFKBanco1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoTabelaBd1).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosTblBd2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoFKBanco2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoTabelaBd2).BeginInit();
            SuspendLayout();
            // 
            // btn_SelecionarBancos
            // 
            btn_SelecionarBancos.Location = new Point(12, 12);
            btn_SelecionarBancos.Name = "btn_SelecionarBancos";
            btn_SelecionarBancos.Size = new Size(134, 27);
            btn_SelecionarBancos.TabIndex = 0;
            btn_SelecionarBancos.Text = "Selecionar Bancos";
            btn_SelecionarBancos.UseVisualStyleBackColor = true;
            btn_SelecionarBancos.Click += btn_SelecionarBancos_Click;
            // 
            // gbox_TabelasBanco1
            // 
            gbox_TabelasBanco1.Controls.Add(list_TabelasBanco1);
            gbox_TabelasBanco1.Controls.Add(label4);
            gbox_TabelasBanco1.Controls.Add(lbl_TblSelectBanco1);
            gbox_TabelasBanco1.Location = new Point(12, 68);
            gbox_TabelasBanco1.Name = "gbox_TabelasBanco1";
            gbox_TabelasBanco1.Size = new Size(236, 250);
            gbox_TabelasBanco1.TabIndex = 6;
            gbox_TabelasBanco1.TabStop = false;
            gbox_TabelasBanco1.Text = "Tabelas Banco 1";
            // 
            // list_TabelasBanco1
            // 
            list_TabelasBanco1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            list_TabelasBanco1.FormattingEnabled = true;
            list_TabelasBanco1.Location = new Point(6, 24);
            list_TabelasBanco1.Name = "list_TabelasBanco1";
            list_TabelasBanco1.Size = new Size(224, 184);
            list_TabelasBanco1.TabIndex = 0;
            list_TabelasBanco1.Tag = "TblBanco1";
            list_TabelasBanco1.SelectedIndexChanged += list_TabelasBanco1_SelectedIndexChanged;
            list_TabelasBanco1.DoubleClick += list_TabelasBanco1_DoubleClick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Tabela Selec:";
            // 
            // lbl_TblSelectBanco1
            // 
            lbl_TblSelectBanco1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_TblSelectBanco1.AutoSize = true;
            lbl_TblSelectBanco1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_TblSelectBanco1.Location = new Point(86, 219);
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
            gbox_TabelasBanco2.Location = new Point(12, 324);
            gbox_TabelasBanco2.Name = "gbox_TabelasBanco2";
            gbox_TabelasBanco2.Size = new Size(236, 250);
            gbox_TabelasBanco2.TabIndex = 6;
            gbox_TabelasBanco2.TabStop = false;
            gbox_TabelasBanco2.Text = "Tabelas Banco 2";
            // 
            // list_TabelasBanco2
            // 
            list_TabelasBanco2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            list_TabelasBanco2.FormattingEnabled = true;
            list_TabelasBanco2.Location = new Point(6, 22);
            list_TabelasBanco2.Name = "list_TabelasBanco2";
            list_TabelasBanco2.Size = new Size(224, 184);
            list_TabelasBanco2.TabIndex = 0;
            list_TabelasBanco2.Tag = "TblBanco2";
            list_TabelasBanco2.SelectedIndexChanged += list_TabelasBanco2_SelectedIndexChanged;
            list_TabelasBanco2.DoubleClick += list_TabelasBanco2_DoubleClick;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(6, 219);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 5;
            label5.Text = "Tabela Selec:";
            // 
            // lbl_TblSelectBanco2
            // 
            lbl_TblSelectBanco2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_TblSelectBanco2.AutoSize = true;
            lbl_TblSelectBanco2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_TblSelectBanco2.Location = new Point(86, 219);
            lbl_TblSelectBanco2.Name = "lbl_TblSelectBanco2";
            lbl_TblSelectBanco2.Size = new Size(12, 15);
            lbl_TblSelectBanco2.TabIndex = 4;
            lbl_TblSelectBanco2.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(254, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 250);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Tabela";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgv_DadosTblBd1);
            panel1.Controls.Add(dgv_InfoFKBanco1);
            panel1.Controls.Add(dgv_InfoTabelaBd1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 228);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(702, 13);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 5;
            label7.Text = "Dados Limit 10";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(356, 13);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Foreing Key";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(10, 13);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "Schema Tabela";
            // 
            // dgv_DadosTblBd1
            // 
            dgv_DadosTblBd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DadosTblBd1.Location = new Point(702, 31);
            dgv_DadosTblBd1.MultiSelect = false;
            dgv_DadosTblBd1.Name = "dgv_DadosTblBd1";
            dgv_DadosTblBd1.ReadOnly = true;
            dgv_DadosTblBd1.RowHeadersVisible = false;
            dgv_DadosTblBd1.Size = new Size(340, 184);
            dgv_DadosTblBd1.TabIndex = 0;
            // 
            // dgv_InfoFKBanco1
            // 
            dgv_InfoFKBanco1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InfoFKBanco1.Location = new Point(356, 31);
            dgv_InfoFKBanco1.MultiSelect = false;
            dgv_InfoFKBanco1.Name = "dgv_InfoFKBanco1";
            dgv_InfoFKBanco1.ReadOnly = true;
            dgv_InfoFKBanco1.RowHeadersVisible = false;
            dgv_InfoFKBanco1.Size = new Size(340, 184);
            dgv_InfoFKBanco1.TabIndex = 0;
            // 
            // dgv_InfoTabelaBd1
            // 
            dgv_InfoTabelaBd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InfoTabelaBd1.Location = new Point(10, 31);
            dgv_InfoTabelaBd1.MultiSelect = false;
            dgv_InfoTabelaBd1.Name = "dgv_InfoTabelaBd1";
            dgv_InfoTabelaBd1.ReadOnly = true;
            dgv_InfoTabelaBd1.RowHeadersVisible = false;
            dgv_InfoTabelaBd1.Size = new Size(340, 184);
            dgv_InfoTabelaBd1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(254, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1060, 250);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados da Tabela";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dgv_DadosTblBd2);
            panel2.Controls.Add(dgv_InfoFKBanco2);
            panel2.Controls.Add(dgv_InfoTabelaBd2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(1054, 228);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(702, 13);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 5;
            label8.Text = "Dados Limit 10";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(356, 13);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 5;
            label9.Text = "Foreing Key";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(10, 13);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 5;
            label10.Text = "Schema Tabela";
            // 
            // dgv_DadosTblBd2
            // 
            dgv_DadosTblBd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DadosTblBd2.Location = new Point(702, 31);
            dgv_DadosTblBd2.MultiSelect = false;
            dgv_DadosTblBd2.Name = "dgv_DadosTblBd2";
            dgv_DadosTblBd2.ReadOnly = true;
            dgv_DadosTblBd2.RowHeadersVisible = false;
            dgv_DadosTblBd2.Size = new Size(340, 184);
            dgv_DadosTblBd2.TabIndex = 0;
            // 
            // dgv_InfoFKBanco2
            // 
            dgv_InfoFKBanco2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InfoFKBanco2.Location = new Point(356, 31);
            dgv_InfoFKBanco2.MultiSelect = false;
            dgv_InfoFKBanco2.Name = "dgv_InfoFKBanco2";
            dgv_InfoFKBanco2.ReadOnly = true;
            dgv_InfoFKBanco2.RowHeadersVisible = false;
            dgv_InfoFKBanco2.Size = new Size(340, 184);
            dgv_InfoFKBanco2.TabIndex = 0;
            // 
            // dgv_InfoTabelaBd2
            // 
            dgv_InfoTabelaBd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_InfoTabelaBd2.Location = new Point(10, 31);
            dgv_InfoTabelaBd2.MultiSelect = false;
            dgv_InfoTabelaBd2.Name = "dgv_InfoTabelaBd2";
            dgv_InfoTabelaBd2.ReadOnly = true;
            dgv_InfoTabelaBd2.RowHeadersVisible = false;
            dgv_InfoTabelaBd2.Size = new Size(340, 184);
            dgv_InfoTabelaBd2.TabIndex = 0;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 783);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbox_TabelasBanco2);
            Controls.Add(gbox_TabelasBanco1);
            Controls.Add(btn_SelecionarBancos);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comparador de Schemas";
            gbox_TabelasBanco1.ResumeLayout(false);
            gbox_TabelasBanco1.PerformLayout();
            gbox_TabelasBanco2.ResumeLayout(false);
            gbox_TabelasBanco2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosTblBd1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoFKBanco1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoTabelaBd1).EndInit();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DadosTblBd2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoFKBanco2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_InfoTabelaBd2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_SelecionarBancos;
        private GroupBox gbox_TabelasBanco1;
        private GroupBox gbox_TabelasBanco2;
        private ListBox list_TabelasBanco1;
        private ListBox list_TabelasBanco2;
        private Label label4;
        private Label lbl_TblSelectBanco1;
        private Label label5;
        private Label lbl_TblSelectBanco2;
        private GroupBox groupBox1;
        private DataGridView dgv_InfoTabelaBd1;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label3;
        private DataGridView dgv_DadosTblBd1;
        private DataGridView dgv_InfoFKBanco1;
        private GroupBox groupBox2;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dgv_DadosTblBd2;
        private DataGridView dgv_InfoFKBanco2;
        private DataGridView dgv_InfoTabelaBd2;
    }
}
