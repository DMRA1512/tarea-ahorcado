namespace tarea_juego
{
    partial class menu
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
            this.frm_carros = new System.Windows.Forms.Button();
            this.frm_frutas = new System.Windows.Forms.Button();
            this.frm_animales = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frm_carros
            // 
            this.frm_carros.Location = new System.Drawing.Point(140, 66);
            this.frm_carros.Name = "frm_carros";
            this.frm_carros.Size = new System.Drawing.Size(120, 47);
            this.frm_carros.TabIndex = 1;
            this.frm_carros.Text = "Marcas de Carros";
            this.frm_carros.UseVisualStyleBackColor = true;
            this.frm_carros.Click += new System.EventHandler(this.frm_carros_Click);
            // 
            // frm_frutas
            // 
            this.frm_frutas.Location = new System.Drawing.Point(140, 157);
            this.frm_frutas.Name = "frm_frutas";
            this.frm_frutas.Size = new System.Drawing.Size(120, 49);
            this.frm_frutas.TabIndex = 2;
            this.frm_frutas.Text = "Frutas";
            this.frm_frutas.UseVisualStyleBackColor = true;
            this.frm_frutas.Click += new System.EventHandler(this.frm_frutas_Click);
            // 
            // frm_animales
            // 
            this.frm_animales.Location = new System.Drawing.Point(140, 248);
            this.frm_animales.Name = "frm_animales";
            this.frm_animales.Size = new System.Drawing.Size(120, 54);
            this.frm_animales.TabIndex = 3;
            this.frm_animales.Text = "Animales";
            this.frm_animales.UseVisualStyleBackColor = true;
            this.frm_animales.Click += new System.EventHandler(this.frm_animales_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(140, 340);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(120, 47);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 446);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.frm_animales);
            this.Controls.Add(this.frm_frutas);
            this.Controls.Add(this.frm_carros);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frm_carros;
        private System.Windows.Forms.Button frm_frutas;
        private System.Windows.Forms.Button frm_animales;
        private System.Windows.Forms.Button btn_Salir;
    }
}