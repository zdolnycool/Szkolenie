using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ObliczKoszt()
        {
           
            int wiek = Convert.ToInt32(txtWiek.Text);
            int iloscNoclegow = Convert.ToInt32(txtNoclegi.Text);
            double wynik = 0;

            if (wiek < 18)
            {
                wynik = 100.00;
            }
            else if (wiek >= 18 && wiek < 65)
            {
                if(iloscNoclegow == 1)
                {
                    wynik = iloscNoclegow * 200.00;
                    
                }
                else if(iloscNoclegow >= 2 && iloscNoclegow < 5)
                {
                    wynik = iloscNoclegow * 180.00;
                }
                else if(iloscNoclegow >= 5)
                {
                    wynik = iloscNoclegow * 150.00;
                }            
            }
            else
            {
                if (iloscNoclegow == 1)
                {
                    wynik = (200.00 - (200* 0.1)) * iloscNoclegow;

                }
                else if (iloscNoclegow >= 2 && iloscNoclegow < 5)
                {
                    wynik = (180.00 - (180 * 0.1)) * iloscNoclegow;
                }
                else if (iloscNoclegow >= 5)
                {
                    wynik = (150.00 - (150 * 0.1)) * iloscNoclegow;
                }
            }

            txtWynik.Text = ($"{wynik} PLN ");

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            ObliczKoszt();
        }
    }
}
