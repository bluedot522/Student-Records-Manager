namespace Module7JsonStudentRecords
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
            txtSearch = new TextBox();
            comboProgram = new ComboBox();
            nudMinimumGpa = new NumericUpDown();
            btnShowAll = new Button();
            btnSortGpa = new Button();
            btnSearch = new Button();
            btnSummary = new Button();
            dgvStudents = new DataGridView();
            lblProgram = new Label();
            lblGpa = new Label();
            lblidOrName = new Label();
            btnQuit = new Button();
            btnFilterProgram = new Button();
            btnFilterGpa = new Button();
            btnSortName = new Button();
            lblResults = new Label();
            btnUnderGpaByProgram = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMinimumGpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(145, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 23);
            txtSearch.TabIndex = 1;
            // 
            // comboProgram
            // 
            comboProgram.FormattingEnabled = true;
            comboProgram.Items.AddRange(new object[] { "Accounting", "Agriculture", "Aviation", "Biology", "Building Construction", "Business", "Chemistry", "Computer Science", "Criminal Justice", "Culinary Arts", "Cybersecurity", "Data Analytics", "Dental Hygeine", "Design", "Education", "Electrical Engineering", "Entrepreneurship", "Fine Arts", "General", "Health", "Informatics", "Interior Design", "Legal", "Liberal Arts", "Manufacturing", "Nursing", "Psychology", "Software Development", "Veterinary Nursing", "Visual Communications" });
            comboProgram.Location = new Point(87, 26);
            comboProgram.Name = "comboProgram";
            comboProgram.Size = new Size(151, 23);
            comboProgram.TabIndex = 2;
            // 
            // nudMinimumGpa
            // 
            nudMinimumGpa.DecimalPlaces = 1;
            nudMinimumGpa.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMinimumGpa.Location = new Point(358, 26);
            nudMinimumGpa.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudMinimumGpa.Name = "nudMinimumGpa";
            nudMinimumGpa.Size = new Size(48, 23);
            nudMinimumGpa.TabIndex = 4;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(25, 133);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(86, 31);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSortGpa
            // 
            btnSortGpa.Location = new Point(154, 181);
            btnSortGpa.Name = "btnSortGpa";
            btnSortGpa.Size = new Size(104, 31);
            btnSortGpa.TabIndex = 6;
            btnSortGpa.Text = "Sort By GPA";
            btnSortGpa.UseVisualStyleBackColor = true;
            btnSortGpa.Click += btnSortGpa_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(264, 433);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 28);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(358, 133);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(73, 31);
            btnSummary.TabIndex = 8;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(25, 247);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(423, 167);
            dgvStudents.TabIndex = 9;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(25, 29);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(56, 15);
            lblProgram.TabIndex = 1;
            lblProgram.Text = "Program:";
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(264, 29);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(88, 15);
            lblGpa.TabIndex = 3;
            lblGpa.Text = "Minimum GPA:";
            // 
            // lblidOrName
            // 
            lblidOrName.AutoSize = true;
            lblidOrName.Location = new Point(25, 79);
            lblidOrName.Name = "lblidOrName";
            lblidOrName.Size = new Size(114, 15);
            lblidOrName.TabIndex = 5;
            lblidOrName.Text = "Student ID or Name:";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(373, 433);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 28);
            btnQuit.TabIndex = 16;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnFilterProgram
            // 
            btnFilterProgram.Location = new Point(129, 133);
            btnFilterProgram.Name = "btnFilterProgram";
            btnFilterProgram.Size = new Size(104, 31);
            btnFilterProgram.TabIndex = 17;
            btnFilterProgram.Text = "Filter Program";
            btnFilterProgram.UseVisualStyleBackColor = true;
            btnFilterProgram.Click += btnFilterProgram_Click;
            // 
            // btnFilterGpa
            // 
            btnFilterGpa.Location = new Point(249, 133);
            btnFilterGpa.Name = "btnFilterGpa";
            btnFilterGpa.Size = new Size(94, 31);
            btnFilterGpa.TabIndex = 18;
            btnFilterGpa.Text = "Filter GPA";
            btnFilterGpa.UseVisualStyleBackColor = true;
            btnFilterGpa.Click += btnFilterGpa_Click;
            // 
            // btnSortName
            // 
            btnSortName.Location = new Point(25, 181);
            btnSortName.Name = "btnSortName";
            btnSortName.Size = new Size(114, 31);
            btnSortName.TabIndex = 19;
            btnSortName.Text = "Sort By Last Name";
            btnSortName.UseVisualStyleBackColor = true;
            btnSortName.Click += btnSortName_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(25, 433);
            lblResults.MaximumSize = new Size(300, 0);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(38, 15);
            lblResults.TabIndex = 20;
            lblResults.Text = "label1";
            // 
            // btnUnderGpaByProgram
            // 
            btnUnderGpaByProgram.Location = new Point(274, 181);
            btnUnderGpaByProgram.Name = "btnUnderGpaByProgram";
            btnUnderGpaByProgram.Size = new Size(157, 31);
            btnUnderGpaByProgram.TabIndex = 21;
            btnUnderGpaByProgram.Text = "Under X GPA By Program";
            btnUnderGpaByProgram.UseVisualStyleBackColor = true;
            btnUnderGpaByProgram.Click += btnUnderGpaByProgram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 508);
            Controls.Add(btnUnderGpaByProgram);
            Controls.Add(lblResults);
            Controls.Add(btnSortName);
            Controls.Add(btnFilterGpa);
            Controls.Add(btnFilterProgram);
            Controls.Add(btnQuit);
            Controls.Add(lblidOrName);
            Controls.Add(lblGpa);
            Controls.Add(lblProgram);
            Controls.Add(dgvStudents);
            Controls.Add(btnSummary);
            Controls.Add(btnSearch);
            Controls.Add(btnSortGpa);
            Controls.Add(btnShowAll);
            Controls.Add(nudMinimumGpa);
            Controls.Add(comboProgram);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMinimumGpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudStudentId;
        private TextBox txtSearch;
        private TextBox txtLastName;
        private ComboBox comboProgram;
        private NumericUpDown nudMinimumGpa;
        private Button btnShowAll;
        private Button btnSortGpa;
        private Button btnSearch;
        private Button btnSummary;
        private DataGridView dgvStudents;
        private Label lblProgram;
        private Label lblGpa;
        private Label lblidOrName;
        private Button btnQuit;
        private Button btnFilterProgram;
        private Button btnFilterGpa;
        private Button btnSortName;
        private Label lblResults;
        private Button btnUnderGpaByProgram;
    }
}
