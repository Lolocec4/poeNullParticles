﻿/*
 * User: ajaxvs
 * Date: 31.12.2017
 * Time: 17:32
 */
namespace poeNullEffects
{
	partial class frmSayThanks
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox txt;
		private System.Windows.Forms.RichTextBox richTextBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txt = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.richTextBox2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.txt);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(557, 315);
			this.panel1.TabIndex = 0;
			// 
			// richTextBox2
			// 
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Location = new System.Drawing.Point(3, 286);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.Size = new System.Drawing.Size(392, 24);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.TabStop = false;
			this.richTextBox2.Text = "(c) https://github.com/ajaxvs";
			this.richTextBox2.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.onLinkClick);
			this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2TextChanged);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(413, 239);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 64);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(15, 15);
			this.txt.Name = "txt";
			this.txt.ReadOnly = true;
			this.txt.Size = new System.Drawing.Size(526, 210);
			this.txt.TabIndex = 0;
			this.txt.TabStop = false;
			this.txt.Text = "\nIf you like this app - feel free to say \"Thanks\" with:\n\n# Webmoney:\nZ35423677653" +
	"1\nR600482511370\n\n# BTC:\n1KQC1BTfZ2KNa4fN8s8sB7jMahACdymoQX\n";
			this.txt.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.onLinkClick);
			// 
			// frmSayThanks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 335);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSayThanks";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Say Thanks";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
