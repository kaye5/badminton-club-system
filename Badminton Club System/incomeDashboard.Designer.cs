﻿namespace Badminton_Club_System
{
    partial class incomeDashboard
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
            this.expenseDashboardExpenseListView = new System.Windows.Forms.ListView();
            this.incomeMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeTransactiontHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeCashHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeDashboardTotalTbox = new System.Windows.Forms.TextBox();
            this.incomeDashboardMonthExpense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // expenseDashboardExpenseListView
            // 
            this.expenseDashboardExpenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.incomeMonthHeader,
            this.incomeTransactiontHeader,
            this.incomeCashHeader});
            this.expenseDashboardExpenseListView.Location = new System.Drawing.Point(12, 95);
            this.expenseDashboardExpenseListView.Name = "expenseDashboardExpenseListView";
            this.expenseDashboardExpenseListView.Size = new System.Drawing.Size(776, 343);
            this.expenseDashboardExpenseListView.TabIndex = 5;
            this.expenseDashboardExpenseListView.UseCompatibleStateImageBehavior = false;
            this.expenseDashboardExpenseListView.View = System.Windows.Forms.View.Details;
            // 
            // incomeMonthHeader
            // 
            this.incomeMonthHeader.Text = "Month";
            this.incomeMonthHeader.Width = 119;
            // 
            // incomeTransactiontHeader
            // 
            this.incomeTransactiontHeader.Text = "Total Transaction";
            this.incomeTransactiontHeader.Width = 131;
            // 
            // incomeCashHeader
            // 
            this.incomeCashHeader.Text = "Income";
            this.incomeCashHeader.Width = 102;
            // 
            // incomeDashboardTotalTbox
            // 
            this.incomeDashboardTotalTbox.Location = new System.Drawing.Point(140, 53);
            this.incomeDashboardTotalTbox.Name = "incomeDashboardTotalTbox";
            this.incomeDashboardTotalTbox.Size = new System.Drawing.Size(148, 20);
            this.incomeDashboardTotalTbox.TabIndex = 10;
            // 
            // incomeDashboardMonthExpense
            // 
            this.incomeDashboardMonthExpense.Location = new System.Drawing.Point(140, 22);
            this.incomeDashboardMonthExpense.Name = "incomeDashboardMonthExpense";
            this.incomeDashboardMonthExpense.Size = new System.Drawing.Size(148, 20);
            this.incomeDashboardMonthExpense.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total  Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "This Month Income";
            // 
            // incomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incomeDashboardTotalTbox);
            this.Controls.Add(this.incomeDashboardMonthExpense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expenseDashboardExpenseListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "incomeDashboard";
            this.Text = "incomeDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView expenseDashboardExpenseListView;
        private System.Windows.Forms.ColumnHeader incomeMonthHeader;
        private System.Windows.Forms.ColumnHeader incomeTransactiontHeader;
        private System.Windows.Forms.ColumnHeader incomeCashHeader;
        private System.Windows.Forms.TextBox incomeDashboardTotalTbox;
        private System.Windows.Forms.TextBox incomeDashboardMonthExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}