using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaOkienkowaJeden
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private decimal enteredValue = 0.0m; // Zmienna do przechowywania wartości liczbowej
        public Form1()
        {
            InitializeComponent();

            // Inicjalizacja timera
            timer = new Timer();
            timer.Interval = 200; // Interwał w milisekundach (tu ustawiony na 1000 ms, czyli 1 sekunda)
            timer.Tick += Timer_Tick;

            // Uruchomienie timera
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pl-PL"), out enteredValue))
            {
                // Wprowadzone dane są poprawne - enteredValue zawiera wartość liczbową
                // Możesz tutaj wykonywać operacje na enteredValue
                label12.Text = "Wprowadzone dane są poprawne.";
                label12.ForeColor = Color.Green;
            }
            else
            {
                // Wprowadzone dane nie są poprawne

                label12.Text = "Wprowadzone dane nie są poprawne. Wprowadź liczbę w formacie PLN.";
                label12.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Aktualizuj etykietę z bieżącą datą
            label14.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
