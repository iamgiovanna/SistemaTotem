namespace SistemaTotem
{
    partial class FormVest1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVest1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubTituloENEM = new System.Windows.Forms.Label();
            this.TituloEnem = new System.Windows.Forms.Label();
            this.SiteInfoOfficial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.txtEnem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.txtEnem);
            this.panel1.Controls.Add(this.SubTituloENEM);
            this.panel1.Controls.Add(this.TituloEnem);
            this.panel1.Controls.Add(this.SiteInfoOfficial);
            this.panel1.Location = new System.Drawing.Point(150, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 433);
            this.panel1.TabIndex = 1;
            // 
            // SubTituloENEM
            // 
            this.SubTituloENEM.AutoSize = true;
            this.SubTituloENEM.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTituloENEM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTituloENEM.Location = new System.Drawing.Point(239, 56);
            this.SubTituloENEM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubTituloENEM.Name = "SubTituloENEM";
            this.SubTituloENEM.Size = new System.Drawing.Size(232, 25);
            this.SubTituloENEM.TabIndex = 4;
            this.SubTituloENEM.Text = "Calendário ENEM 2024\r\n";
            // 
            // TituloEnem
            // 
            this.TituloEnem.AutoSize = true;
            this.TituloEnem.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEnem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloEnem.Location = new System.Drawing.Point(318, 19);
            this.TituloEnem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TituloEnem.Name = "TituloEnem";
            this.TituloEnem.Size = new System.Drawing.Size(76, 28);
            this.TituloEnem.TabIndex = 3;
            this.TituloEnem.Text = "ENEM";
            // 
            // SiteInfoOfficial
            // 
            this.SiteInfoOfficial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SiteInfoOfficial.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteInfoOfficial.Location = new System.Drawing.Point(223, 371);
            this.SiteInfoOfficial.Name = "SiteInfoOfficial";
            this.SiteInfoOfficial.Size = new System.Drawing.Size(266, 32);
            this.SiteInfoOfficial.TabIndex = 2;
            this.SiteInfoOfficial.Text = "Para mais informaçõoes, acesse o site oficial: www.gov.br";
            this.SiteInfoOfficial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(30, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 48);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(30, 256);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 40);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(30, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 40);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExluir
            // 
            this.btnExluir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluir.Location = new System.Drawing.Point(30, 138);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(80, 40);
            this.btnExluir.TabIndex = 19;
            this.btnExluir.Text = "EXCLUIR";
            this.btnExluir.UseVisualStyleBackColor = true;
            // 
            // txtEnem
            // 
            this.txtEnem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEnem.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnem.Location = new System.Drawing.Point(167, 93);
            this.txtEnem.Multiline = true;
            this.txtEnem.Name = "txtEnem";
            this.txtEnem.Size = new System.Drawing.Size(388, 255);
            this.txtEnem.TabIndex = 6;
            this.txtEnem.Text = resources.GetString("txtEnem.Text");
            this.txtEnem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormVest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 523);
            this.Controls.Add(this.btnExluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FormVest1";
            this.Text = "Enem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SubTituloENEM;
        private System.Windows.Forms.Label TituloEnem;
        private System.Windows.Forms.Label SiteInfoOfficial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.TextBox txtEnem;
    }
}