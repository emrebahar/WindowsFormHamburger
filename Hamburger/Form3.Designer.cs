﻿
namespace Hamburger
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotalCiro = new System.Windows.Forms.Label();
            this.lblTotalOrderCount = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 372);
            this.listBox1.TabIndex = 0;
            // 
            // lblTotalCiro
            // 
            this.lblTotalCiro.AutoSize = true;
            this.lblTotalCiro.Location = new System.Drawing.Point(509, 97);
            this.lblTotalCiro.Name = "lblTotalCiro";
            this.lblTotalCiro.Size = new System.Drawing.Size(84, 17);
            this.lblTotalCiro.TabIndex = 1;
            this.lblTotalCiro.Text = "Toplam Ciro";
            // 
            // lblTotalOrderCount
            // 
            this.lblTotalOrderCount.AutoSize = true;
            this.lblTotalOrderCount.Location = new System.Drawing.Point(509, 183);
            this.lblTotalOrderCount.Name = "lblTotalOrderCount";
            this.lblTotalOrderCount.Size = new System.Drawing.Size(143, 17);
            this.lblTotalOrderCount.TabIndex = 2;
            this.lblTotalOrderCount.Text = "Toplam Sipariş Sayısı";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(509, 266);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(137, 17);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "Extra Malzeme Geliri";
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Location = new System.Drawing.Point(509, 355);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(126, 17);
            this.lblOrderQuantity.TabIndex = 4;
            this.lblOrderQuantity.Text = "Satılan Ürün Adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam Ciro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplam Sipariş Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Extra Malzeme Geliri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satılan Ürün Adedi";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblTotalOrderCount);
            this.Controls.Add(this.lblTotalCiro);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTotalCiro;
        private System.Windows.Forms.Label lblTotalOrderCount;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}