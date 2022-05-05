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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm parentForm = (this.Parent as MainForm);
            parentForm.SetActiveControl(parentForm.RegisterControl);
        }
    }
}
