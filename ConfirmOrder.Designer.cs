namespace Rest0._1
{
    partial class ConfirmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_but = new System.Windows.Forms.Button();
            this.confirm_but = new System.Windows.Forms.Button();
            this.cond_ord_text = new System.Windows.Forms.Label();
            this.panel_backgr = new System.Windows.Forms.Panel();
            this.label_for_comments = new System.Windows.Forms.Label();
            this.panel_with_price = new System.Windows.Forms.Panel();
            this.price_text = new System.Windows.Forms.Label();
            this.panel_with_table = new System.Windows.Forms.Panel();
            this.num_of_table = new System.Windows.Forms.Label();
            this.table_conf = new System.Windows.Forms.Label();
            this.label_with_pos = new System.Windows.Forms.Label();
            this.Pos_conf = new System.Windows.Forms.Label();
            this.panel_backgr.SuspendLayout();
            this.panel_with_price.SuspendLayout();
            this.panel_with_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_but
            // 
            this.cancel_but.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_but.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel_but.FlatAppearance.BorderSize = 3;
            this.cancel_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancel_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancel_but.Location = new System.Drawing.Point(24, 458);
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Size = new System.Drawing.Size(135, 54);
            this.cancel_but.TabIndex = 30;
            this.cancel_but.Text = "Cancel";
            this.cancel_but.UseVisualStyleBackColor = false;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // confirm_but
            // 
            this.confirm_but.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.confirm_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_but.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirm_but.FlatAppearance.BorderSize = 3;
            this.confirm_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.confirm_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm_but.Location = new System.Drawing.Point(272, 458);
            this.confirm_but.Name = "confirm_but";
            this.confirm_but.Size = new System.Drawing.Size(298, 54);
            this.confirm_but.TabIndex = 31;
            this.confirm_but.Text = "Confirm";
            this.confirm_but.UseVisualStyleBackColor = false;
            this.confirm_but.Click += new System.EventHandler(this.confirm_but_Click);
            // 
            // cond_ord_text
            // 
            this.cond_ord_text.AutoSize = true;
            this.cond_ord_text.BackColor = System.Drawing.Color.DarkSalmon;
            this.cond_ord_text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cond_ord_text.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cond_ord_text.Location = new System.Drawing.Point(24, 22);
            this.cond_ord_text.Name = "cond_ord_text";
            this.cond_ord_text.Size = new System.Drawing.Size(243, 34);
            this.cond_ord_text.TabIndex = 32;
            this.cond_ord_text.Text = "Confirm the order!";
            // 
            // panel_backgr
            // 
            this.panel_backgr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_backgr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_backgr.Controls.Add(this.label_for_comments);
            this.panel_backgr.Controls.Add(this.panel_with_price);
            this.panel_backgr.Controls.Add(this.panel_with_table);
            this.panel_backgr.Controls.Add(this.label_with_pos);
            this.panel_backgr.Controls.Add(this.Pos_conf);
            this.panel_backgr.Location = new System.Drawing.Point(24, 82);
            this.panel_backgr.Name = "panel_backgr";
            this.panel_backgr.Size = new System.Drawing.Size(531, 296);
            this.panel_backgr.TabIndex = 33;
            // 
            // label_for_comments
            // 
            this.label_for_comments.AutoSize = true;
            this.label_for_comments.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_for_comments.Location = new System.Drawing.Point(14, 201);
            this.label_for_comments.Name = "label_for_comments";
            this.label_for_comments.Size = new System.Drawing.Size(22, 26);
            this.label_for_comments.TabIndex = 5;
            this.label_for_comments.Text = "a";
            // 
            // panel_with_price
            // 
            this.panel_with_price.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_with_price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_with_price.Controls.Add(this.price_text);
            this.panel_with_price.Location = new System.Drawing.Point(355, 201);
            this.panel_with_price.Name = "panel_with_price";
            this.panel_with_price.Size = new System.Drawing.Size(158, 74);
            this.panel_with_price.TabIndex = 4;
            // 
            // price_text
            // 
            this.price_text.AutoSize = true;
            this.price_text.BackColor = System.Drawing.Color.SkyBlue;
            this.price_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_text.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_text.ForeColor = System.Drawing.Color.Red;
            this.price_text.Location = new System.Drawing.Point(29, 14);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(96, 44);
            this.price_text.TabIndex = 5;
            this.price_text.Text = "1000";
            // 
            // panel_with_table
            // 
            this.panel_with_table.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_with_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_with_table.Controls.Add(this.num_of_table);
            this.panel_with_table.Controls.Add(this.table_conf);
            this.panel_with_table.Location = new System.Drawing.Point(355, 17);
            this.panel_with_table.Name = "panel_with_table";
            this.panel_with_table.Size = new System.Drawing.Size(122, 149);
            this.panel_with_table.TabIndex = 3;
            // 
            // num_of_table
            // 
            this.num_of_table.AutoSize = true;
            this.num_of_table.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.num_of_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num_of_table.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_of_table.Location = new System.Drawing.Point(29, 71);
            this.num_of_table.Name = "num_of_table";
            this.num_of_table.Size = new System.Drawing.Size(67, 47);
            this.num_of_table.TabIndex = 4;
            this.num_of_table.Text = "XI";
            // 
            // table_conf
            // 
            this.table_conf.AutoSize = true;
            this.table_conf.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.table_conf.Location = new System.Drawing.Point(15, 11);
            this.table_conf.Name = "table_conf";
            this.table_conf.Size = new System.Drawing.Size(88, 34);
            this.table_conf.TabIndex = 2;
            this.table_conf.Text = "Table:";
            // 
            // label_with_pos
            // 
            this.label_with_pos.AutoSize = true;
            this.label_with_pos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_with_pos.Location = new System.Drawing.Point(14, 69);
            this.label_with_pos.Name = "label_with_pos";
            this.label_with_pos.Size = new System.Drawing.Size(22, 26);
            this.label_with_pos.TabIndex = 1;
            this.label_with_pos.Text = "a";
            // 
            // Pos_conf
            // 
            this.Pos_conf.AutoSize = true;
            this.Pos_conf.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pos_conf.Location = new System.Drawing.Point(13, 17);
            this.Pos_conf.Name = "Pos_conf";
            this.Pos_conf.Size = new System.Drawing.Size(129, 34);
            this.Pos_conf.TabIndex = 0;
            this.Pos_conf.Text = "Positions:";
            // 
            // ConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 524);
            this.Controls.Add(this.panel_backgr);
            this.Controls.Add(this.cond_ord_text);
            this.Controls.Add(this.confirm_but);
            this.Controls.Add(this.cancel_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmOrder";
            this.panel_backgr.ResumeLayout(false);
            this.panel_backgr.PerformLayout();
            this.panel_with_price.ResumeLayout(false);
            this.panel_with_price.PerformLayout();
            this.panel_with_table.ResumeLayout(false);
            this.panel_with_table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_but;
        private System.Windows.Forms.Button confirm_but;
        private System.Windows.Forms.Label cond_ord_text;
        private System.Windows.Forms.Panel panel_backgr;
        private System.Windows.Forms.Label Pos_conf;
        private System.Windows.Forms.Panel panel_with_table;
        private System.Windows.Forms.Label table_conf;
        private System.Windows.Forms.Panel panel_with_price;
        public System.Windows.Forms.Label num_of_table;
        public System.Windows.Forms.Label label_for_comments;
        public System.Windows.Forms.Label label_with_pos;
        public System.Windows.Forms.Label price_text;
    }
}