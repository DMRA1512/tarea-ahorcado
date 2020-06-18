namespace tarea_juego
{
    partial class frm_Animales
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
            this.pict_ahorcado = new System.Windows.Forms.PictureBox();
            this.fl_palabra3 = new System.Windows.Forms.FlowLayoutPanel();
            this.fl_teclado3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ahorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // pict_ahorcado
            // 
            this.pict_ahorcado.Image = global::tarea_juego.Properties.Resources.imagen1;
            this.pict_ahorcado.Location = new System.Drawing.Point(12, 12);
            this.pict_ahorcado.Name = "pict_ahorcado";
            this.pict_ahorcado.Size = new System.Drawing.Size(562, 199);
            this.pict_ahorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_ahorcado.TabIndex = 18;
            this.pict_ahorcado.TabStop = false;
            // 
            // fl_palabra3
            // 
            this.fl_palabra3.Location = new System.Drawing.Point(506, 251);
            this.fl_palabra3.Name = "fl_palabra3";
            this.fl_palabra3.Size = new System.Drawing.Size(413, 75);
            this.fl_palabra3.TabIndex = 20;
            // 
            // fl_teclado3
            // 
            this.fl_teclado3.Location = new System.Drawing.Point(12, 238);
            this.fl_teclado3.Name = "fl_teclado3";
            this.fl_teclado3.Size = new System.Drawing.Size(488, 160);
            this.fl_teclado3.TabIndex = 21;
            // 
            // frm_Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 446);
            this.Controls.Add(this.fl_teclado3);
            this.Controls.Add(this.fl_palabra3);
            this.Controls.Add(this.pict_ahorcado);
            this.Name = "frm_Animales";
            this.Text = "Animales";
            this.Load += new System.EventHandler(this.Animales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_ahorcado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pict_ahorcado;
        private System.Windows.Forms.FlowLayoutPanel fl_palabra3;
        private System.Windows.Forms.FlowLayoutPanel fl_teclado3;
    }
}