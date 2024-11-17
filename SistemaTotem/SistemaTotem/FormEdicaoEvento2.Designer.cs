namespace SistemaTotem
{
    partial class FormEdicaoEvento2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdicaoEvento2));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.BotaoAlterar = new System.Windows.Forms.Button();
            this.TxtEventos = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Location = new System.Drawing.Point(179, 48);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(1028, 618);
            this.FlowPainelEvento.TabIndex = 11;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.txtDesc);
            this.PainelEvento.Controls.Add(this.TxtEventos);
            this.PainelEvento.Controls.Add(this.button2);
            this.PainelEvento.Controls.Add(this.FotoPerfil);
            this.PainelEvento.Controls.Add(this.btnFoto);
            this.PainelEvento.Controls.Add(this.label2);
            this.PainelEvento.Controls.Add(this.label1);
            this.PainelEvento.Controls.Add(this.BotaoExcluir);
            this.PainelEvento.Controls.Add(this.BotaoSalvar);
            this.PainelEvento.Controls.Add(this.BotaoAlterar);
            this.PainelEvento.Location = new System.Drawing.Point(4, 4);
            this.PainelEvento.Margin = new System.Windows.Forms.Padding(4);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(1024, 614);
            this.PainelEvento.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(797, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "ESCOLHER FOTO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BackColor = System.Drawing.Color.White;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(527, 90);
            this.FotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(143, 133);
            this.FotoPerfil.TabIndex = 25;
            this.FotoPerfil.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.White;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Location = new System.Drawing.Point(431, 47);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(340, 229);
            this.btnFoto.TabIndex = 24;
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(72, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Evento:";
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoExcluir.Location = new System.Drawing.Point(207, 112);
            this.BotaoExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(113, 50);
            this.BotaoExcluir.TabIndex = 19;
            this.BotaoExcluir.Text = "EXCLUIR";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSalvar.Location = new System.Drawing.Point(207, 36);
            this.BotaoSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(113, 50);
            this.BotaoSalvar.TabIndex = 18;
            this.BotaoSalvar.Text = "SALVAR";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // BotaoAlterar
            // 
            this.BotaoAlterar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAlterar.Location = new System.Drawing.Point(207, 186);
            this.BotaoAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoAlterar.Name = "BotaoAlterar";
            this.BotaoAlterar.Size = new System.Drawing.Size(113, 50);
            this.BotaoAlterar.TabIndex = 17;
            this.BotaoAlterar.Text = "ALTERAR";
            this.BotaoAlterar.UseVisualStyleBackColor = true;
            // 
            // TxtEventos
            // 
            this.TxtEventos.Location = new System.Drawing.Point(270, 318);
            this.TxtEventos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEventos.Multiline = true;
            this.TxtEventos.Name = "TxtEventos";
            this.TxtEventos.Size = new System.Drawing.Size(196, 41);
            this.TxtEventos.TabIndex = 29;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(270, 407);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(579, 153);
            this.txtDesc.TabIndex = 30;
            // 
            // FormEdicaoEvento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 737);
            this.Controls.Add(this.FlowPainelEvento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEdicaoEvento2";
            this.Text = "Edição - Evento ";
            this.FlowPainelEvento.ResumeLayout(false);
            this.PainelEvento.ResumeLayout(false);
            this.PainelEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowPainelEvento;
        private System.Windows.Forms.Panel PainelEvento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoExcluir;
        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Button BotaoAlterar;
        private System.Windows.Forms.TextBox TxtEventos;
        private System.Windows.Forms.TextBox txtDesc;
    }
}