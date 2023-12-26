namespace BayesPapers
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWordsFrequency = new System.Windows.Forms.Button();
            this.buttonEffectiveWords = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.dataGridViewKeywordsAvailability = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKeyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailabilty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailability2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCalculateError = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTestFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonCalculateTestFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProbability1 = new System.Windows.Forms.Label();
            this.labelProbability2 = new System.Windows.Forms.Label();
            this.labelSelectedCategory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeywordsAvailability)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1101, 619);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewKeywordsAvailability);
            this.groupBox1.Controls.Add(this.buttonTrain);
            this.groupBox1.Controls.Add(this.buttonEffectiveWords);
            this.groupBox1.Controls.Add(this.buttonWordsFrequency);
            this.groupBox1.Location = new System.Drawing.Point(711, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train";
            // 
            // buttonWordsFrequency
            // 
            this.buttonWordsFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWordsFrequency.Location = new System.Drawing.Point(208, 20);
            this.buttonWordsFrequency.Name = "buttonWordsFrequency";
            this.buttonWordsFrequency.Size = new System.Drawing.Size(164, 23);
            this.buttonWordsFrequency.TabIndex = 0;
            this.buttonWordsFrequency.Text = "1- محاسبه فراوانی کلمات";
            this.buttonWordsFrequency.UseVisualStyleBackColor = true;
            this.buttonWordsFrequency.Click += new System.EventHandler(this.buttonWordsFrequency_Click);
            // 
            // buttonEffectiveWords
            // 
            this.buttonEffectiveWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEffectiveWords.Location = new System.Drawing.Point(6, 20);
            this.buttonEffectiveWords.Name = "buttonEffectiveWords";
            this.buttonEffectiveWords.Size = new System.Drawing.Size(196, 23);
            this.buttonEffectiveWords.TabIndex = 1;
            this.buttonEffectiveWords.Text = "2- محاسبه کلمات موثر";
            this.buttonEffectiveWords.UseVisualStyleBackColor = true;
            this.buttonEffectiveWords.Click += new System.EventHandler(this.buttonEffectiveWords_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTrain.Location = new System.Drawing.Point(6, 49);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(366, 23);
            this.buttonTrain.TabIndex = 2;
            this.buttonTrain.Text = "3- آموزش";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // dataGridViewKeywordsAvailability
            // 
            this.dataGridViewKeywordsAvailability.AllowUserToAddRows = false;
            this.dataGridViewKeywordsAvailability.AllowUserToDeleteRows = false;
            this.dataGridViewKeywordsAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKeywordsAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeywordsAvailability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnKeyword,
            this.ColumnAvailabilty1,
            this.ColumnAvailability2});
            this.dataGridViewKeywordsAvailability.Location = new System.Drawing.Point(6, 109);
            this.dataGridViewKeywordsAvailability.Name = "dataGridViewKeywordsAvailability";
            this.dataGridViewKeywordsAvailability.ReadOnly = true;
            this.dataGridViewKeywordsAvailability.Size = new System.Drawing.Size(366, 480);
            this.dataGridViewKeywordsAvailability.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "مقادیر آموزش کلمات کلیدی موثر";
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.DataPropertyName = "Index";
            this.ColumnIndex.HeaderText = "#";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Width = 30;
            // 
            // ColumnKeyword
            // 
            this.ColumnKeyword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnKeyword.DataPropertyName = "Keyword";
            this.ColumnKeyword.HeaderText = "Keyword";
            this.ColumnKeyword.Name = "ColumnKeyword";
            this.ColumnKeyword.ReadOnly = true;
            // 
            // ColumnAvailabilty1
            // 
            this.ColumnAvailabilty1.DataPropertyName = "Availability1";
            this.ColumnAvailabilty1.HeaderText = "Class 1";
            this.ColumnAvailabilty1.Name = "ColumnAvailabilty1";
            this.ColumnAvailabilty1.ReadOnly = true;
            this.ColumnAvailabilty1.Width = 50;
            // 
            // ColumnAvailability2
            // 
            this.ColumnAvailability2.DataPropertyName = "Availability2";
            this.ColumnAvailability2.HeaderText = "Class 2";
            this.ColumnAvailability2.Name = "ColumnAvailability2";
            this.ColumnAvailability2.ReadOnly = true;
            this.ColumnAvailability2.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelSelectedCategory);
            this.groupBox2.Controls.Add(this.labelProbability2);
            this.groupBox2.Controls.Add(this.labelProbability1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonCalculateTestFile);
            this.groupBox2.Controls.Add(this.buttonBrowse);
            this.groupBox2.Controls.Add(this.textBoxTestFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelError);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonCalculateError);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 595);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // buttonCalculateError
            // 
            this.buttonCalculateError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculateError.Location = new System.Drawing.Point(14, 20);
            this.buttonCalculateError.Name = "buttonCalculateError";
            this.buttonCalculateError.Size = new System.Drawing.Size(97, 52);
            this.buttonCalculateError.TabIndex = 0;
            this.buttonCalculateError.Text = "محاسبه خطا";
            this.buttonCalculateError.UseVisualStyleBackColor = true;
            this.buttonCalculateError.Click += new System.EventHandler(this.buttonCalculateError_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 40);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "مقدار خطا:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(181, 40);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(11, 13);
            this.labelError.TabIndex = 2;
            this.labelError.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "فایل تست:";
            // 
            // textBoxTestFile
            // 
            this.textBoxTestFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestFile.Location = new System.Drawing.Point(121, 117);
            this.textBoxTestFile.Name = "textBoxTestFile";
            this.textBoxTestFile.ReadOnly = true;
            this.textBoxTestFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTestFile.Size = new System.Drawing.Size(494, 21);
            this.textBoxTestFile.TabIndex = 4;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(14, 117);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(97, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonCalculateTestFile
            // 
            this.buttonCalculateTestFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculateTestFile.Location = new System.Drawing.Point(15, 146);
            this.buttonCalculateTestFile.Name = "buttonCalculateTestFile";
            this.buttonCalculateTestFile.Size = new System.Drawing.Size(97, 61);
            this.buttonCalculateTestFile.TabIndex = 6;
            this.buttonCalculateTestFile.Text = "بررسی فایل";
            this.buttonCalculateTestFile.UseVisualStyleBackColor = true;
            this.buttonCalculateTestFile.Click += new System.EventHandler(this.buttonCalculateTestFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 163);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "احتمال دسته 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 187);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "احتمال دسته 2:";
            // 
            // labelProbability1
            // 
            this.labelProbability1.AutoSize = true;
            this.labelProbability1.ForeColor = System.Drawing.Color.Blue;
            this.labelProbability1.Location = new System.Drawing.Point(204, 163);
            this.labelProbability1.Name = "labelProbability1";
            this.labelProbability1.Size = new System.Drawing.Size(11, 13);
            this.labelProbability1.TabIndex = 9;
            this.labelProbability1.Text = "-";
            // 
            // labelProbability2
            // 
            this.labelProbability2.AutoSize = true;
            this.labelProbability2.ForeColor = System.Drawing.Color.Blue;
            this.labelProbability2.Location = new System.Drawing.Point(204, 187);
            this.labelProbability2.Name = "labelProbability2";
            this.labelProbability2.Size = new System.Drawing.Size(11, 13);
            this.labelProbability2.TabIndex = 10;
            this.labelProbability2.Text = "-";
            // 
            // labelSelectedCategory
            // 
            this.labelSelectedCategory.AutoSize = true;
            this.labelSelectedCategory.ForeColor = System.Drawing.Color.Green;
            this.labelSelectedCategory.Location = new System.Drawing.Point(204, 232);
            this.labelSelectedCategory.Name = "labelSelectedCategory";
            this.labelSelectedCategory.Size = new System.Drawing.Size(11, 13);
            this.labelSelectedCategory.TabIndex = 11;
            this.labelSelectedCategory.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 232);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "دسته انتخابی:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 619);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دسته بندی مقالات";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeywordsAvailability)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWordsFrequency;
        private System.Windows.Forms.Button buttonEffectiveWords;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKeywordsAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailabilty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailability2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCalculateError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSelectedCategory;
        private System.Windows.Forms.Label labelProbability2;
        private System.Windows.Forms.Label labelProbability1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculateTestFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxTestFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

