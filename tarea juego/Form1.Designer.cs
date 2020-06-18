namespace tarea_juego
{
    partial class frm_ahorcado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fl_teclado1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pict_ahorcado = new System.Windows.Forms.PictureBox();
            this.fl_palabra = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ahorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // fl_teclado1
            // 
            this.fl_teclado1.Location = new System.Drawing.Point(24, 217);
            this.fl_teclado1.Name = "fl_teclado1";
            this.fl_teclado1.Size = new System.Drawing.Size(488, 160);
            this.fl_teclado1.TabIndex = 14;
            // 
            // pict_ahorcado
            // 
            this.pict_ahorcado.Location = new System.Drawing.Point(63, 12);
            this.pict_ahorcado.Name = "pict_ahorcado";
            this.pict_ahorcado.Size = new System.Drawing.Size(562, 199);
            this.pict_ahorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_ahorcado.TabIndex = 16;
            this.pict_ahorcado.TabStop = false;
            // 
            // fl_palabra
            // 
            this.fl_palabra.Location = new System.Drawing.Point(558, 220);
            this.fl_palabra.Name = "fl_palabra";
            this.fl_palabra.Size = new System.Drawing.Size(413, 75);
            this.fl_palabra.TabIndex = 13;
            // 
            // frm_ahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 421);
            this.Controls.Add(this.pict_ahorcado);
            this.Controls.Add(this.fl_teclado1);
            this.Controls.Add(this.fl_palabra);
            this.Name = "frm_ahorcado";
            this.Text = "ahorcado carros";
            this.Load += new System.EventHandler(this.frm_ahorcado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_ahorcado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fl_teclado1;
        private System.Windows.Forms.PictureBox pict_ahorcado;
        private System.Windows.Forms.FlowLayoutPanel fl_palabra;
    }
}

