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
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
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
            this.TxtNome.Location = new System.Drawing.Point(204, 227);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(196, 27);
            this.TxtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(113, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 346);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnAlterarFoto);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.FotoPerfil);
            this.panel1.Controls.Add(this.btnFoto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFuncao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(70, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 346);
            this.panel1.TabIndex = 0;
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFoto.Location = new System.Drawing.Point(482, 277);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(75, 31);
            this.btnAlterarFoto.TabIndex = 7;
            this.btnAlterarFoto.Text = "ALTERAR ";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(482, 223);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 31);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BackColor = System.Drawing.Color.White;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(192, 31);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(208, 176);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FotoPerfil.TabIndex = 5;
            this.FotoPerfil.TabStop = false;
            this.FotoPerfil.Click += new System.EventHandler(this.FotoPerfil_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.White;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Location = new System.Drawing.Point(192, 31);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(207, 166);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(113, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Função: ";
            // 
            // txtFuncao
            // 
            this.txtFuncao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFuncao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.Location = new System.Drawing.Point(204, 286);
            this.txtFuncao.Multiline = true;
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(196, 27);
            this.txtFuncao.TabIndex = 2;
            // 
            // EdicaoMembroGremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
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
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Button btnExcluir;
    }
}