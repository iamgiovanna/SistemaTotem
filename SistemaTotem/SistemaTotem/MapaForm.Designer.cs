namespace SistemaTotem
{
    partial class MapaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaForm));
            this.PictureMapaEtecZL = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelMapaEtecZL = new System.Windows.Forms.Panel();
            this.TituloMapaEtecZL = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMapaEtecZL)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.PainelMapaEtecZL.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureMapaEtecZL
            // 
            this.PictureMapaEtecZL.Image = ((System.Drawing.Image)(resources.GetObject("PictureMapaEtecZL.Image")));
            this.PictureMapaEtecZL.Location = new System.Drawing.Point(225, 182);
            this.PictureMapaEtecZL.Name = "PictureMapaEtecZL";
            this.PictureMapaEtecZL.Size = new System.Drawing.Size(1140, 467);
            this.PictureMapaEtecZL.TabIndex = 3;
            this.PictureMapaEtecZL.TabStop = false;
            this.PictureMapaEtecZL.Click += new System.EventHandler(this.PictureMapaEtecZL_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1461, 57);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.PainelMapaEtecZL);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(574, 89);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(448, 70);
            this.flowLayoutPanel3.TabIndex = 14;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // PainelMapaEtecZL
            // 
            this.PainelMapaEtecZL.Controls.Add(this.TituloMapaEtecZL);
            this.PainelMapaEtecZL.Location = new System.Drawing.Point(4, 4);
            this.PainelMapaEtecZL.Margin = new System.Windows.Forms.Padding(4);
            this.PainelMapaEtecZL.Name = "PainelMapaEtecZL";
            this.PainelMapaEtecZL.Size = new System.Drawing.Size(471, 65);
            this.PainelMapaEtecZL.TabIndex = 0;
            this.PainelMapaEtecZL.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelMapaEtecZL_Paint);
            // 
            // TituloMapaEtecZL
            // 
            this.TituloMapaEtecZL.AutoSize = true;
            this.TituloMapaEtecZL.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloMapaEtecZL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TituloMapaEtecZL.Location = new System.Drawing.Point(104, 12);
            this.TituloMapaEtecZL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloMapaEtecZL.Name = "TituloMapaEtecZL";
            this.TituloMapaEtecZL.Size = new System.Drawing.Size(252, 37);
            this.TituloMapaEtecZL.TabIndex = 0;
            this.TituloMapaEtecZL.Text = "Mapa da Etec ZL";
            this.TituloMapaEtecZL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TituloMapaEtecZL.Click += new System.EventHandler(this.TituloMapaEtecZL_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.Location = new System.Drawing.Point(90, 648);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(59, 48);
            this.BtnVoltar.TabIndex = 15;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(64, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MapaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1461, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PictureMapaEtecZL);
            this.Name = "MapaForm";
            this.Text = "MapaForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureMapaEtecZL)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PainelMapaEtecZL.ResumeLayout(false);
            this.PainelMapaEtecZL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureMapaEtecZL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel PainelMapaEtecZL;
        private System.Windows.Forms.Label TituloMapaEtecZL;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button button1;
    }
}