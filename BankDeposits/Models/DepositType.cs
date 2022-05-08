using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeposits.Models
{
    public class DepositType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsRefilable {get;set;}
        public bool IsWithdrawable { get; set; }
        public int? Term { get; set; }
        public int? InterestRate { get; set; }
        public int? MinimumDeposit { get; set; }
        public int? MinimumWithdraw { get; set; }
        public int? AccrualFrequency { get; set; }

    }
}
