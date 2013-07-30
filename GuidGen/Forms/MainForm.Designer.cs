namespace GuidGen.Forms {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnClipboard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(3, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(372, 21);
			this.txtPassword.TabIndex = 0;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(3, 32);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "G&enerate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(300, 32);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnClipboard
			// 
			this.btnClipboard.Enabled = false;
			this.btnClipboard.Location = new System.Drawing.Point(84, 32);
			this.btnClipboard.Name = "btnClipboard";
			this.btnClipboard.Size = new System.Drawing.Size(75, 23);
			this.btnClipboard.TabIndex = 13;
			this.btnClipboard.Text = "&Clipboard";
			this.btnClipboard.UseVisualStyleBackColor = true;
			this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnGenerate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 60);
			this.Controls.Add(this.btnClipboard);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtPassword);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "GuidGen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnClipboard;
	}
}

