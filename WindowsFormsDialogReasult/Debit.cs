using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDialogReasult
{
    public class Debit :Rekenings
    {
        public string Regel { get; set; }
        public Debit(int kredit, string naam, string account) : base(kredit, naam,account)
        {
            
        }
        public override string Account()
        {
            return base.Account();
        }
    }
}
