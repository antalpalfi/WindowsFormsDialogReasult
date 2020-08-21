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
    public partial class Overschrijven : Form
    {
        public Overschrijven(List<Rekenings>rekenings)
        {
            InitializeComponent();
        }
        public List<Rekenings> ujLista;

        private void Overschrijven_Load(object sender, EventArgs e)
        {
        }
    }
}
