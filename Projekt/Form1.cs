using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Projekt
{
    public partial class Form1 : Form 
    {
        List<Firma> firmy = WczytywaniePliku("ProjektB.csv");

        public Form1()
        {
            InitializeComponent();
           
        }                  
      
        private static List<Firma> WczytywaniePliku(string sciezka)
        {
            return File.ReadAllLines(sciezka, Encoding.UTF8)
                  .Skip(1)
                  .Where(linia => linia.Length > 1)
                  .Select(Firma.ParsujCSV).ToList();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");

            tabela.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
       //   tabela.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabela.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            tabela.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tabela.BackgroundColor = Color.White;

            tabela.EnableHeadersVisualStyles = false;
            tabela.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabela.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           
        }

        private void Wyswietl_dane_Click(object sender, EventArgs e)
        {
            tabela.DataSource = firmy.Where(x => x.Nazwa_firmy.ToLower().StartsWith("")).ToList();
            tabela.DataSource = firmy;
            Zapisz.Visible = true;
            Usunieto_element.Visible = false;
            panel3.Visible = false;           
            Wyszukaj.Text = "";
        }
      
        private void po_nazwie_firmy_Click(object sender, EventArgs e)
        {            
            panel3.Height = po_nazwie_firmy.Height;
            panel3.Location = po_nazwie_firmy.Location;
            panel3.Visible = true;
            tabela.DataSource = firmy.Where(x => x.Nazwa_firmy.ToLower().StartsWith((Wyszukaj.Text.ToLower()))).ToList();
            Zapisz.Visible = false;
            Wyszukaj.Text = "";
        }
     
        private void po_REGON_Click(object sender, EventArgs e)
        {          
            panel3.Height = po_REGON.Height;
            panel3.Visible = true;
            panel3.Location = po_REGON.Location;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "0";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.REGON.ToString().StartsWith((Wyszukaj.Text))).ToList();
            Wyszukaj.Text = "";
        }

        private void po_nazwisku_Click(object sender, EventArgs e)
        {
            
            panel3.Height = po_nazwisku.Height;
            panel3.Location = po_nazwisku.Location;
            panel3.Visible = true;
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Nazwisko.ToLower().StartsWith((Wyszukaj.Text.ToLower()))).ToList();
            Wyszukaj.Text = "";
        }

        private void po_miescie_Click(object sender, EventArgs e)
        {         
            panel3.Height = po_miescie.Height;
            panel3.Location = po_miescie.Location;
            panel3.Visible = true;
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Miasto.ToLower().StartsWith((Wyszukaj.Text.ToLower()))).ToList();
            Wyszukaj.Text = "";
        }

        private void po_powiecie_Click(object sender, EventArgs e)
        {        
            panel3.Height = po_powiecie.Height;
            panel3.Location = po_powiecie.Location;
            panel3.Visible = true;
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Powiat.ToLower().StartsWith((Wyszukaj.Text.ToLower()))).ToList();
            Wyszukaj.Text = "";
        }

        private void po_data1_mniejsze_Click(object sender, EventArgs e)
        {      
            panel3.Height = po_data1_mniejsze.Height;
            panel3.Location = po_data1_mniejsze.Location;
            panel3.Visible = true;
            Zapisz.Visible = false;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "01/01/0001";
            }
            tabela.DataSource = firmy.Where(x => x.Data1.Date < DateTime.ParseExact(Wyszukaj.Text, "d/m/yyyy", CultureInfo.InvariantCulture)).ToList();
            Wyszukaj.Text = "";
        }

        private void po_data1_wieksze_Click(object sender, EventArgs e)
        {           
            panel3.Height = po_data1_wieksze.Height;
            panel3.Location = po_data1_wieksze.Location;
            panel3.Visible = true;
            Zapisz.Visible = false;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "01/01/0001";
            }
            tabela.DataSource = firmy.Where(x => x.Data1.Date > DateTime.ParseExact(Wyszukaj.Text, "d/m/yyyy", CultureInfo.InvariantCulture)).ToList();
        }

        private void po_data2_Click(object sender, EventArgs e)
        {
            panel3.Height = po_data2_mniejsze.Height;
            panel3.Location = po_data2_mniejsze.Location;
            panel3.Visible = true;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "01/01/0001";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Data2.Date < DateTime.ParseExact(Wyszukaj.Text, "d/m/yyyy", CultureInfo.InvariantCulture)).ToList();
            Wyszukaj.Text = "";
        }

        private void po_data2_wieksze_Click(object sender, EventArgs e)
        {
            panel3.Height = po_data2_wieksze.Height;
            panel3.Location = po_data2_wieksze.Location;
            panel3.Visible = true;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "01/01/0001";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Data2.Date > DateTime.ParseExact(Wyszukaj.Text, "d/m/yyyy", CultureInfo.InvariantCulture)).ToList();
            Wyszukaj.Text = "";
        }

        private void po_przychody_mniejsze_Click(object sender, EventArgs e)
        {
            panel3.Height = po_przychody_mniejsze.Height;
            panel3.Location = po_przychody_mniejsze.Location;
            panel3.Visible = true;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "0";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Przychody < int.Parse(Wyszukaj.Text)).ToList();
            Wyszukaj.Text = "";
        }

        private void po_przychody_wieksze_Click(object sender, EventArgs e)
        {
            panel3.Height = po_przychody_wieksze.Height;
            panel3.Location = po_przychody_wieksze.Location;
            panel3.Visible = true;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "0";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.Przychody > int.Parse(Wyszukaj.Text)).ToList();
            Wyszukaj.Text = "";
        }

        private void po_EBIDTA_wieksze_Click(object sender, EventArgs e)
        {
            panel3.Height = po_EBIDTA_wieksze.Height;
            panel3.Location = po_EBIDTA_wieksze.Location;
            panel3.Visible = true;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "0";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.EBIDTA > int.Parse(Wyszukaj.Text)).ToList();
            Wyszukaj.Text = "";
        }

        private void po_EBIDTA_mniejsze_Click(object sender, EventArgs e)
        {
            
            panel3.Height = po_EBIDTA_mniejsze.Height;
            panel3.Location = po_EBIDTA_mniejsze.Location;
            panel3.Visible = true;
            if (Wyszukaj.Text == "")
            {
                Wyszukaj.Text = Wyszukaj.Text = "0";
            }
            Zapisz.Visible = false;
            tabela.DataSource = firmy.Where(x => x.EBIDTA < int.Parse(Wyszukaj.Text)).ToList();
            Wyszukaj.Text = "";
        }

        private void dodaj_firme_Click(object sender, EventArgs e)
        {           
            int pom = 0;
            Form2 b = new Form2();
          //  b.ShowDialog();
            
            if (b.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in firmy)
                {
                    pom = item.LP;
                }

                b.fir.LP = pom + 1;
                firmy.Add(b.fir);
                panel3.Visible = false;
            }
            
        }
       
        private void Zapisz_Click(object sender, EventArgs e)
        {
            string[,] dane = new string[tabela.Rows.Count, tabela.Columns.Count];
            string txt = "";
        
              foreach (DataGridViewRow row in tabela.Rows)
                {
                   foreach (DataGridViewColumn col  in tabela.Columns)
                  {                   
                        dane[row.Index, col.Index] = tabela.Rows[row.Index].Cells[col.Index].Value.ToString();
                  }
               }
            txt += "LP;Nazwa firmy;REGON;Nazwisko;Imie;Miasto;Ulica nr;Powiat;Telefon;Polisa1;data1;Polisa2;data2;Rating;Przychody;EBIDTA;NDE/EBIDTA;DSCR;produkt1;Marża1;prowizja1;produk2;Marża2;prowizja2" + "\r\n";
            foreach (DataGridViewRow i in tabela.Rows)
                {
                  foreach (DataGridViewColumn j in tabela.Columns)
                   {
                       txt += dane[i.Index, j.Index] + ";";
                   }
                 txt += "\r\n";
            }
            txt = txt.Replace('.', '/');
            txt = txt.Replace('�', 'ó');
            for (int x = 1; x < 6; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    txt = txt.Replace("00:" + x.ToString() + y.ToString(), "");
                }
            }
            txt = txt.Replace(":00", "");
            txt = txt.Replace("00:", "");            
            txt = txt.Replace(" 01", "");
            txt = txt.Replace(" 01", "");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    txt = txt.Replace(" " + i.ToString() + j.ToString(), "");
                    
                }
            }
            txt = txt.Replace(".", "/");
            txt = txt.Replace(".", "/");
            txt = txt.Replace(" ", "");
            txt = txt.Replace(" ", "");
            
            File.WriteAllText("ProjektB.csv", txt);      
        }
       
        private void Usun_Click_1(object sender, EventArgs e)
        {
            int row = tabela.CurrentCell.RowIndex;
            firmy.RemoveAt(row);
            tabela.DataSource = firmy;
            Zapisz.Visible = false;
            Usunieto_element.Text = "usunieto element o indeksie: " + (row+1).ToString();
            Usunieto_element.Visible = true;
    
            foreach (var item in firmy)
            {
                item.LP = firmy.IndexOf(item)+1;
            }
            tabela.DataSource = firmy.Where(x => x.Nazwa_firmy.ToLower().StartsWith((""))).ToList();
        }
      
        private void pokaz_wykres_CheckedChanged(object sender, EventArgs e)
        {       
            Usun.Visible = false;
            Zapisz.Visible = false;
            tabela.Visible = false;
            Usunieto_element.Visible = false;
            wykres.Visible = true;
                          
            foreach (var item in firmy)
            {
                this.chart1.Visible = true;
                this.chart1.Series["Przychody"].Points.AddXY(item.Nazwa_firmy, item.Przychody);
            }
        }

        private void ukryj_wykres_CheckedChanged(object sender, EventArgs e)
        {
            Zapisz.Visible = false;
            Usun.Visible = true;
            tabela.Visible = true;
            Usunieto_element.Visible = false;
            wykres.Visible = false;

            this.chart1.Series["Przychody"].Points.Clear();
            this.chart1.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SidePanel_MouseMove(object sender, MouseEventArgs e)
        {
           // tabela.DataSource = firmy.Where(x => x.Nazwa_firmy.ToLower().StartsWith((""))).ToList();
            Liczba_firm.Text = "Liczba firm: " + firmy.Count.ToString(); 
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drukuj_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Raport firm";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(tabela);
        }    
    }
}
