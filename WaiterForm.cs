using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rest0._1
{
    public partial class WaiterForm : Form
    {

        DataBase dataBase = new DataBase();

        public WaiterForm()
        {
            InitializeComponent();
        }

        private void table1_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 1;
        }

        private void hide_panel_but_Click(object sender, EventArgs e)
        {
            order_panel.Visible = false;
        }

        private void close_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void create_order_but_Click(object sender, EventArgs e)
        {
            ConfirmOrder confirmOrder = new ConfirmOrder();
            confirmOrder.Show();
            confirmOrder.num_of_table.Text = numeric_num_table.Value.ToString();
            confirmOrder.label_with_pos.Text = ($" - {Box_dishes_1.Text} in {num_of_position_1.Value}\n - {Box_dishes_2.Text} in {num_of_position_2.Value}\n - {Box_dishes_3.Text} in {num_of_position_3.Value}");
            if (comments_box.Text == "")
            {
                confirmOrder.label_for_comments.Text = "No comments";
            }
            else { confirmOrder.label_for_comments.Text = ($"Comments:\n{comments_box.Text}"); }

            confirmOrder.price_text.Text = ($"{(num_of_position_1.Value * 6) + (num_of_position_2.Value * 4) + (num_of_position_1.Value * 9)}$");
        }

        private void table2_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 2;
        }

        private void table3_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 3;
        }

        private void table4_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 4;
        }

        private void table5_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 5;
        }

        private void table6_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 6;
        }

        private void table7_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 7;
        }

        private void table8_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 8;
        }

        private void table9_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 9;
        }

        private void table10_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 10;
        }

        private void table11_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 11;
        }

        private void table12_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 12;
        }

        private void table13_Click(object sender, EventArgs e)
        {
            order_panel.Visible = true;
            numeric_num_table.Value = 13;
        }
    }
}
