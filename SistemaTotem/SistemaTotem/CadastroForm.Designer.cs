namespace SistemaTotem
{
    partial class CadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            this.DesingTelaInicial = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LogoCPS = new System.Windows.Forms.PictureBox();
            this.LabelSubTitulo = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CheckManterConectado = new System.Windows.Forms.CheckBox();
            this.LabelEntrarComo = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.BoxUsu = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxTUsu = new System.Windows.Forms.TextBox();
            this.LabelFazerLogin = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DesingTelaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCPS)).BeginInit();
            this.SuspendLayout();
            // 
            // DesingTelaInicial
            // 
            this.DesingTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("DesingTelaInicial.Image")));
            this.DesingTelaInicial.Location = new System.Drawing.Point(-22, -88);
            this.DesingTelaInicial.Name = "DesingTelaInicial";
            this.DesingTelaInicial.Size = new System.Drawing.Size(535, 668);
            this.DesingTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DesingTelaInicial.TabIndex = 6;
            this.DesingTelaInicial.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelTitulo.Font = new System.Drawing.Font("Cambria", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTitulo.Location = new System.Drawing.Point(124, 198);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(178, 46);
            this.LabelTitulo.TabIndex = 34;
            this.LabelTitulo.Text = "Cadastro";
            this.LabelTitulo.Click += new System.EventHandler(this.LabelTitulo_Click_1);
            // 
            // LogoCPS
            // 
            this.LogoCPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LogoCPS.Image = ((System.Drawing.Image)(resources.GetObject("LogoCPS.Image")));
            this.LogoCPS.Location = new System.Drawing.Point(46, 35);
            this.LogoCPS.Name = "LogoCPS";
            this.LogoCPS.Size = new System.Drawing.Size(100, 80);
            this.LogoCPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoCPS.TabIndex = 35;
            this.LogoCPS.TabStop = false;
            // 
            // LabelSubTitulo
            // 
            this.LabelSubTitulo.AutoSize = true;
            this.LabelSubTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelSubTitulo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelSubTitulo.Location = new System.Drawing.Point(118, 255);
            this.LabelSubTitulo.Name = "LabelSubTitulo";
            this.LabelSubTitulo.Size = new System.Drawing.Size(199, 25);
            this.LabelSubTitulo.TabIndex = 36;
            this.LabelSubTitulo.Text = "Seja Bem Vindo(a)!";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(738, 396);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(150, 41);
            this.LoginBtn.TabIndex = 53;
            this.LoginBtn.Text = "Registrar";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CheckManterConectado
            // 
            this.CheckManterConectado.AutoSize = true;
            this.CheckManterConectado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckManterConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckManterConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.CheckManterConectado.Location = new System.Drawing.Point(723, 354);
            this.CheckManterConectado.Name = "CheckManterConectado";
            this.CheckManterConectado.Size = new System.Drawing.Size(178, 17);
            this.CheckManterConectado.TabIndex = 52;
            this.CheckManterConectado.Text = "Deseja permanecer conectado?";
            this.CheckManterConectado.UseVisualStyleBackColor = false;
            this.CheckManterConectado.CheckedChanged += new System.EventHandler(this.CheckManterConectado_CheckedChanged);
            // 
            // LabelEntrarComo
            // 
            this.LabelEntrarComo.AutoSize = true;
            this.LabelEntrarComo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntrarComo.Location = new System.Drawing.Point(573, 308);
            this.LabelEntrarComo.Name = "LabelEntrarComo";
            this.LabelEntrarComo.Size = new System.Drawing.Size(108, 20);
            this.LabelEntrarComo.TabIndex = 51;
            this.LabelEntrarComo.Text = "Tipo de Conta";
            this.LabelEntrarComo.Click += new System.EventHandler(this.LabelEntrarComo_Click);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(617, 213);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(64, 20);
            this.LabelSenha.TabIndex = 50;
            this.LabelSenha.Text = "Usuário";
            this.LabelSenha.Click += new System.EventHandler(this.LabelSenha_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(630, 165);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(51, 20);
            this.LabelUsuario.TabIndex = 49;
            this.LabelUsuario.Text = "Nome";
            this.LabelUsuario.Click += new System.EventHandler(this.LabelUsuario_Click);
            // 
            // BoxUsu
            // 
            this.BoxUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoxUsu.FormattingEnabled = true;
            this.BoxUsu.Items.AddRange(new object[] {
            "Membro Grêmio",
            "Funcionário Secretária"});
            this.BoxUsu.Location = new System.Drawing.Point(698, 307);
            this.BoxUsu.Name = "BoxUsu";
            this.BoxUsu.Size = new System.Drawing.Size(259, 21);
            this.BoxUsu.TabIndex = 48;
            this.BoxUsu.SelectedIndexChanged += new System.EventHandler(this.BoxUsu_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(698, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxTUsu
            // 
            this.TxTUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxTUsu.Location = new System.Drawing.Point(698, 213);
            this.TxTUsu.Name = "TxTUsu";
            this.TxTUsu.Size = new System.Drawing.Size(256, 20);
            this.TxTUsu.TabIndex = 46;
            this.TxTUsu.TextChanged += new System.EventHandler(this.TxTUsu_TextChanged);
            // 
            // LabelFazerLogin
            // 
            this.LabelFazerLogin.AutoSize = true;
            this.LabelFazerLogin.BackColor = System.Drawing.Color.White;
            this.LabelFazerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFazerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelFazerLogin.Location = new System.Drawing.Point(708, 109);
            this.LabelFazerLogin.Name = "LabelFazerLogin";
            this.LabelFazerLogin.Size = new System.Drawing.Size(237, 25);
            this.LabelFazerLogin.TabIndex = 45;
            this.LabelFazerLogin.Text = "Faça seu cadastro aqui";
            this.LabelFazerLogin.Click += new System.EventHandler(this.LabelFazerLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(698, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Senha";
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1064, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.CheckManterConectado);
            this.Controls.Add(this.LabelEntrarComo);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.BoxUsu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxTUsu);
            this.Controls.Add(this.LabelFazerLogin);
            this.Controls.Add(this.LabelSubTitulo);
            this.Controls.Add(this.LogoCPS);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.DesingTelaInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CadastroForm";
            this.Text = "CadastroForm";
            this.Load += new System.EventHandler(this.CadastroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DesingTelaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DesingTelaInicial;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.PictureBox LogoCPS;
        private System.Windows.Forms.Label LabelSubTitulo;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.CheckBox CheckManterConectado;
        private System.Windows.Forms.Label LabelEntrarComo;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.ComboBox BoxUsu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxTUsu;
        private System.Windows.Forms.Label LabelFazerLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}