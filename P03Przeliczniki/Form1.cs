using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03Przeliczniki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double PrzeliczStopyNaMiary(double stopy)
        {
            double wynik = 0;
            wynik = Math.Round((stopy / 3.2808), 2);
            txtStopyWynik.Text = wynik.ToString();
            return wynik;
        }

        double SprawdzNajwiekszaLiczbe(double liczba1, double liczba2)
        {
            //if (liczba1 > liczba2)
            //{
            //    txtNajwiekszaLiczbaWynik.Text = liczba1.ToString();
            //    return liczba1;
            //}
            //else
            //{
            //    txtNajwiekszaLiczbaWynik.Text = liczba2.ToString();
            //    return liczba2;
            //}
            double wynik = 0;
            wynik = Math.Max(liczba1, liczba2);
            txtNajwiekszaLiczbaWynik.Text = wynik.ToString();
            return wynik;
                      
            
        }

        double ObliczSrednia(double liczba1, double liczba2)
        {
            double wynik = 0;
            wynik = (liczba1 + liczba2) / 2;
            return wynik;
            
        }

        double ObliczPoleKola(double promien)
        {
            double wynik = 0;
            wynik = Math.Round(Math.PI * Math.Pow(promien, 2), 2);
            return wynik;
        }


        private void btnStopyMetry_Click(object sender, EventArgs e)
        {
            PrzeliczStopyNaMiary(Math.Round(Convert.ToDouble(txtStopy.Text), 2));
        }

        private void btnSprawdzNajwiekszaLiczbe_Click(object sender, EventArgs e)
        {
            SprawdzNajwiekszaLiczbe(Convert.ToDouble(txt1Liczba.Text), Convert.ToDouble(txt2Liczba.Text));
        }

        private void btnObliczSrednia_Click(object sender, EventArgs e)
        {
            
            txtWynikSrednia.Text = (ObliczSrednia(Convert.ToDouble(txt1Liczba.Text), Convert.ToDouble(txt2Liczba.Text))).ToString();
        }

        private void btnObliczPoleKola_Click(object sender, EventArgs e)
        {
            txtWynikPoleKola.Text = (ObliczPoleKola(Convert.ToDouble(txtPromienKola.Text))).ToString();
        }
    }
}
