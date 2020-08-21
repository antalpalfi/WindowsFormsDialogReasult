using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDialogReasult
{
    public class Rekenings
    {

        public int Kredit { get; set; }
        public string Naam { get; set; }
        public string AccountN { get; set; }
        
        public Rekenings(int kredit, string naam,string account)
        {
            Naam = naam;
            Kredit = kredit;
            AccountN = account;
        }
        public Rekenings()
        {

        }

        public virtual string Account()
        {

            return $"U heeft {Kredit} euro op uw bank rekening\n" +
                $"U heeft  een {Naam} rekening";
        }
        public override string ToString()
        {
            return AccountN;
        }
    }
}
