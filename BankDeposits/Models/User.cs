using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeposits.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AccountNumber { get; set; }
        public Decimal Balance { get; set; }
        public DateTime DateCreate { get; set; }
        public string SeriesPassport { get; set; }
        public string PassportNumber { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDeleted { get; set; }
        public int? ManageID { get; set; }
        public string Password { get; set; }
    }
}
