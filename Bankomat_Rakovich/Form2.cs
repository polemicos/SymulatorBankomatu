using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bankomat_Rakovich
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public IDictionary<int, int> banknoty = new Dictionary<int, int>();
        string adminLog;
        //public bool zmiany;
        public Form2(Form1 main, string log)
        {
            InitializeComponent();
            banknoty = main.banknoty;
            adminLog = log;
            //zmiany = main.adminChanges;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.Match(textBoxHaslo.Text, @"123").Success)
            {
                textBoxHaslo.Visible = false;
                labelHaslo.Visible = false;
                button1.Visible = false;
                button1.Enabled = false;
                textBoxHaslo.Enabled = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                textBox10.Enabled= true;
                textBox20.Enabled= true;
                textBox50.Enabled= true;
                textBox100.Enabled = true;
                textBox200.Enabled = true;
                textBox500.Enabled = true;
                textBox10.Visible = true;
                textBox20.Visible = true;
                textBox50.Visible = true;
                textBox100.Visible = true;
                textBox200.Visible = true;
                textBox500.Visible = true;
                buttonZmiany.Enabled = true;
                buttonZmiany.Visible = true;
                richTextBoxWydano.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                
            }
            else
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox10.Text = banknoty[10].ToString();
            textBox20.Text = banknoty[20].ToString();
            textBox50.Text = banknoty[50].ToString();
            textBox100.Text = banknoty[100].ToString();
            textBox200.Text = banknoty[200].ToString();
            textBox500.Text = banknoty[500].ToString();
            richTextBoxWydano.Text = adminLog;
        }

        private void buttonZmiany_Click(object sender, EventArgs e)
        {
            bool evOK = true;
            labelBl10.Visible = false;
            labelBl20.Visible = false;
            labelBl50.Visible = false;
            labelBl100.Visible = false;
            labelBl200.Visible = false;
            labelBl500.Visible = false;




            if (!Regex.Match(textBox10.Text, @"^[\D]+|^0.+$").Success)
            {
                banknoty[10] = Int32.Parse(textBox10.Text);
            }
            else
            {
                evOK = false;
                labelBl10.Visible = true;
            }
            if (!Regex.Match(textBox20.Text, @"^[\D]+|^0.+$").Success)
            {
                banknoty[20] = Int32.Parse(textBox20.Text);
            }
            else
            {
                evOK = false;
                labelBl20.Visible = true;
            }
            if (!Regex.Match(textBox50.Text, @"^[\D]+|^0.+$").Success)
            {
                banknoty[50] = Int32.Parse(textBox50.Text);
            }
            else
            {
                evOK = false;
                labelBl50.Visible = true;
            }
            if (!Regex.Match(textBox100.Text, @"^[\D]+|^0.+$").Success)
            {
                banknoty[100] = Int32.Parse(textBox100.Text);
            }
            else
            {
                evOK = false;
                labelBl100.Visible = true;
            }
            if (!Regex.Match(textBox200.Text, @"^[\D]+|^0.+$").Success)
            {
                banknoty[200] = Int32.Parse(textBox200.Text);
            }
            else
            {
                evOK = false;
                labelBl200.Visible = true;
            }
            if (!Regex.Match(textBox500.Text, @"^[\D]+|^0.+$").Success)
            {
                banknoty[500] = Int32.Parse(textBox500.Text);
            }
            else
            {
                evOK = false;
                labelBl500.Visible = true;
            }

            if (evOK)
            {
                labelSukces.Visible = true;
            }
        }
    }
}
