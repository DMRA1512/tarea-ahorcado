using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_juego
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            

        }

        private void frm_carros_Click(object sender, EventArgs e)
        {
            frm_ahorcado newform = new frm_ahorcado();
            newform.Show();
            this.Hide();
        }

        private void frm_frutas_Click(object sender, EventArgs e)
        {
            frm_Frutas newform = new frm_Frutas();
            newform.Show();
            this.Hide();
        }

        private void frm_animales_Click(object sender, EventArgs e)
        {
            frm_Animales newform = new frm_Animales();
            newform.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios");
            this.Close();
        }
    }
}
