using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeposits.Models
{
    public class Deposit
    {
        public int ID { get; set; }
        public int? TypeID {get;set;}

        public int? UserID { get; set; }
        public Decimal? StartBalance { get; set; }
        public Decimal? CurrentBalance { get; set; }
        public int? CurrencyID { get; set; }
        public bool isConfirmed { get; set; }
        public DateTime DateCreate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
