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
    public partial class frm_Frutas : Form
    {
        char[] letrasadivinadas; int intentos;
        char[] letraseleccionada;
        char[] alfabeto;
        string[] frutas;


        public frm_Frutas()
        {
            InitializeComponent();
        }

        public void iniciar2()
        {
            fl_teclado2.Enabled = true;
            pict_ahorcado.Image = null;
            pict_ahorcado.Show();
            intentos = 0;
            frutas = new string[] { "manzana", "pera", "zapote", "fresa", "naranja", "lechoza", "limon", "guanabana", "uva", "cereza" };
            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random random = new Random();
            int indicedeseleccion = random.Next(0, frutas.Length);
            letraseleccionada = frutas[indicedeseleccion].ToUpper().ToCharArray();
            letrasadivinadas = letraseleccionada;

            foreach (char letrasalalfabeto in alfabeto)
            {
                Button btnLetra = new Button();

                btnLetra.Text = letrasalalfabeto.ToString();
                btnLetra.Tag = "";
                btnLetra.Click += comparacion2;
                btnLetra.Name = letrasalalfabeto.ToString();

                fl_teclado2.Controls.Add(btnLetra);

            }
            fl_palabra2.Controls.Clear();

            for (int valorletra = 0; valorletra < letraseleccionada.Length; valorletra++)
            {
                Button Letras = new Button();
                Letras.Tag = letraseleccionada[valorletra].ToString();
                Letras.Text = "_";
                Letras.Name = "Adivinado" + valorletra.ToString();
                fl_palabra2.Controls.Add(Letras);



            }

        }

        void comparacion2(object sender, EventArgs e)
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
                    letrasadivinadas[revision] = '_';
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
                
                pict_ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("imagen" + intentos);

                if (intentos == 5)
                {
                    for (int valorletra = 0; valorletra < letraseleccionada.Length; valorletra++)
                    {
                        Button btnletra = this.Controls.Find("adivinado" + valorletra, true).FirstOrDefault() as Button;
                        btnletra.Text = btnletra.Tag.ToString();


                    }
                    fl_teclado2.Enabled = false;
                    MessageBox.Show("Perdiste");
                    menu newform = new menu();
                    newform.Show();
                    this.Hide();
                }

            }
        }

            private void Frutas_Load(object sender, EventArgs e)
            {
            iniciar2();
            }
        }
    }
