﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDialogReasult
{
    public partial class Overschrijven : Form
    {
       
        public Overschrijven()

        {
            InitializeComponent();
            
        }
        public int bedrag;
       
        
        private void Overschrijven_Load(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = bedrag;
        }
    }
}
