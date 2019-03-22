﻿namespace ToolTip_Demo
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
            this.components = new System.ComponentModel.Container();
            this.calcButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.descriptionGrossPayLabel = new System.Windows.Forms.Label();
            this.promptPayRateLabel = new System.Windows.Forms.Label();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.promptHoursWorkedLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(114, 141);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 36);
            this.calcButton.TabIndex = 34;
            this.calcButton.Text = "Calculate Gross Pay";
            this.toolTip1.SetToolTip(this.calcButton, "Click to calculate gross pay.");
            this.calcButton.UseVisualStyleBackColor = true;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grossPayLabel.Location = new System.Drawing.Point(158, 95);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(100, 23);
            this.grossPayLabel.TabIndex = 33;
            // 
            // descriptionGrossPayLabel
            // 
            this.descriptionGrossPayLabel.AutoSize = true;
            this.descriptionGrossPayLabel.Location = new System.Drawing.Point(95, 96);
            this.descriptionGrossPayLabel.Name = "descriptionGrossPayLabel";
            this.descriptionGrossPayLabel.Size = new System.Drawing.Size(57, 13);
            this.descriptionGrossPayLabel.TabIndex = 32;
            this.descriptionGrossPayLabel.Text = "Gross pay:";
            // 
            // promptPayRateLabel
            // 
            this.promptPayRateLabel.AutoSize = true;
            this.promptPayRateLabel.Location = new System.Drawing.Point(27, 57);
            this.promptPayRateLabel.Name = "promptPayRateLabel";
            this.promptPayRateLabel.Size = new System.Drawing.Size(125, 13);
            this.promptPayRateLabel.TabIndex = 31;
            this.promptPayRateLabel.Text = "Enter the hourly pay rate:";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(158, 54);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.payRateTextBox.TabIndex = 30;
            this.toolTip1.SetToolTip(this.payRateTextBox, "The hourly pay rate.");
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(158, 17);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextBox.TabIndex = 29;
            this.toolTip1.SetToolTip(this.hoursTextBox, "The number of hours worked.");
            // 
            // promptHoursWorkedLabel
            // 
            this.promptHoursWorkedLabel.AutoSize = true;
            this.promptHoursWorkedLabel.Location = new System.Drawing.Point(32, 20);
            this.promptHoursWorkedLabel.Name = "promptHoursWorkedLabel";
            this.promptHoursWorkedLabel.Size = new System.Drawing.Size(120, 13);
            this.promptHoursWorkedLabel.TabIndex = 28;
            this.promptHoursWorkedLabel.Text = "Enter the hours worked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.descriptionGrossPayLabel);
            this.Controls.Add(this.promptPayRateLabel);
            this.Controls.Add(this.payRateTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.promptHoursWorkedLabel);
            this.Name = "Form1";
            this.Text = "ToolTip Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label grossPayLabel;
        internal System.Windows.Forms.Label descriptionGrossPayLabel;
        internal System.Windows.Forms.Label promptPayRateLabel;
        internal System.Windows.Forms.TextBox payRateTextBox;
        internal System.Windows.Forms.TextBox hoursTextBox;
        internal System.Windows.Forms.Label promptHoursWorkedLabel;
    }
}

