using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string PierwszaLiczba, DrugaLiczba;
        string Znak = "";

        private void Bdzielenie_Click(object sender, EventArgs e)
        {
            Znak = "/";
            TBwynik.Text = "";
        }

        private void Bmnozenie_Click(object sender, EventArgs e)
        {
            Znak = "*";
            TBwynik.Text = "";
        }

        private void Bodejmowanie_Click(object sender, EventArgs e)
        {
            Znak = "-";
            TBwynik.Text = "";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void Bwynik_Click(object sender, EventArgs e)
        {
            switch (Znak)
            {
                case ("+"):
                    TBwynik.Text = (float.Parse(PierwszaLiczba) + float.Parse(DrugaLiczba)).ToString();
                    TBobliczenia.Text = (PierwszaLiczba + " " + Znak + " " + DrugaLiczba + " = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("-"):
                    TBwynik.Text = (float.Parse(PierwszaLiczba) - float.Parse(DrugaLiczba)).ToString();
                    TBobliczenia.Text = (PierwszaLiczba + " " + Znak + " " + DrugaLiczba + " = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("*"):
                    TBwynik.Text = (float.Parse(PierwszaLiczba) * float.Parse(DrugaLiczba)).ToString();
                    TBobliczenia.Text = (PierwszaLiczba + " " + Znak + " " + DrugaLiczba + " = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("/"):
                    if (float.Parse(PierwszaLiczba) == 0 || float.Parse(DrugaLiczba) == 0)
                    {
                        TBobliczenia.Text = "ERROR";
                    }
                    else
                    {
                        TBwynik.Text = (float.Parse(PierwszaLiczba) / float.Parse(DrugaLiczba)).ToString();
                        TBobliczenia.Text = (PierwszaLiczba + " " + Znak + " " + DrugaLiczba + " = " + TBwynik.Text).ToString();
                        TBwynik.Text = "";
                    }
                    break;
                case ("√"):
                    TBwynik.Text = (Math.Sqrt(double.Parse(PierwszaLiczba))).ToString();
                    TBobliczenia.Text = (Znak + " "+ PierwszaLiczba + " = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("x^y"):
                    TBwynik.Text = Math.Pow(double.Parse(PierwszaLiczba),double.Parse(DrugaLiczba)).ToString();
                    TBobliczenia.Text = (PierwszaLiczba + "^" + DrugaLiczba + " = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("!"):
                    TBwynik.Text = silnia(int.Parse(PierwszaLiczba)).ToString();
                    TBobliczenia.Text = (Znak + PierwszaLiczba + " = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("log"):
                    if (float.Parse(PierwszaLiczba) > 0)
                    {
                        TBwynik.Text = Math.Log(float.Parse(PierwszaLiczba)).ToString();
                        TBobliczenia.Text = (Znak + "(" + PierwszaLiczba + ") = " + TBwynik.Text).ToString();
                        TBwynik.Text = "";
                    }
                    else
                    {
                        TBobliczenia.Text = "ERROR";
                    }
                    break;
                case ("Sin"):
                    TBwynik.Text = Math.Sin(float.Parse(PierwszaLiczba)).ToString();
                    TBobliczenia.Text = (Znak +"("+ PierwszaLiczba + ") = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("Cos"):
                    TBwynik.Text = Math.Cos(float.Parse(PierwszaLiczba)).ToString();
                    TBobliczenia.Text = (Znak +"("+ PierwszaLiczba + ") = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
                case ("Mod"):
                    TBwynik.Text = (float.Parse(PierwszaLiczba) % float.Parse(DrugaLiczba)).ToString();
                    TBobliczenia.Text = (PierwszaLiczba + " " + Znak + "(" + DrugaLiczba + ") = " + TBwynik.Text).ToString();
                    TBwynik.Text = "";
                    break;
            }

            PierwszaLiczba = "";
            DrugaLiczba = "";
            Znak = "";
        }

        private void Bdodawanie_Click(object sender, EventArgs e)
        {
            Znak = "+";
            TBwynik.Text = "";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void TBwynik_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void Bclean_Click(object sender, EventArgs e)
        {
            TBwynik.Text = "";
            TBobliczenia.Text = "";
            PierwszaLiczba = "";
            DrugaLiczba = "";
            Znak = "";

        }

        private void Bcleanline_Click(object sender, EventArgs e)
        {
            /*if (PierwszaLiczba != "" && DrugaLiczba == "")
            {
                PierwszaLiczba = null;
                PierwszaLiczba = null;
                TBwynik.Text = "";
            }
            else if (PierwszaLiczba !="" && DrugaLiczba != "")
            {
                DrugaLiczba = null;
                TBwynik.Text = "";
            }*/
            // jak to do kurwy nędzy zrobić!?
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bpotega_Click(object sender, EventArgs e)
        {
            Znak = "x^y";
            TBwynik.Text = "";
        }

        private void Bpierwiastek_Click(object sender, EventArgs e)
        {
            Znak = "√";
            TBwynik.Text = "";
        }

        private void Bsilnia_Click(object sender, EventArgs e)
        {
            Znak = "!";
            TBwynik.Text = "";
        }

        private void Blog_Click(object sender, EventArgs e)
        {
            Znak = "log";
            TBwynik.Text = "";
        }

        private void Bcos_Click(object sender, EventArgs e)
        {
            Znak = "Cos";
            TBwynik.Text = "";
        }

        private void Bsin_Click(object sender, EventArgs e)
        {
            Znak = "Sin";
            TBwynik.Text = "";
        }

        private static int silnia(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia(i - 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Created by Piotr Modliński");
        }

        private void TBobliczenia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Wiersz poleceń: ");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Obliczenia: ");
        }

        private void Bpm_Click(object sender, EventArgs e)
        {
            Znak = "±";
           /* if (DrugaLiczba == "")
           {
                TBwynik.Text = (float.Parse(PierwszaLiczba) * (-1)).ToString();
            }
            else if (DrugaLiczba != " ")
            {
                TBwynik.Text = (float.Parse(DrugaLiczba) * (-1)).ToString();
            }*/
            // nie działa !!
        }

        private void Bmod_Click(object sender, EventArgs e)
        {
            Znak = "Mod";
            TBwynik.Text = "";
        }

        private void Dzialanie (float liczba)
        {
            if (Znak == "")
            {
                PierwszaLiczba += liczba;
                TBwynik.Text = PierwszaLiczba;
            }
            else
            {
                DrugaLiczba += liczba;
                TBwynik.Text = DrugaLiczba;
            }
        }
    }
}
