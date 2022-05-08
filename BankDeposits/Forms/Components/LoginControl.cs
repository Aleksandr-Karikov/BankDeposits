using BankDeposits.Utils;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var user = AuthService.TryLogin(textBox1.Text, textBox2.Text);
            if (user!=null)
            {

                MainForm parentForm = (this.Parent as MainForm);
                if (user.Role == "Менеджер")
                {
                    parentForm.ManagerControl = new ManagerControl(user);
                    parentForm.SetActiveControl(parentForm.ManagerControl);
                } else
                {
                    parentForm.MainControl = new MainControl(user);
                    parentForm.SetActiveControl(parentForm.MainControl);
                }
                
            }
        }
    }
}
