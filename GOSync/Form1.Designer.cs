namespace GOSync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenCsv = new System.Windows.Forms.Button();
            this.btnWriteContacts = new System.Windows.Forms.Button();
            this.LV = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.btnWriteAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOpenGoogleContacts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.llGitHubIssues = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenCsv
            // 
            this.btnOpenCsv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenCsv.Location = new System.Drawing.Point(94, 41);
            this.btnOpenCsv.Name = "btnOpenCsv";
            this.btnOpenCsv.Size = new System.Drawing.Size(258, 23);
            this.btnOpenCsv.TabIndex = 0;
            this.btnOpenCsv.Text = "2.   Read Contacts CSV Data...";
            this.btnOpenCsv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCsv.UseVisualStyleBackColor = true;
            this.btnOpenCsv.Click += new System.EventHandler(this.btnOpenCsv_Click);
            // 
            // btnWriteContacts
            // 
            this.btnWriteContacts.Location = new System.Drawing.Point(94, 70);
            this.btnWriteContacts.Name = "btnWriteContacts";
            this.btnWriteContacts.Size = new System.Drawing.Size(258, 23);
            this.btnWriteContacts.TabIndex = 1;
            this.btnWriteContacts.Text = "3a. Write Selected Item To Outlook Contacts";
            this.btnWriteContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteContacts.UseVisualStyleBackColor = true;
            this.btnWriteContacts.Click += new System.EventHandler(this.btnWriteContacts_Click);
            // 
            // LV
            // 
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.LV.FullRowSelect = true;
            this.LV.Location = new System.Drawing.Point(12, 157);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(1040, 281);
            this.LV.TabIndex = 2;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "#";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Middle Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birthday";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Notes";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-mail Address";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mobile Phone";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Company";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Other Phone";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Categories";
            this.columnHeader10.Width = 120;
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWriteAll.Location = new System.Drawing.Point(94, 99);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.Size = new System.Drawing.Size(258, 23);
            this.btnWriteAll.TabIndex = 3;
            this.btnWriteAll.Text = "3b. Write All Items To Outlook Contacts";
            this.btnWriteAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteAll.UseVisualStyleBackColor = true;
            this.btnWriteAll.Click += new System.EventHandler(this.btnWriteAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnOpenGoogleContacts
            // 
            this.btnOpenGoogleContacts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenGoogleContacts.Location = new System.Drawing.Point(94, 12);
            this.btnOpenGoogleContacts.Name = "btnOpenGoogleContacts";
            this.btnOpenGoogleContacts.Size = new System.Drawing.Size(258, 23);
            this.btnOpenGoogleContacts.TabIndex = 6;
            this.btnOpenGoogleContacts.Text = "1.   Export Contacts CSV in Google Mail";
            this.btnOpenGoogleContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenGoogleContacts.UseVisualStyleBackColor = true;
            this.btnOpenGoogleContacts.Click += new System.EventHandler(this.btnOpenGoogleContacts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "This button opens Google Contacts in your default browser. Click on \'Export\' in t" +
    "he left sidebar and download results.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Open the downloaded CSV file here and check the data in the list below.";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(94, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "4.   Check Contacts in Outlook";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Opens Outlook for final inspection. Please file an issue on GitHub if there are a" +
    "ny errors.";
            // 
            // llGitHubIssues
            // 
            this.llGitHubIssues.AutoSize = true;
            this.llGitHubIssues.Location = new System.Drawing.Point(831, 132);
            this.llGitHubIssues.Name = "llGitHubIssues";
            this.llGitHubIssues.Size = new System.Drawing.Size(79, 15);
            this.llGitHubIssues.TabIndex = 11;
            this.llGitHubIssues.TabStop = true;
            this.llGitHubIssues.Text = "GitHub Issues";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(978, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llGitHubIssues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenGoogleContacts);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWriteAll);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.btnWriteContacts);
            this.Controls.Add(this.btnOpenCsv);
            this.MinimumSize = new System.Drawing.Size(1080, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOSync";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenCsv;
        private Button btnWriteContacts;
        private ListView LV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button btnWriteAll;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnOpenGoogleContacts;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private LinkLabel llGitHubIssues;
        private LinkLabel linkLabel1;
    }
}