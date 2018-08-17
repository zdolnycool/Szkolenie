using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01ZadanieBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                       
        }

        void ObliczBMI()
        {
            double wzrost = Convert.ToDouble(txtWzrost.Text)/100;
            double waga = Convert.ToDouble(txtWaga.Text);
            double wynik = Math.Round(waga / Math.Pow(wzrost, 2), 1);
            if (wynik < 18.5)
            {
                txtWynik.Text = ($"{wynik} - niedowaga");
                txtZalecenia.Text = "Przytyj";
            }
            else if(wynik >= 18.5 && wynik <= 24.9 )
            {
                txtWynik.Text = ($"{wynik.ToString()} - waga prawidłowa");
                txtZalecenia.Text = "Super! Tak trzymaj";
            }
            else if (wynik >= 25 && wynik <= 29.9)
            {
                txtWynik.Text = ($"{wynik} - nadwaga");
                txtZalecenia.Text = "Czas się za siebie wziąć";

            }
            else
            {
                txtWynik.Text = ($"{wynik} - otyłość");
                txtZalecenia.Text = "Przestań jeść i zacznij ćwiczyć";
            }


        }


        private void btnOblicz_Click(object sender, EventArgs e)
        {
            ObliczBMI();
        }
    }
}
