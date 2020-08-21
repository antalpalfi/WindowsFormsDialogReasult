using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDialogReasult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Rekenings> rekenings = new List<Rekenings>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Random rng = new Random();
            string rekeningnr = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(9999);
                rekeningnr += " " + randomnr.ToString().PadLeft(4, '0');
            }
            
            Rekenings rekenings1 = new Debit(10000, "Debit", rekeningnr);
            rekenings.Add(rekenings1);
            comboBox1.Items.Add("Credit");
            comboBox1.Items.Add("Spaar");
            comboBox1.Items.Add("Debit");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Credit":
                    btnOversc.Enabled = true;
                    List<Credit> credit = new List<Credit>();

                    foreach (var item in rekenings.OfType<Credit>())
                    {
                        credit.Add(item);
                    }

                    listBoxAccount.DataSource = null;
                    listBoxAccount.DataSource = credit;
                    break;
                case "Spaar":
                    btnOversc.Enabled = false;
                    List<Spaar> spaar = new List<Spaar>();

                    foreach (var item in rekenings.OfType<Spaar>())
                    {
                        spaar.Add(item);
                    }

                    listBoxAccount.DataSource = null;
                    listBoxAccount.DataSource = spaar;
                    break;

                case "Debit":
                    btnOversc.Enabled = true;
                    List<Debit> debit = new List<Debit>();

                    foreach (var item in rekenings.OfType<Debit>())
                    {
                        debit.Add(item);
                    }

                    listBoxAccount.DataSource = null;
                    listBoxAccount.DataSource = debit;
                    break;
                default:
                    break;
            }
        }

        private void listBoxCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rekenings selected = (Rekenings)listBoxAccount.SelectedItem;
            if (listBoxAccount.DataSource != null)
            {
                labelInfo.Text = selected.Account();
            }
            else labelInfo.Text = "";
        }

        private void btnNiewR_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Credit")
            {
                Random rng = new Random();
                string rekeningnr = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

                for (int i = 1; i <= 3; i++)
                {
                    int randomnr = rng.Next(9999);
                    rekeningnr += " " + randomnr.ToString().PadLeft(4, '0');
                }
                Random cvn = new Random();
                int cv = cvn.Next(999);
                Rekenings rekenings1 = new Credit(0, "Debit", rekeningnr,cv);
                rekenings.Add(rekenings1);
                List<Credit> credit = new List<Credit>();
                foreach (var item in rekenings.OfType<Credit>())
                {
                    credit.Add(item);
                }
                listBoxAccount.DataSource = null;
                listBoxAccount.DataSource = credit;
            }
            else if (comboBox1.Text == "Spaar")
            {
                Random rng = new Random();
                string rekeningnr = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

                for (int i = 1; i <= 3; i++)
                {
                    int randomnr = rng.Next(9999);
                    rekeningnr += " " + randomnr.ToString().PadLeft(4, '0');
                }
                Rekenings rekenings1 = new Spaar(0, "Spaar", rekeningnr);
                rekenings.Add(rekenings1);
                List<Spaar> spaar = new List<Spaar>();
                foreach (var item in rekenings.OfType<Spaar>())
                {
                    spaar.Add(item);
                }
                listBoxAccount.DataSource = null;
                listBoxAccount.DataSource = spaar;
            }
            else if (comboBox1.Text == "Debit")
            {
                Random rng = new Random();
                string rekeningnr = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

                for (int i = 1; i <= 3; i++)
                {
                    int randomnr = rng.Next(9999);
                    rekeningnr += " " + randomnr.ToString().PadLeft(4, '0');
                }
                Rekenings rekenings1 = new Debit(0, "Debit", rekeningnr);
                rekenings.Add(rekenings1);
                List<Debit> debit = new List<Debit>();
                foreach (var item in rekenings.OfType<Debit>())
                {
                    debit.Add(item);
                }
                listBoxAccount.DataSource = null;
                listBoxAccount.DataSource = debit;

            }
        }

        private void btnOversc_Click(object sender, EventArgs e)
        {
            
            Overschrijven overschrijven = new Overschrijven();
            if (overschrijven.ShowDialog()==DialogResult.OK)
            {
               
            }
            
        }
    }
}
