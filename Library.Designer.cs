namespace DataBaseProject
{
    partial class Library
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
            this.results = new System.Windows.Forms.DataGridView();
            this.return_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Location = new System.Drawing.Point(81, 90);
            this.results.Name = "results";
            this.results.RowHeadersWidth = 51;
            this.results.RowTemplate.Height = 24;
            this.results.Size = new System.Drawing.Size(665, 192);
            this.results.TabIndex = 0;
            this.results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellContentClick);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(363, 353);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(107, 36);
            this.return_btn.TabIndex = 8;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_btn.Location = new System.Drawing.Point(632, 12);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(147, 36);
            this.user_btn.TabIndex = 10;
            this.user_btn.Text = "USERNAME";
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "CLICK ON THE BOOK YOU WANT TO RETURN FROM THE GRID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "CLICK ON THE USERNAME TO RETURN TO THE USER FORM";
            // 
            // Library
            // 
            this.ClientSize = new System.Drawing.Size(791, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.results);
            this.Name = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource borrowingDetailsBindingSource;
        private projectDataSetTableAdapters.Borrowing_DetailsTableAdapter borrowing_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}