namespace tarea_juego
{
    partial class frm_Frutas
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
            this.fl_teclado2 = new System.Windows.Forms.FlowLayoutPanel();
            this.fl_palabra2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ahorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // pict_ahorcado
            // 
            this.pict_ahorcado.Image = global::tarea_juego.Properties.Resources.imagen1;
            this.pict_ahorcado.Location = new System.Drawing.Point(26, 21);
            this.pict_ahorcado.Name = "pict_ahorcado";
            this.pict_ahorcado.Size = new System.Drawing.Size(562, 199);
            this.pict_ahorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_ahorcado.TabIndex = 17;
            this.pict_ahorcado.TabStop = false;
            // 
            // fl_teclado2
            // 
            this.fl_teclado2.Location = new System.Drawing.Point(26, 264);
            this.fl_teclado2.Name = "fl_teclado2";
            this.fl_teclado2.Size = new System.Drawing.Size(488, 160);
            this.fl_teclado2.TabIndex = 18;
            // 
            // fl_palabra2
            // 
            this.fl_palabra2.Location = new System.Drawing.Point(520, 267);
            this.fl_palabra2.Name = "fl_palabra2";
            this.fl_palabra2.Size = new System.Drawing.Size(413, 75);
            this.fl_palabra2.TabIndex = 19;
            // 
            // frm_Frutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.fl_teclado2);
            this.Controls.Add(this.fl_palabra2);
            this.Controls.Add(this.pict_ahorcado);
            this.Name = "frm_Frutas";
            this.Text = "Frutas";
            this.Load += new System.EventHandler(this.Frutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_ahorcado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pict_ahorcado;
        private System.Windows.Forms.FlowLayoutPanel fl_teclado2;
        private System.Windows.Forms.FlowLayoutPanel fl_palabra2;
    }
}