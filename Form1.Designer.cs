﻿
namespace Tip_Calculator1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_bill = new System.Windows.Forms.TextBox();
            this.textBox_Tippercentage = new System.Windows.Forms.TextBox();
            this.textBox_numberofPeople = new System.Windows.Forms.TextBox();
            this.textBox_Tip = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number_of_people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip_per_person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total_per_person";
            // 
            // textBox_bill
            // 
            this.textBox_bill.Location = new System.Drawing.Point(3, 28);
            this.textBox_bill.Multiline = true;
            this.textBox_bill.Name = "textBox_bill";
            this.textBox_bill.Size = new System.Drawing.Size(135, 33);
            this.textBox_bill.TabIndex = 5;
            // 
            // textBox_Tippercentage
            // 
            this.textBox_Tippercentage.Location = new System.Drawing.Point(3, 101);
            this.textBox_Tippercentage.Multiline = true;
            this.textBox_Tippercentage.Name = "textBox_Tippercentage";
            this.textBox_Tippercentage.Size = new System.Drawing.Size(135, 32);
            this.textBox_Tippercentage.TabIndex = 6;
            // 
            // textBox_numberofPeople
            // 
            this.textBox_numberofPeople.Location = new System.Drawing.Point(-3, 191);
            this.textBox_numberofPeople.Name = "textBox_numberofPeople";
            this.textBox_numberofPeople.Size = new System.Drawing.Size(100, 20);
            this.textBox_numberofPeople.TabIndex = 7;
            // 
            // textBox_Tip
            // 
            this.textBox_Tip.Location = new System.Drawing.Point(449, 35);
            this.textBox_Tip.Name = "textBox_Tip";
            this.textBox_Tip.Size = new System.Drawing.Size(100, 20);
            this.textBox_Tip.TabIndex = 8;
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(449, 153);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(100, 20);
            this.textBox_total.TabIndex = 9;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(433, 212);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 271);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.textBox_Tip);
            this.Controls.Add(this.textBox_numberofPeople);
            this.Controls.Add(this.textBox_Tippercentage);
            this.Controls.Add(this.textBox_bill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_bill;
        private System.Windows.Forms.TextBox textBox_Tippercentage;
        private System.Windows.Forms.TextBox textBox_numberofPeople;
        private System.Windows.Forms.TextBox textBox_Tip;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Button Calculate;
    }
}

