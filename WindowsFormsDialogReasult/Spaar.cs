using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDialogReasult
{
    public class Spaar : Rekenings
    {
        
        public Spaar(int kredit, string naam, string account) : base(kredit, naam, account)
        {

        }
        public override string Account()
        {
            return base.Account() + "\nDeze rekening kan niet overschrijven";
        }
    }
}
