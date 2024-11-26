namespace SistemaTotem
{
    partial class FormEdicaoEvento1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdicaoEvento1));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.txtEventos = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.Desc = new System.Windows.Forms.Label();
            this.Evento = new System.Windows.Forms.Label();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.BotaoAlterar = new System.Windows.Forms.Button();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Location = new System.Drawing.Point(132, 35);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(771, 502);
            this.FlowPainelEvento.TabIndex = 9;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.txtEventos);
            this.PainelEvento.Controls.Add(this.txtDesc);
            this.PainelEvento.Controls.Add(this.button2);
            this.PainelEvento.Controls.Add(this.FotoPerfil);
            this.PainelEvento.Controls.Add(this.btnFoto);
            this.PainelEvento.Controls.Add(this.Desc);
            this.PainelEvento.Controls.Add(this.Evento);
            this.PainelEvento.Controls.Add(this.BotaoExcluir);
            this.PainelEvento.Controls.Add(this.BotaoAlterar);
            this.PainelEvento.Location = new System.Drawing.Point(3, 3);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(768, 499);
            this.PainelEvento.TabIndex = 0;
            // 
            // txtEventos
            // 
            this.txtEventos.Location = new System.Drawing.Point(199, 258);
            this.txtEventos.Multiline = true;
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(148, 34);
            this.txtEventos.TabIndex = 28;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(199, 325);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(435, 125);
            this.txtDesc.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(598, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "ESCOLHER FOTO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BackColor = System.Drawing.Color.White;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(324, 39);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(254, 185);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FotoPerfil.TabIndex = 25;
            this.FotoPerfil.TabStop = false;
            this.FotoPerfil.Click += new System.EventHandler(this.FotoPerfil_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.White;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Location = new System.Drawing.Point(323, 38);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(255, 186);
            this.btnFoto.TabIndex = 24;
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Desc.Location = new System.Drawing.Point(54, 325);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(101, 22);
            this.Desc.TabIndex = 22;
            this.Desc.Text = "Descrição:";
            // 
            // Evento
            // 
            this.Evento.AutoSize = true;
            this.Evento.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Evento.Location = new System.Drawing.Point(54, 258);
            this.Evento.Name = "Evento";
            this.Evento.Size = new System.Drawing.Size(74, 22);
            this.Evento.TabIndex = 20;
            this.Evento.Text = "Evento:";
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoExcluir.Location = new System.Drawing.Point(155, 52);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(85, 41);
            this.BotaoExcluir.TabIndex = 19;
            this.BotaoExcluir.Text = "EXCLUIR";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // BotaoAlterar
            // 
            this.BotaoAlterar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoAlterar.Location = new System.Drawing.Point(155, 111);
            this.BotaoAlterar.Name = "BotaoAlterar";
            this.BotaoAlterar.Size = new System.Drawing.Size(85, 41);
            this.BotaoAlterar.TabIndex = 17;
            this.BotaoAlterar.Text = "ALTERAR";
            this.BotaoAlterar.UseVisualStyleBackColor = true;
            // 
            // FormEdicaoEvento1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 594);
            this.Controls.Add(this.FlowPainelEvento);
            this.Name = "FormEdicaoEvento1";
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
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label Evento;
        private System.Windows.Forms.Button BotaoExcluir;
        private System.Windows.Forms.Button BotaoAlterar;
        private System.Windows.Forms.TextBox txtEventos;
        private System.Windows.Forms.TextBox txtDesc;
    }
}