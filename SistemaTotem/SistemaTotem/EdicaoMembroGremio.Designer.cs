﻿namespace SistemaTotem
{
    partial class EdicaoMembroGremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicaoMembroGremio));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(272, 286);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(260, 27);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(151, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 111);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(816, 426);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.panel1.Location = new System.Drawing.Point(93, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(642, 286);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 38);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFoto.Location = new System.Drawing.Point(642, 341);
            this.btnAlterarFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(100, 38);
            this.btnAlterarFoto.TabIndex = 7;
            this.btnAlterarFoto.Text = "ALTERAR ";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            this.btnAlterarFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(642, 228);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 38);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "EXCLUIR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BackColor = System.Drawing.Color.White;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(343, 88);
            this.FotoPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(101, 100);
            this.FotoPerfil.TabIndex = 5;
            this.FotoPerfil.TabStop = false;
            this.FotoPerfil.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.White;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Location = new System.Drawing.Point(256, 38);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(276, 204);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(151, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Função: ";
            // 
            // txtFuncao
            // 
            this.txtFuncao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFuncao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.Location = new System.Drawing.Point(272, 352);
            this.txtFuncao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(260, 27);
            this.txtFuncao.TabIndex = 2;
            this.txtFuncao.TextChanged += new System.EventHandler(this.txtFuncao_TextChanged);
            // 
            // EdicaoMembroGremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EdicaoMembroGremio";
            this.Text = "Edição - Membros do Grêmio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Button btnAlterar;
    }
}