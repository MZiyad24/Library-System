namespace DataBaseProject
{
    partial class User
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
            this.browse = new System.Windows.Forms.Button();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.DataGridView();
            this.search_label = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.return_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(653, 112);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(111, 36);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // borrow_btn
            // 
            this.borrow_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_btn.Location = new System.Drawing.Point(187, 378);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(115, 36);
            this.borrow_btn.TabIndex = 2;
            this.borrow_btn.Text = "Borrow";
            this.borrow_btn.UseVisualStyleBackColor = true;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // results
            // 
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Location = new System.Drawing.Point(12, 154);
            this.results.Name = "results";
            this.results.RowHeadersWidth = 51;
            this.results.RowTemplate.Height = 24;
            this.results.Size = new System.Drawing.Size(776, 205);
            this.results.TabIndex = 3;
            this.results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellContentClick);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_label.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(121, 79);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(76, 27);
            this.search_label.TabIndex = 5;
            this.search_label.Text = "Search";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(224, 76);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(330, 30);
            this.search.TabIndex = 6;
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(513, 378);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(107, 36);
            this.return_btn.TabIndex = 7;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.Location = new System.Drawing.Point(647, 12);
            this.user_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(141, 38);
            this.user_btn.TabIndex = 30;
            this.user_btn.Text = "USERNAME";
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "click on the username to log out\r\n\r\n";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.results);
            this.Controls.Add(this.borrow_btn);
            this.Controls.Add(this.browse);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Label label5;
    }
}