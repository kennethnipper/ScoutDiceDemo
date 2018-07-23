namespace ScoutDemoDice
{
    partial class ScoutDemoDice
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
            this.NumberOfSidesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfDiceComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NumberOfSidesComboBox
            // 
            this.NumberOfSidesComboBox.FormattingEnabled = true;
            this.NumberOfSidesComboBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12",
            "20"});
            this.NumberOfSidesComboBox.Location = new System.Drawing.Point(137, 34);
            this.NumberOfSidesComboBox.Name = "NumberOfSidesComboBox";
            this.NumberOfSidesComboBox.Size = new System.Drawing.Size(121, 24);
            this.NumberOfSidesComboBox.TabIndex = 0;
            this.NumberOfSidesComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberOfSidesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many sides?";
            // 
            // RoleButton
            // 
            this.RoleButton.Location = new System.Drawing.Point(182, 64);
            this.RoleButton.Name = "RoleButton";
            this.RoleButton.Size = new System.Drawing.Size(75, 23);
            this.RoleButton.TabIndex = 2;
            this.RoleButton.Text = "Roll";
            this.RoleButton.UseVisualStyleBackColor = true;
            this.RoleButton.Click += new System.EventHandler(this.RoleButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.HorizontalScrollbar = true;
            this.ResultsListBox.ItemHeight = 16;
            this.ResultsListBox.Location = new System.Drawing.Point(74, 116);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(545, 260);
            this.ResultsListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Results";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(311, 64);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many dice?";
            // 
            // NumberOfDiceComboBox
            // 
            this.NumberOfDiceComboBox.FormattingEnabled = true;
            this.NumberOfDiceComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.NumberOfDiceComboBox.Location = new System.Drawing.Point(392, 34);
            this.NumberOfDiceComboBox.Name = "NumberOfDiceComboBox";
            this.NumberOfDiceComboBox.Size = new System.Drawing.Size(121, 24);
            this.NumberOfDiceComboBox.TabIndex = 7;
            // 
            // ScoutDemoDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 407);
            this.Controls.Add(this.NumberOfDiceComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.RoleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfSidesComboBox);
            this.Name = "ScoutDemoDice";
            this.Text = "Scout Demo Dice";
            this.Load += new System.EventHandler(this.ScoutDemoDice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumberOfSidesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RoleButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NumberOfDiceComboBox;
    }
}

