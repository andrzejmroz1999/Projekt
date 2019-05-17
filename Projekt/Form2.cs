using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form2 : Form
    {
        public Firma fir {get; set; }

        public Form2()
        {
            InitializeComponent();
          
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(0, true);
        }
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(1, true);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(2, true);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(3, true);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(4, true);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(5, true);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(6, true);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(7, true);
        }             
      
        private void textBox9_KeyPress_1(object sender, KeyPressEventArgs e)
        {                        
                  checkedListBox1.SetItemChecked(8, true);            
        }

        private void textBox10_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(9, true);
        }
       
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(12, true);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(13, true);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(14, true);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(15, true);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(16, true);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(17, true);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(18, true);
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(19, true);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(20, true);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(21, true);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(22, true);
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(23, true);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(10, true);
        }
       
        private void textBox12_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(11, true);
        }

        private void textBox22_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checkedListBox1.SetItemChecked(21, true);
        }

        private void Usun_tekst_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";            
        }

        private static List<Firma> WczytywaniePliku(string sciezka)
        {
            return File.ReadAllLines(sciezka, Encoding.UTF8)
                  .Skip(1)
                  .Where(linia => linia.Length > 1)
                  .Select(Firma.ParsujCSV).ToList();
        }

        private void dodaj_firme_Click(object sender, EventArgs e)
        {
            UzupełnijDane();

            fir = new Firma
            {
                LP = int.Parse(textBox1.Text),
                Nazwa_firmy = textBox2.Text,
                REGON = int.Parse(textBox3.Text),
                Nazwisko = textBox4.Text,
                Imie = textBox5.Text,
                Miasto = textBox6.Text,
                Ulica_nr = textBox7.Text,
                Powiat = textBox8.Text,
                Telefon = textBox9.Text,
                Polisa1 = textBox10.Text,
                Data1 = DateTime.ParseExact(textBox11.Text, "d/m/yyyy", CultureInfo.InvariantCulture),
                Polisa2 = textBox12.Text,
                Data2 = DateTime.ParseExact(textBox13.Text, "d/m/yyyy", CultureInfo.InvariantCulture),
                Rating = textBox14.Text,
                Przychody = int.Parse(textBox15.Text),
                EBIDTA = int.Parse(textBox16.Text),
                NDE_EBIDTA = double.Parse(textBox17.Text),
                DSCR = double.Parse(textBox18.Text),
                Produkt1 = textBox19.Text,
                Marża1 = int.Parse(textBox20.Text),
                Prowizja1 = int.Parse(textBox21.Text),
                Produkt2 = textBox22.Text,
                Marża2 = int.Parse(textBox23.Text),
                Prowizja2 = int.Parse(textBox24.Text)
            };
            label1.Text = "Pomyślnie dodano firmę";

            DialogResult = System.Windows.Forms.DialogResult.OK;           
        }

        private void UzupełnijDane()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }
            if (textBox11.Text == "")
            {
                textBox11.Text = "01/01/0001";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            if (textBox13.Text == "")
            {
                textBox13.Text = "01/01/0001";
            }
            if (textBox14.Text == "")
            {
                textBox14.Text = "0";
            }
            if (textBox15.Text == "")
            {
                textBox15.Text = "0";
            }
            if (textBox16.Text == "")
            {
                textBox16.Text = "0";
            }
            if (textBox17.Text == "")
            {
                textBox17.Text = "0";
            }
            if (textBox18.Text == "")
            {
                textBox18.Text = "0";
            }
            if (textBox19.Text == "")
            {
                textBox19.Text = "0";
            }
            if (textBox20.Text == "")
            {
                textBox20.Text = "0";
            }
            if (textBox21.Text == "")
            {
                textBox21.Text = "0";
            }
            if (textBox22.Text == "")
            {
                textBox22.Text = "0";
            }
            if (textBox23.Text == "")
            {
                textBox23.Text = "0";
            }
            if (textBox24.Text == "")
            {
                textBox24.Text = "0";
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {          
           // DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
