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
    public partial class frm_ahorcado : Form
    {

        char[] letrasadivinadas; int intentos;
        char[] letraseleccionada;
        char[] alfabeto;
        string[] carros;

        public frm_ahorcado()
        {
            InitializeComponent();
        }
        public void iniciar()
        {
            fl_teclado1.Enabled = true;
            pict_ahorcado.Image = null;
            pict_ahorcado.Show();
            intentos = 0;
            carros = new string[] { "Wmotors", "Nissan", "izuzu", "mazda", "Koda", "Gumpert", "maserati", "Koenigsegg", "Toyota", "Lamborgini" };
            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random random = new Random();
            int indicedeseleccion = random.Next(0, carros.Length);
            letraseleccionada = carros[indicedeseleccion].ToUpper().ToCharArray();
            letrasadivinadas = letraseleccionada;

            foreach (char letrasalalfabeto in alfabeto)
            {
                Button btnLetra = new Button();

                btnLetra.Text = letrasalalfabeto.ToString();
                btnLetra.Tag = "";
                btnLetra.Click += comparacion;
                btnLetra.Name = letrasalalfabeto.ToString();
              
                fl_teclado1.Controls.Add(btnLetra);

            }
            fl_palabra.Controls.Clear();

            for (int valorletra = 0; valorletra < letraseleccionada.Length; valorletra++)
            {
                Button Letras = new Button();
                Letras.Tag = letraseleccionada[valorletra].ToString();
                Letras.Text = "_";
                Letras.Name = "Adivinado" + valorletra.ToString();
                fl_palabra.Controls.Add(Letras);



            }



        }
        void comparacion(object sender, EventArgs e)
        {
            bool pegada = false;
            Button btn = (Button)sender;
            btn.Enabled = false;

            for (int revision = 0; revision < letrasadivinadas.Length; revision++)
            {
                if (letrasadivinadas[revision] == char.Parse(btn.Text))
                {
                    Button encontrado = this.Controls.Find("Adivinado" + revision, true).FirstOrDefault() as Button;
                    encontrado.Text = letrasadivinadas[revision].ToString();
                    letrasadivinadas[revision] = '-';
                    pegada = true;



                }



            }
            bool ganaste = true;
            for (int analizar = 0; analizar < letrasadivinadas.Length; analizar++)
            {
                if (letrasadivinadas[analizar] != '-')
                {
                    ganaste = false;


                }

            }
            if (ganaste)
            {
                MessageBox.Show("Ganaste");

            }

            if (!pegada)
            {
                intentos = intentos + 1;
                pict_ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("imagen"+ intentos);
                
                
                
                if (intentos == 5)
                {
                    for (int valorletra = 0; valorletra < letraseleccionada.Length; valorletra++)
                    {
                        Button btnletra = this.Controls.Find("adivinado" + valorletra, true).FirstOrDefault() as Button;
                        btnletra.Text = btnletra.Tag.ToString();
                        

                    }
                    fl_teclado1.Enabled = false;
                    MessageBox.Show("Perdiste");
                    menu newform = new menu();
                    newform.Show();
                    this.Hide();

                }

            }

        }

            private void frm_ahorcado_Load(object sender, EventArgs e)
            {

            iniciar();

            }
    }
}
