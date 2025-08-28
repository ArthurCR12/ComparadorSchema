namespace ComparadorSchema
{
    partial class Frm_SelecionarBancos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_Segundo = new Panel();
            list_Segundo = new ListBox();
            btn_TesteCon2 = new Button();
            label3 = new Label();
            txt_ServerSegundo = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_PasswordSegundo = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_PortSegundo = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_UserNameSegundo = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            panel_Primeiro = new Panel();
            list_Primeiro = new ListBox();
            btn_TesteCon1 = new Button();
            label2 = new Label();
            txt_PasswordPrimeiro = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_UserNamePrimeiro = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_PortPrimeiro = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            txt_ServerPrimeiro = new Acr.WindowsForms.Controls.Controls.Acr_TextBox();
            panel4 = new Panel();
            label1 = new Label();
            cbx_BancoDados = new ComboBox();
            panel1 = new Panel();
            btn_Retornar = new Button();
            lbl_SegundoBanco = new Label();
            lbl_PrimeiroBanco = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel_Segundo.SuspendLayout();
            panel_Primeiro.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel_Segundo, 1, 1);
            tableLayoutPanel1.Controls.Add(panel_Primeiro, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 217F));
            tableLayoutPanel1.Size = new Size(718, 352);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_Segundo
            // 
            panel_Segundo.Controls.Add(list_Segundo);
            panel_Segundo.Controls.Add(btn_TesteCon2);
            panel_Segundo.Controls.Add(label3);
            panel_Segundo.Controls.Add(txt_ServerSegundo);
            panel_Segundo.Controls.Add(txt_PasswordSegundo);
            panel_Segundo.Controls.Add(txt_PortSegundo);
            panel_Segundo.Controls.Add(txt_UserNameSegundo);
            panel_Segundo.Dock = DockStyle.Fill;
            panel_Segundo.Location = new Point(362, 72);
            panel_Segundo.Name = "panel_Segundo";
            panel_Segundo.Size = new Size(353, 277);
            panel_Segundo.TabIndex = 2;
            // 
            // list_Segundo
            // 
            list_Segundo.FormattingEnabled = true;
            list_Segundo.Location = new Point(32, 181);
            list_Segundo.Name = "list_Segundo";
            list_Segundo.Size = new Size(288, 69);
            list_Segundo.TabIndex = 6;
            list_Segundo.SelectedIndexChanged += list_Segundo_SelectedIndexChanged;
            // 
            // btn_TesteCon2
            // 
            btn_TesteCon2.Location = new Point(32, 148);
            btn_TesteCon2.Name = "btn_TesteCon2";
            btn_TesteCon2.Size = new Size(122, 20);
            btn_TesteCon2.TabIndex = 5;
            btn_TesteCon2.Text = "Teste Conexão";
            btn_TesteCon2.UseVisualStyleBackColor = true;
            btn_TesteCon2.Click += btn_TesteCon2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fira Code SemiBold", 10F, FontStyle.Bold);
            label3.Location = new Point(60, 10);
            label3.Name = "label3";
            label3.Size = new Size(233, 17);
            label3.TabIndex = 0;
            label3.Text = "Selecione o segundo banco";
            // 
            // txt_ServerSegundo
            // 
            txt_ServerSegundo.Font = new Font("Fira Code", 8.999999F);
            txt_ServerSegundo.ForeColor = Color.FromArgb(50, 50, 50);
            txt_ServerSegundo.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_ServerSegundo.LabelTitle = false;
            txt_ServerSegundo.LabelTitleText = "";
            txt_ServerSegundo.Location = new Point(32, 49);
            txt_ServerSegundo.Name = "txt_ServerSegundo";
            txt_ServerSegundo.OnEnterBackColor = Color.AliceBlue;
            txt_ServerSegundo.OnLeaveBackColor = Color.White;
            txt_ServerSegundo.PlaceholderText = "Server:";
            txt_ServerSegundo.SelectAllTextOnEnter = false;
            txt_ServerSegundo.Size = new Size(288, 22);
            txt_ServerSegundo.TabIndex = 1;
            txt_ServerSegundo.TabOnEnter = true;
            txt_ServerSegundo.Tag = "Server";
            txt_ServerSegundo.ValidateAsDate = false;
            txt_ServerSegundo.WarningMessageDate = "Invalid date format.";
            // 
            // txt_PasswordSegundo
            // 
            txt_PasswordSegundo.Font = new Font("Fira Code", 8.999999F);
            txt_PasswordSegundo.ForeColor = Color.FromArgb(50, 50, 50);
            txt_PasswordSegundo.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_PasswordSegundo.LabelTitle = false;
            txt_PasswordSegundo.LabelTitleText = "";
            txt_PasswordSegundo.Location = new Point(32, 124);
            txt_PasswordSegundo.Name = "txt_PasswordSegundo";
            txt_PasswordSegundo.OnEnterBackColor = Color.AliceBlue;
            txt_PasswordSegundo.OnLeaveBackColor = Color.White;
            txt_PasswordSegundo.PasswordChar = '.';
            txt_PasswordSegundo.PlaceholderText = "Password:";
            txt_PasswordSegundo.SelectAllTextOnEnter = false;
            txt_PasswordSegundo.Size = new Size(288, 22);
            txt_PasswordSegundo.TabIndex = 4;
            txt_PasswordSegundo.TabOnEnter = true;
            txt_PasswordSegundo.Tag = "Password";
            txt_PasswordSegundo.ValidateAsDate = false;
            txt_PasswordSegundo.WarningMessageDate = "Invalid date format.";
            // 
            // txt_PortSegundo
            // 
            txt_PortSegundo.Font = new Font("Fira Code", 8.999999F);
            txt_PortSegundo.ForeColor = Color.FromArgb(50, 50, 50);
            txt_PortSegundo.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_PortSegundo.LabelTitle = false;
            txt_PortSegundo.LabelTitleText = "";
            txt_PortSegundo.Location = new Point(32, 74);
            txt_PortSegundo.Name = "txt_PortSegundo";
            txt_PortSegundo.OnEnterBackColor = Color.AliceBlue;
            txt_PortSegundo.OnLeaveBackColor = Color.White;
            txt_PortSegundo.PlaceholderText = "Port:";
            txt_PortSegundo.SelectAllTextOnEnter = false;
            txt_PortSegundo.Size = new Size(288, 22);
            txt_PortSegundo.TabIndex = 2;
            txt_PortSegundo.TabOnEnter = true;
            txt_PortSegundo.Tag = "Port";
            txt_PortSegundo.ValidateAsDate = false;
            txt_PortSegundo.WarningMessageDate = "Invalid date format.";
            // 
            // txt_UserNameSegundo
            // 
            txt_UserNameSegundo.Font = new Font("Fira Code", 8.999999F);
            txt_UserNameSegundo.ForeColor = Color.FromArgb(50, 50, 50);
            txt_UserNameSegundo.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_UserNameSegundo.LabelTitle = false;
            txt_UserNameSegundo.LabelTitleText = "";
            txt_UserNameSegundo.Location = new Point(32, 99);
            txt_UserNameSegundo.Name = "txt_UserNameSegundo";
            txt_UserNameSegundo.OnEnterBackColor = Color.AliceBlue;
            txt_UserNameSegundo.OnLeaveBackColor = Color.White;
            txt_UserNameSegundo.PlaceholderText = "User Name:";
            txt_UserNameSegundo.SelectAllTextOnEnter = false;
            txt_UserNameSegundo.Size = new Size(288, 22);
            txt_UserNameSegundo.TabIndex = 3;
            txt_UserNameSegundo.TabOnEnter = true;
            txt_UserNameSegundo.Tag = "User Name";
            txt_UserNameSegundo.ValidateAsDate = false;
            txt_UserNameSegundo.WarningMessageDate = "Invalid date format.";
            // 
            // panel_Primeiro
            // 
            panel_Primeiro.Controls.Add(list_Primeiro);
            panel_Primeiro.Controls.Add(btn_TesteCon1);
            panel_Primeiro.Controls.Add(label2);
            panel_Primeiro.Controls.Add(txt_PasswordPrimeiro);
            panel_Primeiro.Controls.Add(txt_UserNamePrimeiro);
            panel_Primeiro.Controls.Add(txt_PortPrimeiro);
            panel_Primeiro.Controls.Add(txt_ServerPrimeiro);
            panel_Primeiro.Dock = DockStyle.Fill;
            panel_Primeiro.Location = new Point(3, 72);
            panel_Primeiro.Name = "panel_Primeiro";
            panel_Primeiro.Size = new Size(353, 277);
            panel_Primeiro.TabIndex = 1;
            // 
            // list_Primeiro
            // 
            list_Primeiro.FormattingEnabled = true;
            list_Primeiro.Location = new Point(32, 181);
            list_Primeiro.Name = "list_Primeiro";
            list_Primeiro.Size = new Size(288, 69);
            list_Primeiro.TabIndex = 6;
            list_Primeiro.SelectedIndexChanged += list_Primeiro_SelectedIndexChanged;
            // 
            // btn_TesteCon1
            // 
            btn_TesteCon1.Location = new Point(32, 148);
            btn_TesteCon1.Name = "btn_TesteCon1";
            btn_TesteCon1.Size = new Size(122, 20);
            btn_TesteCon1.TabIndex = 5;
            btn_TesteCon1.Text = "Teste Conexão";
            btn_TesteCon1.UseVisualStyleBackColor = true;
            btn_TesteCon1.Click += btn_TesteCon1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fira Code SemiBold", 10F, FontStyle.Bold);
            label2.Location = new Point(51, 10);
            label2.Name = "label2";
            label2.Size = new Size(251, 17);
            label2.TabIndex = 0;
            label2.Text = "Selecione o primeiro banco ";
            // 
            // txt_PasswordPrimeiro
            // 
            txt_PasswordPrimeiro.Font = new Font("Fira Code", 8.999999F);
            txt_PasswordPrimeiro.ForeColor = Color.FromArgb(50, 50, 50);
            txt_PasswordPrimeiro.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_PasswordPrimeiro.LabelTitle = false;
            txt_PasswordPrimeiro.LabelTitleText = "";
            txt_PasswordPrimeiro.Location = new Point(32, 124);
            txt_PasswordPrimeiro.Name = "txt_PasswordPrimeiro";
            txt_PasswordPrimeiro.OnEnterBackColor = Color.AliceBlue;
            txt_PasswordPrimeiro.OnLeaveBackColor = Color.White;
            txt_PasswordPrimeiro.PasswordChar = '.';
            txt_PasswordPrimeiro.PlaceholderText = "Password:";
            txt_PasswordPrimeiro.SelectAllTextOnEnter = false;
            txt_PasswordPrimeiro.Size = new Size(288, 22);
            txt_PasswordPrimeiro.TabIndex = 4;
            txt_PasswordPrimeiro.TabOnEnter = true;
            txt_PasswordPrimeiro.Tag = "Password";
            txt_PasswordPrimeiro.Text = "acrtec1524";
            txt_PasswordPrimeiro.ValidateAsDate = false;
            txt_PasswordPrimeiro.WarningMessageDate = "Invalid date format.";
            // 
            // txt_UserNamePrimeiro
            // 
            txt_UserNamePrimeiro.Font = new Font("Fira Code", 8.999999F);
            txt_UserNamePrimeiro.ForeColor = Color.FromArgb(50, 50, 50);
            txt_UserNamePrimeiro.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_UserNamePrimeiro.LabelTitle = false;
            txt_UserNamePrimeiro.LabelTitleText = "";
            txt_UserNamePrimeiro.Location = new Point(32, 99);
            txt_UserNamePrimeiro.Name = "txt_UserNamePrimeiro";
            txt_UserNamePrimeiro.OnEnterBackColor = Color.AliceBlue;
            txt_UserNamePrimeiro.OnLeaveBackColor = Color.White;
            txt_UserNamePrimeiro.PlaceholderText = "User Name:";
            txt_UserNamePrimeiro.SelectAllTextOnEnter = false;
            txt_UserNamePrimeiro.Size = new Size(288, 22);
            txt_UserNamePrimeiro.TabIndex = 3;
            txt_UserNamePrimeiro.TabOnEnter = true;
            txt_UserNamePrimeiro.Tag = "User Name";
            txt_UserNamePrimeiro.Text = "root";
            txt_UserNamePrimeiro.ValidateAsDate = false;
            txt_UserNamePrimeiro.WarningMessageDate = "Invalid date format.";
            // 
            // txt_PortPrimeiro
            // 
            txt_PortPrimeiro.Font = new Font("Fira Code", 8.999999F);
            txt_PortPrimeiro.ForeColor = Color.FromArgb(50, 50, 50);
            txt_PortPrimeiro.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_PortPrimeiro.LabelTitle = false;
            txt_PortPrimeiro.LabelTitleText = "";
            txt_PortPrimeiro.Location = new Point(32, 74);
            txt_PortPrimeiro.Name = "txt_PortPrimeiro";
            txt_PortPrimeiro.OnEnterBackColor = Color.AliceBlue;
            txt_PortPrimeiro.OnLeaveBackColor = Color.White;
            txt_PortPrimeiro.PlaceholderText = "Port:";
            txt_PortPrimeiro.SelectAllTextOnEnter = false;
            txt_PortPrimeiro.Size = new Size(288, 22);
            txt_PortPrimeiro.TabIndex = 2;
            txt_PortPrimeiro.TabOnEnter = true;
            txt_PortPrimeiro.Tag = "Port";
            txt_PortPrimeiro.Text = "3308";
            txt_PortPrimeiro.ValidateAsDate = false;
            txt_PortPrimeiro.WarningMessageDate = "Invalid date format.";
            // 
            // txt_ServerPrimeiro
            // 
            txt_ServerPrimeiro.Font = new Font("Fira Code", 8.999999F);
            txt_ServerPrimeiro.ForeColor = Color.FromArgb(50, 50, 50);
            txt_ServerPrimeiro.InputType = Acr.WindowsForms.Controls.Enums.TextboxtInputType.All;
            txt_ServerPrimeiro.LabelTitle = false;
            txt_ServerPrimeiro.LabelTitleText = "";
            txt_ServerPrimeiro.Location = new Point(32, 49);
            txt_ServerPrimeiro.Name = "txt_ServerPrimeiro";
            txt_ServerPrimeiro.OnEnterBackColor = Color.AliceBlue;
            txt_ServerPrimeiro.OnLeaveBackColor = Color.White;
            txt_ServerPrimeiro.PlaceholderText = "Server:";
            txt_ServerPrimeiro.SelectAllTextOnEnter = false;
            txt_ServerPrimeiro.Size = new Size(288, 22);
            txt_ServerPrimeiro.TabIndex = 1;
            txt_ServerPrimeiro.TabOnEnter = true;
            txt_ServerPrimeiro.Tag = "Server";
            txt_ServerPrimeiro.Text = "localhost";
            txt_ServerPrimeiro.ValidateAsDate = false;
            txt_ServerPrimeiro.WarningMessageDate = "Invalid date format.";
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cbx_BancoDados);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 63);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 0;
            label1.Text = "Selecione o Banco de Dados";
            // 
            // cbx_BancoDados
            // 
            cbx_BancoDados.FormattingEnabled = true;
            cbx_BancoDados.Items.AddRange(new object[] { "Maria DB" });
            cbx_BancoDados.Location = new Point(9, 35);
            cbx_BancoDados.Name = "cbx_BancoDados";
            cbx_BancoDados.Size = new Size(255, 21);
            cbx_BancoDados.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Retornar);
            panel1.Controls.Add(lbl_SegundoBanco);
            panel1.Controls.Add(lbl_PrimeiroBanco);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 79);
            panel1.TabIndex = 1;
            // 
            // btn_Retornar
            // 
            btn_Retornar.Location = new Point(587, 13);
            btn_Retornar.Name = "btn_Retornar";
            btn_Retornar.Size = new Size(128, 54);
            btn_Retornar.TabIndex = 1;
            btn_Retornar.Text = "Retornar";
            btn_Retornar.UseVisualStyleBackColor = true;
            btn_Retornar.Click += btn_Retornar_Click;
            // 
            // lbl_SegundoBanco
            // 
            lbl_SegundoBanco.AutoSize = true;
            lbl_SegundoBanco.Font = new Font("Fira Code SemiBold", 9F, FontStyle.Bold);
            lbl_SegundoBanco.Location = new Point(16, 42);
            lbl_SegundoBanco.Name = "lbl_SegundoBanco";
            lbl_SegundoBanco.Size = new Size(175, 15);
            lbl_SegundoBanco.TabIndex = 0;
            lbl_SegundoBanco.Text = "Nenhum banco selecionado";
            // 
            // lbl_PrimeiroBanco
            // 
            lbl_PrimeiroBanco.AutoSize = true;
            lbl_PrimeiroBanco.Font = new Font("Fira Code SemiBold", 9F, FontStyle.Bold);
            lbl_PrimeiroBanco.Location = new Point(16, 13);
            lbl_PrimeiroBanco.Name = "lbl_PrimeiroBanco";
            lbl_PrimeiroBanco.Size = new Size(175, 15);
            lbl_PrimeiroBanco.TabIndex = 0;
            lbl_PrimeiroBanco.Text = "Nenhum banco selecionado";
            // 
            // Frm_SelecionarBancos
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 431);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Fira Code", 8.5F);
            Name = "Frm_SelecionarBancos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Selecionar Bancos";
            Load += Frm_SelecionarBancos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel_Segundo.ResumeLayout(false);
            panel_Segundo.PerformLayout();
            panel_Primeiro.ResumeLayout(false);
            panel_Primeiro.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_Segundo;
        private Panel panel_Primeiro;
        private Panel panel4;
        private Label label1;
        private ComboBox cbx_BancoDados;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_PasswordPrimeiro;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_UserNamePrimeiro;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_PortPrimeiro;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_ServerPrimeiro;
        private Label label2;
        private Label label3;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_ServerSegundo;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_PasswordSegundo;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_PortSegundo;
        private Acr.WindowsForms.Controls.Controls.Acr_TextBox txt_UserNameSegundo;
        private ListBox list_Primeiro;
        private Button btn_TesteCon1;
        private Button btn_TesteCon2;
        private Panel panel1;
        private ListBox list_Segundo;
        private Label lbl_SegundoBanco;
        private Label lbl_PrimeiroBanco;
        private Button btn_Retornar;
    }
}