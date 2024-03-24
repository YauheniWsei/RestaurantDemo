﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest0._1
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logIn_but_Click(object sender, EventArgs e)
        {
            if (login_box.Text == "admin" && pass_box.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
