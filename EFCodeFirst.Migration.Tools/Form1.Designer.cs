namespace EFCodeFirst.Migration.Tools
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.rtbScript = new System.Windows.Forms.RichTextBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnScript = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(12, 12);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(89, 31);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// rtbScript
			// 
			this.rtbScript.Location = new System.Drawing.Point(12, 50);
			this.rtbScript.Name = "rtbScript";
			this.rtbScript.Size = new System.Drawing.Size(760, 399);
			this.rtbScript.TabIndex = 1;
			this.rtbScript.Text = "";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(220, 22);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(92, 13);
			this.lblMessage.TabIndex = 2;
			this.lblMessage.Text = "Veritabanı güncel.";
			// 
			// btnScript
			// 
			this.btnScript.Location = new System.Drawing.Point(107, 13);
			this.btnScript.Name = "btnScript";
			this.btnScript.Size = new System.Drawing.Size(89, 31);
			this.btnScript.TabIndex = 3;
			this.btnScript.Text = "Script";
			this.btnScript.UseVisualStyleBackColor = true;
			this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.btnScript);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.rtbScript);
			this.Controls.Add(this.btnUpdate);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Codefirst Migration Tool";
			this.Shown += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.RichTextBox rtbScript;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnScript;
	}
}

