using System;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void waiter_log_Click(object sender, EventArgs e)
        {
            WaiterForm waiterForm = new WaiterForm();
            waiterForm.Show();
            this.Hide();
        }

        private void cook_log_Click(object sender, EventArgs e)
        {
            CookForm cookForm = new CookForm();
            cookForm.Show();
            this.Hide();
        }
    }
}
