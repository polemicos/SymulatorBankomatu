using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bankomat_Rakovich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string log;
        public IDictionary<int, int> banknoty = new Dictionary<int, int>();
        public int sumaKontrolna = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            banknoty.Add(10, 0);
            banknoty.Add(20, 1);
            banknoty.Add(50, 2);
            banknoty.Add(100, 3);
            banknoty.Add(200, 4);
            banknoty.Add(500, 7);
            policzSumeKontrolna();
            //textBoxStanKonta.Text = sumaKontrolna.ToString() + "zl";
        }


        public int policzSumeKontrolna()
        {
            sumaKontrolna = 0;
            foreach (int banknota in banknoty.Keys)
            {
                sumaKontrolna += banknota * banknoty[banknota];
            }
            textBoxStanKonta.Text = sumaKontrolna.ToString() + "zl";
            return sumaKontrolna;
        }



        private string wydajPieniadze(int kwota)
        {
            banknoty = banknoty.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            IDictionary<int, int> kontrolaBanknot = new Dictionary<int, int>();
            kontrolaBanknot[10] = 0;
            kontrolaBanknot[20] = 0;
            kontrolaBanknot[50] = 0;
            kontrolaBanknot[100] = 0;
            kontrolaBanknot[200] = 0;
            kontrolaBanknot[500] = 0;

            Stopwatch waitTime = new Stopwatch();
            int sumaTmp = 0;
            waitTime.Start();
            while (sumaTmp != kwota)
            {
                foreach(int banknota in banknoty.Keys)
                {


                    if (banknoty[banknota] - kontrolaBanknot[banknota] > 0 && sumaTmp + banknota <= kwota)
                    {
                        //int tmpMod = kwota % banknoty[banknota];

                        sumaTmp += banknota;
                        kontrolaBanknot[banknota] += 1;
                    }
                    else
                    {
                        continue;
                    }



                }
                if(waitTime.ElapsedMilliseconds >= 500)
                {
                    waitTime.Stop();
                    labelBrakBanknot.Visible = true;
                    return "";
                }

                banknoty = banknoty.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            }

            string wynik = "";

            foreach(int banknota in kontrolaBanknot.Keys)
            {
                banknoty[banknota] -= kontrolaBanknot[banknota];
                if(kontrolaBanknot[banknota]!= 0)
                {

                    wynik += $"Wydano {kontrolaBanknot[banknota]} banknoty o wartosci {banknota}zl\n";
                }
            }

            policzSumeKontrolna();
            return wynik + "\n";

        }



        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxKwota.Text == "")
            {
                labelBrakBanknot.Visible = false;
                labelNiemaSrodkow.Visible = false;
                labelMalo.Visible = false;
                labelFormat.Visible = false;
                labelNieWpisanaKwota.Visible = true;
            }
            else if (Regex.Match(textBoxKwota.Text, @"^[\D]+|^0.+$").Success)
            {
                labelBrakBanknot.Visible = false;
                labelNieWpisanaKwota.Visible = false;
                labelNiemaSrodkow.Visible = false;
                labelMalo.Visible = false;
                labelFormat.Visible = true;
            }
            else if(policzSumeKontrolna() < Int32.Parse(textBoxKwota.Text))
            {
                labelFormat.Visible = false;
                labelBrakBanknot.Visible = false;
                labelNieWpisanaKwota.Visible = false;
                labelNiemaSrodkow.Visible = true;
                labelMalo.Visible = false;
            }
            else if (Int32.Parse(textBoxKwota.Text) < 10)
            {
                labelBrakBanknot.Visible = false;
                labelNieWpisanaKwota.Visible = false;
                labelNiemaSrodkow.Visible = false;
                labelMalo.Visible = true;
                labelFormat.Visible = false;
            }
            else
            {
                labelFormat.Visible = false;
                labelBrakBanknot.Visible = false;
                labelNieWpisanaKwota.Visible = false;
                labelNiemaSrodkow.Visible = false;
                labelMalo.Visible = false;
                int kwota = Int32.Parse(textBoxKwota.Text);
                string tmp = wydajPieniadze(kwota);
                richTextBoxWydano.Text = tmp;
                log += tmp;


            }
        }

        private void buttonAdministrator_Click(object sender, EventArgs e)
        {
            //string log = richTextBoxWydano.Text; 
            Form2 admin = new Form2(this, log);
            admin.ShowDialog();
            policzSumeKontrolna();
        }
        
    }
}
