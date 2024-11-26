namespace SistemaTotem
{
    partial class FormEdicaoEvento7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdicaoEvento7));
            this.FlowPainelEvento = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelEvento = new System.Windows.Forms.Panel();
            this.txtEventos = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_Excluir = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.FlowPainelEvento.SuspendLayout();
            this.PainelEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPainelEvento
            // 
            this.FlowPainelEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.FlowPainelEvento.Controls.Add(this.PainelEvento);
            this.FlowPainelEvento.Location = new System.Drawing.Point(163, 43);
            this.FlowPainelEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlowPainelEvento.Name = "FlowPainelEvento";
            this.FlowPainelEvento.Size = new System.Drawing.Size(774, 506);
            this.FlowPainelEvento.TabIndex = 29;
            // 
            // PainelEvento
            // 
            this.PainelEvento.Controls.Add(this.txtEventos);
            this.PainelEvento.Controls.Add(this.txtDesc);
            this.PainelEvento.Controls.Add(this.button1);
            this.PainelEvento.Controls.Add(this.pictureBox1);
            this.PainelEvento.Controls.Add(this.button3);
            this.PainelEvento.Controls.Add(this.label5);
            this.PainelEvento.Controls.Add(this.label7);
            this.PainelEvento.Controls.Add(this.Button_Excluir);
            this.PainelEvento.Controls.Add(this.button6);
            this.PainelEvento.Location = new System.Drawing.Point(3, 3);
            this.PainelEvento.Name = "PainelEvento";
            this.PainelEvento.Size = new System.Drawing.Size(768, 499);
            this.PainelEvento.TabIndex = 0;
            // 
            // txtEventos
            // 
            this.txtEventos.Location = new System.Drawing.Point(203, 266);
            this.txtEventos.Multiline = true;
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(148, 34);
            this.txtEventos.TabIndex = 18;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(203, 333);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(435, 125);
            this.txtDesc.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(598, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "ESCOLHER FOTO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(323, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 186);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(54, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(54, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Evento:";
            // 
            // Button_Excluir
            // 
            this.Button_Excluir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Excluir.Location = new System.Drawing.Point(164, 55);
            this.Button_Excluir.Name = "Button_Excluir";
            this.Button_Excluir.Size = new System.Drawing.Size(85, 41);
            this.Button_Excluir.TabIndex = 8;
            this.Button_Excluir.Text = "EXCLUIR";
            this.Button_Excluir.UseVisualStyleBackColor = true;
            this.Button_Excluir.Click += new System.EventHandler(this.Button_Excluir_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(164, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "ALTERAR";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormEdicaoEvento7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.FlowPainelEvento);
            this.Name = "FormEdicaoEvento7";
            this.Text = "Edição - Evento";
            this.FlowPainelEvento.ResumeLayout(false);
            this.PainelEvento.ResumeLayout(false);
            this.PainelEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPainelEvento;
        private System.Windows.Forms.Panel PainelEvento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_Excluir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtEventos;
        private System.Windows.Forms.TextBox txtDesc;
    }
}