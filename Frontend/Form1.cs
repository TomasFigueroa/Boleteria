using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();


            if (textpopulars.Text!= "" || textpopularn.Text!="" || textplatea.Text!=""){
                try //manejo de errores
                {
                    if (textplatea.Text != "")
                    {
                        ticket.CtdPlatea = Convert.ToInt32(textplatea.Text);
                    }
                    if (textpopularn.Text != "")
                    {
                        ticket.CtdPopularNorte = Convert.ToInt32(textpopularn.Text);
                    }
                    if(textpopulars.Text != "")
                    {
                        ticket.CtdPopularSur = Convert.ToInt32(textpopulars.Text);
                    }
                    MessageBox.Show("Usted compro esta cantidad de entradas:"+ "\n" + "   Cant de Plateas: " + ticket.CtdPlatea 
                        +"\n" + "   Cant de Popular Sur: " + ticket.CtdPopularSur 
                        + "\n" + "   Cant de Popular Norte: " + ticket.CtdPopularNorte 
                        + "\n" + "\n " +  "Total a Pagar: $" + ticket.Calcular().ToString());

                    comprobar(textpopulars, errorpopulars);
                    comprobar(textpopularn, errorpopularn);
                    comprobar(textplatea, errorplatea);

                    textplatea.Clear();
                    textpopularn.Clear();
                    textpopulars.Clear();

                } catch (Exception )
                {
                    comprobar(textpopulars,errorpopulars);
                    comprobar(textpopularn, errorpopularn);
                    comprobar(textplatea, errorplatea);
                }


            }

            void comprobar(TextBox tex, ErrorProvider error)// compruebo si hay un dato no numerico
            {
                bool com = false;
                foreach (char caracter in tex.Text)
                {
                    if (!(char.IsDigit(caracter)))
                    {
                        com = true;
                    }
                }
                if (com)
                {
                    error.SetError(tex, "No se aceptan datos no numericos");


                }
                else
                {
                    error.Clear();
                }
        
            }
        }
    }
}
