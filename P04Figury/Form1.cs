using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04Figury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObliczPola_Click(object sender, EventArgs e)
        {
            List<Object> pola = new List<Object>();

            Kolo kolo = new Kolo(Convert.ToDouble(txtPromienKola.Text));
            pola.Add(kolo.ObliczPole());

            TrojkatProstokatny trojkatProstokatny = new TrojkatProstokatny(Convert.ToDouble(txtTrojkatA.Text), Convert.ToDouble(txtTrojkatB.Text));
            pola.Add(trojkatProstokatny.ObliczPole());

            Kwadrat kwadrat = new Kwadrat(Convert.ToDouble(txtProstokatA.Text), Convert.ToDouble(txtProstokatB.Text));
            pola.Add(kwadrat.ObliczPole());


            for (int i = 0; i < pola.Count; i++)
            {
                txtWynik.Text += pola[i] + System.Environment.NewLine;
            }
        }
    }
}
