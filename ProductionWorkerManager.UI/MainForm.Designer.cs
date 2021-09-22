namespace ProductionWorkerManager.UI
{
    partial class MainForm
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputEmployeeNameLabel = new System.Windows.Forms.Label();
            this.inputEmployeeNumberLabel = new System.Windows.Forms.Label();
            this.inputEmployeeShiftLabel = new System.Windows.Forms.Label();
            this.inputEmployeeHourlyRateLabel = new System.Windows.Forms.Label();
            this.inputEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.inputEmployeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.inputEmployeeShiftTextBox = new System.Windows.Forms.TextBox();
            this.inputEmployeeHourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputEmployeeHourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.outputEmployeeShiftTextBox = new System.Windows.Forms.TextBox();
            this.outputEmployeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.outputEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.outputEmployeeHourlyRateLabel = new System.Windows.Forms.Label();
            this.outputEmployeeShiftLabel = new System.Windows.Forms.Label();
            this.outputEmployeeNumberLabel = new System.Windows.Forms.Label();
            this.outputEmployeeNameLabel = new System.Windows.Forms.Label();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputEmployeeHourlyRateTextBox);
            this.inputGroupBox.Controls.Add(this.inputEmployeeShiftTextBox);
            this.inputGroupBox.Controls.Add(this.inputEmployeeNumberTextBox);
            this.inputGroupBox.Controls.Add(this.inputEmployeeNameTextBox);
            this.inputGroupBox.Controls.Add(this.inputEmployeeHourlyRateLabel);
            this.inputGroupBox.Controls.Add(this.inputEmployeeShiftLabel);
            this.inputGroupBox.Controls.Add(this.inputEmployeeNumberLabel);
            this.inputGroupBox.Controls.Add(this.inputEmployeeNameLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(258, 133);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter Employee Data";
            // 
            // inputEmployeeNameLabel
            // 
            this.inputEmployeeNameLabel.AutoSize = true;
            this.inputEmployeeNameLabel.Location = new System.Drawing.Point(43, 26);
            this.inputEmployeeNameLabel.Name = "inputEmployeeNameLabel";
            this.inputEmployeeNameLabel.Size = new System.Drawing.Size(38, 13);
            this.inputEmployeeNameLabel.TabIndex = 0;
            this.inputEmployeeNameLabel.Text = "Name:";
            // 
            // inputEmployeeNumberLabel
            // 
            this.inputEmployeeNumberLabel.AutoSize = true;
            this.inputEmployeeNumberLabel.Location = new System.Drawing.Point(34, 52);
            this.inputEmployeeNumberLabel.Name = "inputEmployeeNumberLabel";
            this.inputEmployeeNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.inputEmployeeNumberLabel.TabIndex = 1;
            this.inputEmployeeNumberLabel.Text = "Number:";
            // 
            // inputEmployeeShiftLabel
            // 
            this.inputEmployeeShiftLabel.AutoSize = true;
            this.inputEmployeeShiftLabel.Location = new System.Drawing.Point(50, 78);
            this.inputEmployeeShiftLabel.Name = "inputEmployeeShiftLabel";
            this.inputEmployeeShiftLabel.Size = new System.Drawing.Size(31, 13);
            this.inputEmployeeShiftLabel.TabIndex = 2;
            this.inputEmployeeShiftLabel.Text = "Shift:";
            // 
            // inputEmployeeHourlyRateLabel
            // 
            this.inputEmployeeHourlyRateLabel.AutoSize = true;
            this.inputEmployeeHourlyRateLabel.Location = new System.Drawing.Point(15, 104);
            this.inputEmployeeHourlyRateLabel.Name = "inputEmployeeHourlyRateLabel";
            this.inputEmployeeHourlyRateLabel.Size = new System.Drawing.Size(66, 13);
            this.inputEmployeeHourlyRateLabel.TabIndex = 3;
            this.inputEmployeeHourlyRateLabel.Text = "Hourly Rate:";
            // 
            // inputEmployeeNameTextBox
            // 
            this.inputEmployeeNameTextBox.Location = new System.Drawing.Point(87, 23);
            this.inputEmployeeNameTextBox.Name = "inputEmployeeNameTextBox";
            this.inputEmployeeNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.inputEmployeeNameTextBox.TabIndex = 4;
            // 
            // inputEmployeeNumberTextBox
            // 
            this.inputEmployeeNumberTextBox.Location = new System.Drawing.Point(87, 49);
            this.inputEmployeeNumberTextBox.Name = "inputEmployeeNumberTextBox";
            this.inputEmployeeNumberTextBox.Size = new System.Drawing.Size(159, 20);
            this.inputEmployeeNumberTextBox.TabIndex = 5;
            // 
            // inputEmployeeShiftTextBox
            // 
            this.inputEmployeeShiftTextBox.Location = new System.Drawing.Point(87, 75);
            this.inputEmployeeShiftTextBox.Name = "inputEmployeeShiftTextBox";
            this.inputEmployeeShiftTextBox.Size = new System.Drawing.Size(159, 20);
            this.inputEmployeeShiftTextBox.TabIndex = 6;
            // 
            // inputEmployeeHourlyRateTextBox
            // 
            this.inputEmployeeHourlyRateTextBox.Location = new System.Drawing.Point(87, 101);
            this.inputEmployeeHourlyRateTextBox.Name = "inputEmployeeHourlyRateTextBox";
            this.inputEmployeeHourlyRateTextBox.Size = new System.Drawing.Size(159, 20);
            this.inputEmployeeHourlyRateTextBox.TabIndex = 7;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputEmployeeHourlyRateTextBox);
            this.outputGroupBox.Controls.Add(this.outputEmployeeShiftTextBox);
            this.outputGroupBox.Controls.Add(this.outputEmployeeNumberTextBox);
            this.outputGroupBox.Controls.Add(this.outputEmployeeNameTextBox);
            this.outputGroupBox.Controls.Add(this.outputEmployeeHourlyRateLabel);
            this.outputGroupBox.Controls.Add(this.outputEmployeeShiftLabel);
            this.outputGroupBox.Controls.Add(this.outputEmployeeNumberLabel);
            this.outputGroupBox.Controls.Add(this.outputEmployeeNameLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 161);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(258, 133);
            this.outputGroupBox.TabIndex = 8;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Object Properties";
            // 
            // outputEmployeeHourlyRateTextBox
            // 
            this.outputEmployeeHourlyRateTextBox.Enabled = false;
            this.outputEmployeeHourlyRateTextBox.Location = new System.Drawing.Point(87, 101);
            this.outputEmployeeHourlyRateTextBox.Name = "outputEmployeeHourlyRateTextBox";
            this.outputEmployeeHourlyRateTextBox.ReadOnly = true;
            this.outputEmployeeHourlyRateTextBox.Size = new System.Drawing.Size(159, 20);
            this.outputEmployeeHourlyRateTextBox.TabIndex = 7;
            // 
            // outputEmployeeShiftTextBox
            // 
            this.outputEmployeeShiftTextBox.Enabled = false;
            this.outputEmployeeShiftTextBox.Location = new System.Drawing.Point(87, 75);
            this.outputEmployeeShiftTextBox.Name = "outputEmployeeShiftTextBox";
            this.outputEmployeeShiftTextBox.ReadOnly = true;
            this.outputEmployeeShiftTextBox.Size = new System.Drawing.Size(159, 20);
            this.outputEmployeeShiftTextBox.TabIndex = 6;
            // 
            // outputEmployeeNumberTextBox
            // 
            this.outputEmployeeNumberTextBox.Enabled = false;
            this.outputEmployeeNumberTextBox.Location = new System.Drawing.Point(87, 49);
            this.outputEmployeeNumberTextBox.Name = "outputEmployeeNumberTextBox";
            this.outputEmployeeNumberTextBox.ReadOnly = true;
            this.outputEmployeeNumberTextBox.Size = new System.Drawing.Size(159, 20);
            this.outputEmployeeNumberTextBox.TabIndex = 5;
            // 
            // outputEmployeeNameTextBox
            // 
            this.outputEmployeeNameTextBox.Enabled = false;
            this.outputEmployeeNameTextBox.Location = new System.Drawing.Point(87, 23);
            this.outputEmployeeNameTextBox.Name = "outputEmployeeNameTextBox";
            this.outputEmployeeNameTextBox.ReadOnly = true;
            this.outputEmployeeNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.outputEmployeeNameTextBox.TabIndex = 4;
            // 
            // outputEmployeeHourlyRateLabel
            // 
            this.outputEmployeeHourlyRateLabel.AutoSize = true;
            this.outputEmployeeHourlyRateLabel.Location = new System.Drawing.Point(15, 104);
            this.outputEmployeeHourlyRateLabel.Name = "outputEmployeeHourlyRateLabel";
            this.outputEmployeeHourlyRateLabel.Size = new System.Drawing.Size(66, 13);
            this.outputEmployeeHourlyRateLabel.TabIndex = 3;
            this.outputEmployeeHourlyRateLabel.Text = "Hourly Rate:";
            // 
            // outputEmployeeShiftLabel
            // 
            this.outputEmployeeShiftLabel.AutoSize = true;
            this.outputEmployeeShiftLabel.Location = new System.Drawing.Point(50, 78);
            this.outputEmployeeShiftLabel.Name = "outputEmployeeShiftLabel";
            this.outputEmployeeShiftLabel.Size = new System.Drawing.Size(31, 13);
            this.outputEmployeeShiftLabel.TabIndex = 2;
            this.outputEmployeeShiftLabel.Text = "Shift:";
            // 
            // outputEmployeeNumberLabel
            // 
            this.outputEmployeeNumberLabel.AutoSize = true;
            this.outputEmployeeNumberLabel.Location = new System.Drawing.Point(34, 52);
            this.outputEmployeeNumberLabel.Name = "outputEmployeeNumberLabel";
            this.outputEmployeeNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.outputEmployeeNumberLabel.TabIndex = 1;
            this.outputEmployeeNumberLabel.Text = "Number:";
            // 
            // outputEmployeeNameLabel
            // 
            this.outputEmployeeNameLabel.AutoSize = true;
            this.outputEmployeeNameLabel.Location = new System.Drawing.Point(43, 26);
            this.outputEmployeeNameLabel.Name = "outputEmployeeNameLabel";
            this.outputEmployeeNameLabel.Size = new System.Drawing.Size(38, 13);
            this.outputEmployeeNameLabel.TabIndex = 0;
            this.outputEmployeeNameLabel.Text = "Name:";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(12, 310);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(258, 43);
            this.createObjectButton.TabIndex = 9;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 370);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "MainForm";
            this.Text = "New Employee";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox inputEmployeeHourlyRateTextBox;
        private System.Windows.Forms.TextBox inputEmployeeShiftTextBox;
        private System.Windows.Forms.TextBox inputEmployeeNumberTextBox;
        private System.Windows.Forms.TextBox inputEmployeeNameTextBox;
        private System.Windows.Forms.Label inputEmployeeHourlyRateLabel;
        private System.Windows.Forms.Label inputEmployeeShiftLabel;
        private System.Windows.Forms.Label inputEmployeeNumberLabel;
        private System.Windows.Forms.Label inputEmployeeNameLabel;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.TextBox outputEmployeeHourlyRateTextBox;
        private System.Windows.Forms.TextBox outputEmployeeShiftTextBox;
        private System.Windows.Forms.TextBox outputEmployeeNumberTextBox;
        private System.Windows.Forms.TextBox outputEmployeeNameTextBox;
        private System.Windows.Forms.Label outputEmployeeHourlyRateLabel;
        private System.Windows.Forms.Label outputEmployeeShiftLabel;
        private System.Windows.Forms.Label outputEmployeeNumberLabel;
        private System.Windows.Forms.Label outputEmployeeNameLabel;
        private System.Windows.Forms.Button createObjectButton;
    }
}

