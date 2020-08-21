using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDialogReasult
{
    public class Credit : Rekenings
    {
        public int CvNummer { get; set; }
        public Credit(int kredit, string naam, string account, int cvnummer) : base(kredit, naam, account)
        {
            CvNummer = cvnummer;
        }
        public override string Account()
        {
            return base.Account() + $"\n Uw cv nummer: {CvNummer}";
        }
    }
}
