namespace SistemaTotem
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.DesingTelaInicial = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LogoCPS = new System.Windows.Forms.PictureBox();
            this.LabelSubTitulo = new System.Windows.Forms.Label();
            this.LabelFazerLogin = new System.Windows.Forms.Label();
            this.TxTUsu = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BoxUsu = new System.Windows.Forms.ComboBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelEntrarComo = new System.Windows.Forms.Label();
            this.CheckManterConectado = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DesingTelaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCPS)).BeginInit();
            this.SuspendLayout();
            // 
            // DesingTelaInicial
            // 
            this.DesingTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("DesingTelaInicial.Image")));
            this.DesingTelaInicial.Location = new System.Drawing.Point(-8, -89);
            this.DesingTelaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DesingTelaInicial.Name = "DesingTelaInicial";
            this.DesingTelaInicial.Size = new System.Drawing.Size(683, 822);
            this.DesingTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DesingTelaInicial.TabIndex = 5;
            this.DesingTelaInicial.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelTitulo.Font = new System.Drawing.Font("Cambria", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTitulo.Location = new System.Drawing.Point(203, 246);
            this.LabelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(150, 58);
            this.LabelTitulo.TabIndex = 33;
            this.LabelTitulo.Text = "Login";
            this.LabelTitulo.Click += new System.EventHandler(this.LabelTitulo_Click);
            // 
            // LogoCPS
            // 
            this.LogoCPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LogoCPS.Image = ((System.Drawing.Image)(resources.GetObject("LogoCPS.Image")));
            this.LogoCPS.Location = new System.Drawing.Point(51, 54);
            this.LogoCPS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoCPS.Name = "LogoCPS";
            this.LogoCPS.Size = new System.Drawing.Size(133, 98);
            this.LogoCPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoCPS.TabIndex = 34;
            this.LogoCPS.TabStop = false;
            // 
            // LabelSubTitulo
            // 
            this.LabelSubTitulo.AutoSize = true;
            this.LabelSubTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelSubTitulo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelSubTitulo.Location = new System.Drawing.Point(148, 326);
            this.LabelSubTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSubTitulo.Name = "LabelSubTitulo";
            this.LabelSubTitulo.Size = new System.Drawing.Size(249, 32);
            this.LabelSubTitulo.TabIndex = 35;
            this.LabelSubTitulo.Text = "Seja Bem Vindo(a)!";
            this.LabelSubTitulo.Click += new System.EventHandler(this.LabelSubTitulo_Click);
            // 
            // LabelFazerLogin
            // 
            this.LabelFazerLogin.AutoSize = true;
            this.LabelFazerLogin.BackColor = System.Drawing.Color.White;
            this.LabelFazerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFazerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.LabelFazerLogin.Location = new System.Drawing.Point(957, 139);
            this.LabelFazerLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFazerLogin.Name = "LabelFazerLogin";
            this.LabelFazerLogin.Size = new System.Drawing.Size(248, 31);
            this.LabelFazerLogin.TabIndex = 36;
            this.LabelFazerLogin.Text = "Faça seu login aqui";
            this.LabelFazerLogin.Click += new System.EventHandler(this.LabelFazerLogin_Click);
            // 
            // TxTUsu
            // 
            this.TxTUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxTUsu.Location = new System.Drawing.Point(920, 281);
            this.TxTUsu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxTUsu.Name = "TxTUsu";
            this.TxTUsu.Size = new System.Drawing.Size(340, 22);
            this.TxTUsu.TabIndex = 37;
            this.TxTUsu.TextChanged += new System.EventHandler(this.TxTUsu_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(924, 223);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 22);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BoxUsu
            // 
            this.BoxUsu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoxUsu.FormattingEnabled = true;
            this.BoxUsu.Items.AddRange(new object[] {
            "Membro Grêmio",
            "Funcionário Secretária"});
            this.BoxUsu.Location = new System.Drawing.Point(920, 335);
            this.BoxUsu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxUsu.Name = "BoxUsu";
            this.BoxUsu.Size = new System.Drawing.Size(344, 24);
            this.BoxUsu.TabIndex = 39;
            this.BoxUsu.SelectedIndexChanged += new System.EventHandler(this.BoxUsu_SelectedIndexChanged);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(803, 223);
            this.LabelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(79, 25);
            this.LabelUsuario.TabIndex = 40;
            this.LabelUsuario.Text = "Usuário";
            this.LabelUsuario.Click += new System.EventHandler(this.LabelUsuario_Click);
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(813, 278);
            this.LabelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(70, 25);
            this.LabelSenha.TabIndex = 41;
            this.LabelSenha.Text = "Senha";
            this.LabelSenha.Click += new System.EventHandler(this.LabelSenha_Click);
            // 
            // LabelEntrarComo
            // 
            this.LabelEntrarComo.AutoSize = true;
            this.LabelEntrarComo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntrarComo.Location = new System.Drawing.Point(760, 332);
            this.LabelEntrarComo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEntrarComo.Name = "LabelEntrarComo";
            this.LabelEntrarComo.Size = new System.Drawing.Size(117, 25);
            this.LabelEntrarComo.TabIndex = 42;
            this.LabelEntrarComo.Text = "Entrar como";
            this.LabelEntrarComo.Click += new System.EventHandler(this.LabelEntrarComo_Click);
            // 
            // CheckManterConectado
            // 
            this.CheckManterConectado.AutoSize = true;
            this.CheckManterConectado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckManterConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckManterConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.CheckManterConectado.Location = new System.Drawing.Point(972, 395);
            this.CheckManterConectado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckManterConectado.Name = "CheckManterConectado";
            this.CheckManterConectado.Size = new System.Drawing.Size(161, 20);
            this.CheckManterConectado.TabIndex = 43;
            this.CheckManterConectado.Text = "Não possuí cadastro?";
            this.CheckManterConectado.UseVisualStyleBackColor = false;
            this.CheckManterConectado.CheckedChanged += new System.EventHandler(this.CheckManterConectado_CheckedChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(982, 437);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(200, 50);
            this.LoginBtn.TabIndex = 44;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1396, 630);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
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
        private System.Windows.Forms.Label LabelFazerLogin;
        private System.Windows.Forms.TextBox TxTUsu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox BoxUsu;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelEntrarComo;
        private System.Windows.Forms.CheckBox CheckManterConectado;
        private System.Windows.Forms.Button LoginBtn;
    }
}

