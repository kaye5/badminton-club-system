﻿namespace Badminton_Club_System
{
    partial class inventoryNewItem
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
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryNewItemNameTbox = new System.Windows.Forms.TextBox();
            this.inventoryNewItemCommentTbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inventoryNewItemIDTbox = new System.Windows.Forms.TextBox();
            this.inventoryNewItemAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // inventoryNewItemNameTbox
            // 
            this.inventoryNewItemNameTbox.Location = new System.Drawing.Point(85, 10);
            this.inventoryNewItemNameTbox.Name = "inventoryNewItemNameTbox";
            this.inventoryNewItemNameTbox.Size = new System.Drawing.Size(160, 20);
            this.inventoryNewItemNameTbox.TabIndex = 3;
            // 
            // inventoryNewItemCommentTbox
            // 
            this.inventoryNewItemCommentTbox.Location = new System.Drawing.Point(85, 81);
            this.inventoryNewItemCommentTbox.Name = "inventoryNewItemCommentTbox";
            this.inventoryNewItemCommentTbox.Size = new System.Drawing.Size(160, 96);
            this.inventoryNewItemCommentTbox.TabIndex = 4;
            this.inventoryNewItemCommentTbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item ID";
            // 
            // inventoryNewItemIDTbox
            // 
            this.inventoryNewItemIDTbox.Location = new System.Drawing.Point(85, 39);
            this.inventoryNewItemIDTbox.Name = "inventoryNewItemIDTbox";
            this.inventoryNewItemIDTbox.Size = new System.Drawing.Size(160, 20);
            this.inventoryNewItemIDTbox.TabIndex = 6;
            // 
            // inventoryNewItemAddBtn
            // 
            this.inventoryNewItemAddBtn.Location = new System.Drawing.Point(16, 204);
            this.inventoryNewItemAddBtn.Name = "inventoryNewItemAddBtn";
            this.inventoryNewItemAddBtn.Size = new System.Drawing.Size(106, 23);
            this.inventoryNewItemAddBtn.TabIndex = 7;
            this.inventoryNewItemAddBtn.Text = "Add";
            this.inventoryNewItemAddBtn.UseVisualStyleBackColor = true;
            // 
            // inventoryNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 422);
            this.Controls.Add(this.inventoryNewItemAddBtn);
            this.Controls.Add(this.inventoryNewItemIDTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inventoryNewItemCommentTbox);
            this.Controls.Add(this.inventoryNewItemNameTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryNewItem";
            this.Text = "inventoryNewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inventoryNewItemNameTbox;
        private System.Windows.Forms.RichTextBox inventoryNewItemCommentTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inventoryNewItemIDTbox;
        private System.Windows.Forms.Button inventoryNewItemAddBtn;
    }
}