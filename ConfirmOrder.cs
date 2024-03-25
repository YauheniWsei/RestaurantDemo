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
    public partial class ConfirmOrder : Form
    {
        WaiterForm waiterForm = new WaiterForm();
        DataBase dataBase = new DataBase();

        public ConfirmOrder()
        {
            InitializeComponent();
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void confirm_but_Click(object sender, EventArgs e)
        {
            int num_of_table = (int) waiterForm.numeric_num_table.Value;

            string dish1 = waiterForm.Box_dishes_1.Text;
            int pos1 = (int) waiterForm.num_of_position_1.Value;

            string dish2 = waiterForm.Box_dishes_2.Text;
            int pos2 = (int) waiterForm.num_of_position_2.Value;

            string dish3 = waiterForm.Box_dishes_3.Text;
            int pos3 = (int) waiterForm.num_of_position_3.Value;

            int TotalPrice = (pos1 * 6) + (pos2 * 4) + (pos3 * 9);

            string comments = waiterForm.comments_box.Text;

            dataBase.CreateOrder(num_of_table, "New", dish1, pos1, dish2, pos2, dish3, pos3, TotalPrice, comments);
            this.Close();
        }

    }
}
