namespace WindowsForms_Homework_3
{
    partial class Form1
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
            this.newUserButton = new System.Windows.Forms.Button();
            this.carEnthusiastsListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carLicencePlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bodyNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.engineNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productionYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carMarkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.foundOwnerNames = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchCarMarkTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.saveResultsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newUserButton
            // 
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.Location = new System.Drawing.Point(12, 489);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(191, 65);
            this.newUserButton.TabIndex = 1;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // carEnthusiastsListBox
            // 
            this.carEnthusiastsListBox.FormattingEnabled = true;
            this.carEnthusiastsListBox.ItemHeight = 20;
            this.carEnthusiastsListBox.Location = new System.Drawing.Point(12, 12);
            this.carEnthusiastsListBox.Name = "carEnthusiastsListBox";
            this.carEnthusiastsListBox.Size = new System.Drawing.Size(230, 444);
            this.carEnthusiastsListBox.TabIndex = 2;
            this.carEnthusiastsListBox.SelectedIndexChanged += new System.EventHandler(this.carEnthusiastsListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Car Licence Plate Number";
            // 
            // carLicencePlateNumberTextBox
            // 
            this.carLicencePlateNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLicencePlateNumberTextBox.Location = new System.Drawing.Point(556, 336);
            this.carLicencePlateNumberTextBox.Name = "carLicencePlateNumberTextBox";
            this.carLicencePlateNumberTextBox.Size = new System.Drawing.Size(255, 32);
            this.carLicencePlateNumberTextBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Color";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(556, 279);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(255, 32);
            this.colorTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Body Number";
            // 
            // bodyNumberTextBox
            // 
            this.bodyNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyNumberTextBox.Location = new System.Drawing.Point(556, 221);
            this.bodyNumberTextBox.Name = "bodyNumberTextBox";
            this.bodyNumberTextBox.Size = new System.Drawing.Size(255, 32);
            this.bodyNumberTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "EngineNumber";
            // 
            // engineNumberTextBox
            // 
            this.engineNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineNumberTextBox.Location = new System.Drawing.Point(556, 158);
            this.engineNumberTextBox.Name = "engineNumberTextBox";
            this.engineNumberTextBox.Size = new System.Drawing.Size(255, 32);
            this.engineNumberTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Production Year";
            // 
            // productionYearTextBox
            // 
            this.productionYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionYearTextBox.Location = new System.Drawing.Point(556, 95);
            this.productionYearTextBox.Name = "productionYearTextBox";
            this.productionYearTextBox.Size = new System.Drawing.Size(255, 32);
            this.productionYearTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Car Mark";
            // 
            // carMarkTextBox
            // 
            this.carMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carMarkTextBox.Location = new System.Drawing.Point(556, 30);
            this.carMarkTextBox.Name = "carMarkTextBox";
            this.carMarkTextBox.Size = new System.Drawing.Size(255, 32);
            this.carMarkTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Owner";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerTextBox.Location = new System.Drawing.Point(556, 397);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(255, 32);
            this.ownerTextBox.TabIndex = 14;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(219, 489);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(190, 65);
            this.saveChangesButton.TabIndex = 28;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(435, 489);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 65);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete User";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.foundOwnerNames);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.searchCarMarkTextBox);
            this.groupBox1.Location = new System.Drawing.Point(858, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 492);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(111, 114);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 40);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // foundOwnerNames
            // 
            this.foundOwnerNames.FormattingEnabled = true;
            this.foundOwnerNames.ItemHeight = 20;
            this.foundOwnerNames.Location = new System.Drawing.Point(21, 162);
            this.foundOwnerNames.Name = "foundOwnerNames";
            this.foundOwnerNames.Size = new System.Drawing.Size(328, 244);
            this.foundOwnerNames.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Car Mark";
            // 
            // searchCarMarkTextBox
            // 
            this.searchCarMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCarMarkTextBox.Location = new System.Drawing.Point(123, 59);
            this.searchCarMarkTextBox.Name = "searchCarMarkTextBox";
            this.searchCarMarkTextBox.Size = new System.Drawing.Size(226, 32);
            this.searchCarMarkTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Count";
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTextBox.Location = new System.Drawing.Point(111, 436);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(226, 32);
            this.countTextBox.TabIndex = 23;
            // 
            // saveResultsButton
            // 
            this.saveResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveResultsButton.Location = new System.Drawing.Point(648, 489);
            this.saveResultsButton.Name = "saveResultsButton";
            this.saveResultsButton.Size = new System.Drawing.Size(190, 65);
            this.saveResultsButton.TabIndex = 31;
            this.saveResultsButton.Text = "Save Results";
            this.saveResultsButton.UseVisualStyleBackColor = true;
            this.saveResultsButton.Click += new System.EventHandler(this.saveResultsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 574);
            this.Controls.Add(this.saveResultsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.carLicencePlateNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bodyNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.engineNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productionYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carMarkTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.carEnthusiastsListBox);
            this.Controls.Add(this.newUserButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.ListBox carEnthusiastsListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox carLicencePlateNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bodyNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox engineNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productionYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carMarkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchCarMarkTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox foundOwnerNames;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveResultsButton;
    }
}

