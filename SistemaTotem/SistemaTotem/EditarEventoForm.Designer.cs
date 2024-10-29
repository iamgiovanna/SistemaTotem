namespace SistemaTotem
{
    partial class EditarEventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEventoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnAlterarFoto);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.FotoPerfil);
            this.panel1.Controls.Add(this.btnFoto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFuncao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(79, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 346);
            this.panel1.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(504, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 31);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFoto.Location = new System.Drawing.Point(504, 293);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(75, 31);
            this.btnAlterarFoto.TabIndex = 7;
            this.btnAlterarFoto.Text = "ALTERAR ";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(504, 214);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 35);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "EXCLUIR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BackColor = System.Drawing.Color.White;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(249, 56);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(106, 104);
            this.FotoPerfil.TabIndex = 5;
            this.FotoPerfil.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.White;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Location = new System.Drawing.Point(104, 28);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(419, 166);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(128, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // txtFuncao
            // 
            this.txtFuncao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFuncao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.Location = new System.Drawing.Point(236, 284);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(196, 23);
            this.txtFuncao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(128, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evento:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(236, 238);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(196, 23);
            this.TxtNome.TabIndex = 0;
            // 
            // EditarEventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarEventoForm";
            this.Text = "Editar - Eventos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
    }
}