namespace DataBaseProject
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            this.email_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.admin_btn = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.RadioButton();
            this.user_id_val = new System.Windows.Forms.NumericUpDown();
            this.user_id_btn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_id_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.SystemColors.HighlightText;
            this.email_box.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.email_box.Location = new System.Drawing.Point(57, 384);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(195, 30);
            this.email_box.TabIndex = 2;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(57, 435);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(195, 30);
            this.password_box.TabIndex = 3;
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(891, 395);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(145, 43);
            this.sign.TabIndex = 4;
            this.sign.Text = "Sign up";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email.Location = new System.Drawing.Point(282, 384);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(64, 27);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(282, 435);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 27);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(891, 455);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(145, 43);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(57, 482);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.TabIndex = 14;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(282, 482);
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username.Size = new System.Drawing.Size(107, 27);
            this.username.TabIndex = 13;
            this.username.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admin_btn);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(433, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 113);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // admin_btn
            // 
            this.admin_btn.AutoSize = true;
            this.admin_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(6, 34);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(84, 26);
            this.admin_btn.TabIndex = 8;
            this.admin_btn.TabStop = true;
            this.admin_btn.Text = "admin";
            this.admin_btn.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(6, 66);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(63, 24);
            this.user.TabIndex = 7;
            this.user.TabStop = true;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = true;
            // 
            // user_id_val
            // 
            this.user_id_val.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id_val.Location = new System.Drawing.Point(433, 382);
            this.user_id_val.Name = "user_id_val";
            this.user_id_val.Size = new System.Drawing.Size(120, 34);
            this.user_id_val.TabIndex = 16;
            // 
            // user_id_btn
            // 
            this.user_id_btn.AutoSize = true;
            this.user_id_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_id_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id_btn.Location = new System.Drawing.Point(583, 384);
            this.user_id_btn.Name = "user_id_btn";
            this.user_id_btn.Size = new System.Drawing.Size(82, 27);
            this.user_id_btn.TabIndex = 17;
            this.user_id_btn.Text = "User ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1353, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user_id_btn);
            this.Controls.Add(this.user_id_val);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.email_box);
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_id_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton admin_btn;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.NumericUpDown user_id_val;
        private System.Windows.Forms.Label user_id_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}