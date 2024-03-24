namespace Rest0._1
{
    partial class Entrance
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pass_box = new System.Windows.Forms.TextBox();
            this.logIn_but = new System.Windows.Forms.Button();
            this.login_box = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.Label();
            this.welcome_text = new System.Windows.Forms.Label();
            this.close_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass_box.HideSelection = false;
            this.pass_box.Location = new System.Drawing.Point(46, 349);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(341, 53);
            this.pass_box.TabIndex = 0;
            // 
            // logIn_but
            // 
            this.logIn_but.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logIn_but.CausesValidation = false;
            this.logIn_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logIn_but.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logIn_but.FlatAppearance.BorderSize = 2;
            this.logIn_but.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.logIn_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIn_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logIn_but.Location = new System.Drawing.Point(286, 428);
            this.logIn_but.Name = "logIn_but";
            this.logIn_but.Size = new System.Drawing.Size(101, 48);
            this.logIn_but.TabIndex = 2;
            this.logIn_but.Text = "Log In";
            this.logIn_but.UseVisualStyleBackColor = false;
            this.logIn_but.Click += new System.EventHandler(this.logIn_but_Click);
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_box.Location = new System.Drawing.Point(46, 229);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(341, 53);
            this.login_box.TabIndex = 3;
            // 
            // pass_text
            // 
            this.pass_text.AutoSize = true;
            this.pass_text.BackColor = System.Drawing.Color.Beige;
            this.pass_text.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass_text.Location = new System.Drawing.Point(12, 304);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(167, 42);
            this.pass_text.TabIndex = 4;
            this.pass_text.Text = "Password:";
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.BackColor = System.Drawing.Color.Beige;
            this.login_text.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_text.Location = new System.Drawing.Point(12, 184);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(113, 42);
            this.login_text.TabIndex = 5;
            this.login_text.Text = "Login:";
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.welcome_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcome_text.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcome_text.Location = new System.Drawing.Point(68, 45);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(276, 70);
            this.welcome_text.TabIndex = 6;
            this.welcome_text.Text = "Welcome!";
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
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_but.Location = new System.Drawing.Point(19, 428);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(101, 48);
            this.close_but.TabIndex = 7;
            this.close_but.Text = "Close";
            this.close_but.UseVisualStyleBackColor = false;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 493);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.welcome_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.logIn_but);
            this.Controls.Add(this.pass_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button logIn_but;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label pass_text;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Button close_but;
    }
}

