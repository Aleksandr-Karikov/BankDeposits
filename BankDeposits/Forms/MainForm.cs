﻿using BankDeposits.Forms.Base;
using BankDeposits.Forms.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits.Forms
{
    public partial class MainForm : BaseForm
    {
        public UserControl LoginControl = new LoginControl();
        public UserControl RegisterControl = new RegisterForm();
        public MainForm()
        {
            InitializeComponent();
            SetActiveControl(LoginControl);
        }

        public void SetActiveControl(UserControl control)
        {
            this.Controls.Clear();
            this.Controls.Add(control);
            this.Width = control.Width;
            this.Height = control.Height;
        }
    }
}