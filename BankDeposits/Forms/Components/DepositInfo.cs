using BankDeposits.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits.Forms.Components
{
    public partial class DepositInfo : UserControl
    {
        public DepositInfo()
        {
            InitializeComponent();
        }
        public DepositInfo(DepositType deposit)
        {
            InitializeComponent();
        }
    }
}
