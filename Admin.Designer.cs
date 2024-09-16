namespace DataBaseProject
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bOOK_IDLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label pUBLISHER_IDLabel;
            System.Windows.Forms.Label aUTHOR_IDLabel;
            System.Windows.Forms.Label cATEGORYLabel;
            System.Windows.Forms.Label tITLELabel;
            System.Windows.Forms.Label cOPY_NUMBERLabel;
            System.Windows.Forms.Label aUTHOR_NAMELabel;
            System.Windows.Forms.Label pUBLISHER_NAMELabel;
            this.Add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.projectDataSet = new DataBaseProject.projectDataSet();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new DataBaseProject.projectDataSetTableAdapters.AUTHORTableAdapter();
            this.aUTHORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new DataBaseProject.projectDataSetTableAdapters.BOOKTableAdapter();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DataBaseProject.projectDataSetTableAdapters.TableAdapterManager();
            this.cOPYTableAdapter = new DataBaseProject.projectDataSetTableAdapters.COPYTableAdapter();
            this.pUBLISHERTableAdapter = new DataBaseProject.projectDataSetTableAdapters.PUBLISHERTableAdapter();
            this.bOOK_IDTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.pUBLISHER_IDTextBox = new System.Windows.Forms.TextBox();
            this.aUTHOR_IDTextBox = new System.Windows.Forms.TextBox();
            this.cATEGORYTextBox = new System.Windows.Forms.TextBox();
            this.tITLETextBox = new System.Windows.Forms.TextBox();
            this.cOPYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOPY_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.aUTHORBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHOR_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHER_NAMETextBox = new System.Windows.Forms.TextBox();
            this.bOOKBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.results = new System.Windows.Forms.DataGridView();
            this.projectDataSet1 = new DataBaseProject.projectDataSet1();
            this.bOOKBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter1 = new DataBaseProject.projectDataSet1TableAdapters.BOOKTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.report_btn = new System.Windows.Forms.Button();
            this.user_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            bOOK_IDLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            pUBLISHER_IDLabel = new System.Windows.Forms.Label();
            aUTHOR_IDLabel = new System.Windows.Forms.Label();
            cATEGORYLabel = new System.Windows.Forms.Label();
            tITLELabel = new System.Windows.Forms.Label();
            cOPY_NUMBERLabel = new System.Windows.Forms.Label();
            aUTHOR_NAMELabel = new System.Windows.Forms.Label();
            pUBLISHER_NAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOPYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // bOOK_IDLabel
            // 
            bOOK_IDLabel.AutoSize = true;
            bOOK_IDLabel.Location = new System.Drawing.Point(74, 45);
            bOOK_IDLabel.Name = "bOOK_IDLabel";
            bOOK_IDLabel.Size = new System.Drawing.Size(62, 17);
            bOOK_IDLabel.TabIndex = 5;
            bOOK_IDLabel.Text = "BOOK ID:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(74, 76);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(38, 17);
            iSBNLabel.TabIndex = 7;
            iSBNLabel.Text = "ISBN:";
            // 
            // pUBLISHER_IDLabel
            // 
            pUBLISHER_IDLabel.AutoSize = true;
            pUBLISHER_IDLabel.Location = new System.Drawing.Point(74, 107);
            pUBLISHER_IDLabel.Name = "pUBLISHER_IDLabel";
            pUBLISHER_IDLabel.Size = new System.Drawing.Size(90, 17);
            pUBLISHER_IDLabel.TabIndex = 9;
            pUBLISHER_IDLabel.Text = "PUBLISHER ID:";
            // 
            // aUTHOR_IDLabel
            // 
            aUTHOR_IDLabel.AutoSize = true;
            aUTHOR_IDLabel.Location = new System.Drawing.Point(74, 138);
            aUTHOR_IDLabel.Name = "aUTHOR_IDLabel";
            aUTHOR_IDLabel.Size = new System.Drawing.Size(78, 17);
            aUTHOR_IDLabel.TabIndex = 11;
            aUTHOR_IDLabel.Text = "AUTHOR ID:";
            // 
            // cATEGORYLabel
            // 
            cATEGORYLabel.AutoSize = true;
            cATEGORYLabel.Location = new System.Drawing.Point(74, 169);
            cATEGORYLabel.Name = "cATEGORYLabel";
            cATEGORYLabel.Size = new System.Drawing.Size(75, 17);
            cATEGORYLabel.TabIndex = 13;
            cATEGORYLabel.Text = "CATEGORY:";
            // 
            // tITLELabel
            // 
            tITLELabel.AutoSize = true;
            tITLELabel.Location = new System.Drawing.Point(74, 200);
            tITLELabel.Name = "tITLELabel";
            tITLELabel.Size = new System.Drawing.Size(41, 17);
            tITLELabel.TabIndex = 15;
            tITLELabel.Text = "TITLE:";
            // 
            // cOPY_NUMBERLabel
            // 
            cOPY_NUMBERLabel.AutoSize = true;
            cOPY_NUMBERLabel.Location = new System.Drawing.Point(64, 231);
            cOPY_NUMBERLabel.Name = "cOPY_NUMBERLabel";
            cOPY_NUMBERLabel.Size = new System.Drawing.Size(100, 17);
            cOPY_NUMBERLabel.TabIndex = 17;
            cOPY_NUMBERLabel.Text = "COPY NUMBER:";
            // 
            // aUTHOR_NAMELabel
            // 
            aUTHOR_NAMELabel.AutoSize = true;
            aUTHOR_NAMELabel.Location = new System.Drawing.Point(61, 268);
            aUTHOR_NAMELabel.Name = "aUTHOR_NAMELabel";
            aUTHOR_NAMELabel.Size = new System.Drawing.Size(103, 17);
            aUTHOR_NAMELabel.TabIndex = 19;
            aUTHOR_NAMELabel.Text = "AUTHOR NAME:";
            // 
            // pUBLISHER_NAMELabel
            // 
            pUBLISHER_NAMELabel.AutoSize = true;
            pUBLISHER_NAMELabel.Location = new System.Drawing.Point(49, 308);
            pUBLISHER_NAMELabel.Name = "pUBLISHER_NAMELabel";
            pUBLISHER_NAMELabel.Size = new System.Drawing.Size(115, 17);
            pUBLISHER_NAMELabel.TabIndex = 21;
            pUBLISHER_NAMELabel.Text = "PUBLISHER NAME:";
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(170, 383);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(114, 38);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(400, 383);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 38);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(653, 383);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(104, 38);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // aUTHORBindingSource1
            // 
            this.aUTHORBindingSource1.DataMember = "AUTHOR";
            this.aUTHORBindingSource1.DataSource = this.projectDataSetBindingSource;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.projectDataSetBindingSource;
            // 
            // projectDataSetBindingSource1
            // 
            this.projectDataSetBindingSource1.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource1.Position = 0;
            // 
            // bOOKBindingSource2
            // 
            this.bOOKBindingSource2.DataMember = "BOOK";
            this.bOOKBindingSource2.DataSource = this.projectDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTHENTICATION_SYSTEMTableAdapter = null;
            this.tableAdapterManager.AUTHORTableAdapter = this.aUTHORTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = this.bOOKTableAdapter;
            this.tableAdapterManager.Borrowing_DetailsTableAdapter = null;
            this.tableAdapterManager.CATEGORIESTableAdapter = null;
            this.tableAdapterManager.COPYTableAdapter = this.cOPYTableAdapter;
            this.tableAdapterManager.PUBLISHERTableAdapter = this.pUBLISHERTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBaseProject.projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERRTableAdapter = null;
            // 
            // cOPYTableAdapter
            // 
            this.cOPYTableAdapter.ClearBeforeFill = true;
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // bOOK_IDTextBox
            // 
            this.bOOK_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKBindingSource2, "BOOK_ID", true));
            this.bOOK_IDTextBox.Location = new System.Drawing.Point(170, 42);
            this.bOOK_IDTextBox.Name = "bOOK_IDTextBox";
            this.bOOK_IDTextBox.Size = new System.Drawing.Size(100, 25);
            this.bOOK_IDTextBox.TabIndex = 6;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKBindingSource2, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(170, 73);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 25);
            this.iSBNTextBox.TabIndex = 8;
            // 
            // pUBLISHER_IDTextBox
            // 
            this.pUBLISHER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKBindingSource2, "PUBLISHER_ID", true));
            this.pUBLISHER_IDTextBox.Location = new System.Drawing.Point(170, 104);
            this.pUBLISHER_IDTextBox.Name = "pUBLISHER_IDTextBox";
            this.pUBLISHER_IDTextBox.Size = new System.Drawing.Size(100, 25);
            this.pUBLISHER_IDTextBox.TabIndex = 10;
            // 
            // aUTHOR_IDTextBox
            // 
            this.aUTHOR_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKBindingSource2, "AUTHOR_ID", true));
            this.aUTHOR_IDTextBox.Location = new System.Drawing.Point(170, 135);
            this.aUTHOR_IDTextBox.Name = "aUTHOR_IDTextBox";
            this.aUTHOR_IDTextBox.Size = new System.Drawing.Size(100, 25);
            this.aUTHOR_IDTextBox.TabIndex = 12;
            // 
            // cATEGORYTextBox
            // 
            this.cATEGORYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKBindingSource2, "CATEGORY", true));
            this.cATEGORYTextBox.Location = new System.Drawing.Point(170, 166);
            this.cATEGORYTextBox.Name = "cATEGORYTextBox";
            this.cATEGORYTextBox.Size = new System.Drawing.Size(100, 25);
            this.cATEGORYTextBox.TabIndex = 14;
            // 
            // tITLETextBox
            // 
            this.tITLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKBindingSource2, "TITLE", true));
            this.tITLETextBox.Location = new System.Drawing.Point(170, 197);
            this.tITLETextBox.Name = "tITLETextBox";
            this.tITLETextBox.Size = new System.Drawing.Size(100, 25);
            this.tITLETextBox.TabIndex = 16;
            // 
            // cOPYBindingSource
            // 
            this.cOPYBindingSource.DataMember = "COPY";
            this.cOPYBindingSource.DataSource = this.projectDataSet;
            // 
            // cOPY_NUMBERTextBox
            // 
            this.cOPY_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOPYBindingSource, "COPY_NUMBER", true));
            this.cOPY_NUMBERTextBox.Location = new System.Drawing.Point(170, 228);
            this.cOPY_NUMBERTextBox.Name = "cOPY_NUMBERTextBox";
            this.cOPY_NUMBERTextBox.Size = new System.Drawing.Size(100, 25);
            this.cOPY_NUMBERTextBox.TabIndex = 18;
            // 
            // aUTHORBindingSource2
            // 
            this.aUTHORBindingSource2.DataMember = "AUTHOR";
            this.aUTHORBindingSource2.DataSource = this.projectDataSet;
            // 
            // aUTHOR_NAMETextBox
            // 
            this.aUTHOR_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUTHORBindingSource2, "AUTHOR_NAME", true));
            this.aUTHOR_NAMETextBox.Location = new System.Drawing.Point(170, 265);
            this.aUTHOR_NAMETextBox.Name = "aUTHOR_NAMETextBox";
            this.aUTHOR_NAMETextBox.Size = new System.Drawing.Size(100, 25);
            this.aUTHOR_NAMETextBox.TabIndex = 20;
            // 
            // pUBLISHERBindingSource
            // 
            this.pUBLISHERBindingSource.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource.DataSource = this.projectDataSet;
            // 
            // pUBLISHER_NAMETextBox
            // 
            this.pUBLISHER_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pUBLISHERBindingSource, "PUBLISHER_NAME", true));
            this.pUBLISHER_NAMETextBox.Location = new System.Drawing.Point(170, 305);
            this.pUBLISHER_NAMETextBox.Name = "pUBLISHER_NAMETextBox";
            this.pUBLISHER_NAMETextBox.Size = new System.Drawing.Size(100, 25);
            this.pUBLISHER_NAMETextBox.TabIndex = 22;
            // 
            // bOOKBindingSource3
            // 
            this.bOOKBindingSource3.DataMember = "BOOK";
            this.bOOKBindingSource3.DataSource = this.projectDataSetBindingSource1;
            // 
            // results
            // 
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Location = new System.Drawing.Point(305, 138);
            this.results.Name = "results";
            this.results.RowHeadersWidth = 51;
            this.results.RowTemplate.Height = 24;
            this.results.Size = new System.Drawing.Size(700, 205);
            this.results.TabIndex = 23;
            this.results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellContentClick);
            // 
            // projectDataSet1
            // 
            this.projectDataSet1.DataSetName = "projectDataSet1";
            this.projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource4
            // 
            this.bOOKBindingSource4.DataMember = "BOOK";
            this.bOOKBindingSource4.DataSource = this.projectDataSet1;
            // 
            // bOOKTableAdapter1
            // 
            this.bOOKTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "TO DELETE YOU MUST FILL THE ID OF DESIRED FEILD OR CATEGORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "TO ADD BOOK FILL ALL THE IDS, CATEGORY, TITLE, COPY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "TO ADD PUBLISHER OR AUTHOR ADD NAME AND ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "TO UPDATE YOU NEED TO PROVIDE THE IDS FOR THE CORRESPONDING ITEM";
            // 
            // report_btn
            // 
            this.report_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.Location = new System.Drawing.Point(856, 383);
            this.report_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(104, 38);
            this.report_btn.TabIndex = 28;
            this.report_btn.Text = "Report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.Location = new System.Drawing.Point(880, 6);
            this.user_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(141, 38);
            this.user_btn.TabIndex = 29;
            this.user_btn.Text = "USERNAME";
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 34);
            this.label5.TabIndex = 30;
            this.label5.Text = "click on the username to log out\r\n\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(pUBLISHER_NAMELabel);
            this.Controls.Add(this.pUBLISHER_NAMETextBox);
            this.Controls.Add(aUTHOR_NAMELabel);
            this.Controls.Add(this.aUTHOR_NAMETextBox);
            this.Controls.Add(cOPY_NUMBERLabel);
            this.Controls.Add(this.cOPY_NUMBERTextBox);
            this.Controls.Add(bOOK_IDLabel);
            this.Controls.Add(this.bOOK_IDTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(pUBLISHER_IDLabel);
            this.Controls.Add(this.pUBLISHER_IDTextBox);
            this.Controls.Add(aUTHOR_IDLabel);
            this.Controls.Add(this.aUTHOR_IDTextBox);
            this.Controls.Add(cATEGORYLabel);
            this.Controls.Add(this.cATEGORYTextBox);
            this.Controls.Add(tITLELabel);
            this.Controls.Add(this.tITLETextBox);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOPYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private projectDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBindingSource1;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private projectDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.BindingSource bOOKBindingSource2;
        private projectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private projectDataSetTableAdapters.COPYTableAdapter cOPYTableAdapter;
        private System.Windows.Forms.TextBox bOOK_IDTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox pUBLISHER_IDTextBox;
        private System.Windows.Forms.TextBox aUTHOR_IDTextBox;
        private System.Windows.Forms.TextBox cATEGORYTextBox;
        private System.Windows.Forms.TextBox tITLETextBox;
        private System.Windows.Forms.BindingSource cOPYBindingSource;
        private System.Windows.Forms.TextBox cOPY_NUMBERTextBox;
        private System.Windows.Forms.BindingSource aUTHORBindingSource2;
        private System.Windows.Forms.TextBox aUTHOR_NAMETextBox;
        private projectDataSetTableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private System.Windows.Forms.TextBox pUBLISHER_NAMETextBox;
        private System.Windows.Forms.BindingSource bOOKBindingSource3;
        private System.Windows.Forms.DataGridView results;
        private projectDataSet1 projectDataSet1;
        private System.Windows.Forms.BindingSource bOOKBindingSource4;
        private projectDataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Label label5;
    }
}