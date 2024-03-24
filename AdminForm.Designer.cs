namespace Rest0._1
{
    partial class AdminForm
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
            this.waiter_log = new System.Windows.Forms.Button();
            this.cook_log = new System.Windows.Forms.Button();
            this.close_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // waiter_log
            // 
            this.waiter_log.BackColor = System.Drawing.SystemColors.Window;
            this.waiter_log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.waiter_log.FlatAppearance.BorderSize = 3;
            this.waiter_log.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.waiter_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waiter_log.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiter_log.Location = new System.Drawing.Point(55, 127);
            this.waiter_log.Name = "waiter_log";
            this.waiter_log.Size = new System.Drawing.Size(250, 250);
            this.waiter_log.TabIndex = 0;
            this.waiter_log.Text = "Waiter";
            this.waiter_log.UseVisualStyleBackColor = false;
            this.waiter_log.Click += new System.EventHandler(this.waiter_log_Click);
            // 
            // cook_log
            // 
            this.cook_log.BackColor = System.Drawing.SystemColors.Window;
            this.cook_log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cook_log.FlatAppearance.BorderSize = 3;
            this.cook_log.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cook_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cook_log.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cook_log.Location = new System.Drawing.Point(365, 127);
            this.cook_log.Name = "cook_log";
            this.cook_log.Size = new System.Drawing.Size(250, 250);
            this.cook_log.TabIndex = 1;
            this.cook_log.Text = "Cook";
            this.cook_log.UseVisualStyleBackColor = false;
            this.cook_log.Click += new System.EventHandler(this.cook_log_Click);
            // 
            // close_but
            // 
            this.close_but.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.close_but.CausesValidation = false;
            this.close_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_but.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_but.FlatAppearance.BorderSize = 2;
            this.close_but.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_but.Location = new System.Drawing.Point(12, 12);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(191, 73);
            this.close_but.TabIndex = 8;
            this.close_but.Text = "Close";
            this.close_but.UseVisualStyleBackColor = false;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 420);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.cook_log);
            this.Controls.Add(this.waiter_log);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button waiter_log;
        private System.Windows.Forms.Button cook_log;
        private System.Windows.Forms.Button close_but;
    }
}