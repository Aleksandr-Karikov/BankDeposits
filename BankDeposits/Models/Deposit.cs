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
        public int? Balance { get; set; }
        public int? CUrrencyID { get; set; }
        public bool isConfirmed { get; set; }
    }
}
