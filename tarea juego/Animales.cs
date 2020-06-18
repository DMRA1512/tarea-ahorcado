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
    public partial class frm_Animales : Form
    {
        char[] letrasadivinadas; int intentos;
        char[] letraseleccionada;
        char[] alfabeto;
        string[] animales;


        public frm_Animales()
        {
            InitializeComponent();
        }

        public void inicio3()
        {
            fl_teclado3.Enabled = true;
            pict_ahorcado.Image = null;
            pict_ahorcado.Show();
            intentos = 0;
            animales = new string[] { "tortuga", "jaguar", "manati", "cocodrilo", "hipopotamo", "perro", "raton", "gato", "serpiente", "panda" };
            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random random = new Random();
            int indicedeseleccion = random.Next(0, animales.Length);
            letraseleccionada = animales[indicedeseleccion].ToUpper().ToCharArray();
            letrasadivinadas = letraseleccionada;

            foreach (char letrasalalfabeto in alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = letrasalalfabeto.ToString();
                btnLetra.Click += comparacion3;
                btnLetra.Name = letrasalalfabeto.ToString();
                fl_teclado3.Controls.Add(btnLetra);


            }
            fl_palabra3.Controls.Clear();
            for (int valorletra = 0; valorletra < letraseleccionada.Length; valorletra++)
            {
                Button Letras = new Button();
                Letras.Tag = letraseleccionada[valorletra].ToString();
                Letras.Text = "_";
                Letras.Name = "Adivinado" + valorletra.ToString();
                fl_palabra3.Controls.Add(Letras);
            }
            void comparacion3(object sender, EventArgs e)
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
                    pict_ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("imagen" + intentos);

                    if (intentos == 5)
                    {
                        for (int valorletra = 0; valorletra < letraseleccionada.Length; valorletra++)
                        {
                            Button btnletra = this.Controls.Find("adivinado" + valorletra, true).FirstOrDefault() as Button;
                            btnletra.Text = btnletra.Tag.ToString();


                        }
                        fl_teclado3.Enabled = false;
                        MessageBox.Show("perdiste");
                        menu newform = new menu();
                        newform.Show();
                        this.Hide();
                    }


                }
            }




        }



        private void Animales_Load(object sender, EventArgs e)
        {
            inicio3();
        }
    }
}
