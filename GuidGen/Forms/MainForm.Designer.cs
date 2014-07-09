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
			this.rbUppercase = new System.Windows.Forms.RadioButton();
			this.cbLowercase = new System.Windows.Forms.RadioButton();
			this.chkHyphens = new System.Windows.Forms.CheckBox();
			this.chkBraces = new System.Windows.Forms.CheckBox();
			this.grpText = new System.Windows.Forms.GroupBox();
			this.grpBytes = new System.Windows.Forms.GroupBox();
			this.rbText = new System.Windows.Forms.RadioButton();
			this.rbBytes = new System.Windows.Forms.RadioButton();
			this.rbShort = new System.Windows.Forms.RadioButton();
			this.rbExpanded = new System.Windows.Forms.RadioButton();
			this.grpResult = new System.Windows.Forms.GroupBox();
			this.grpText.SuspendLayout();
			this.grpBytes.SuspendLayout();
			this.grpResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(2, 164);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txtPassword.Size = new System.Drawing.Size(324, 269);
			this.txtPassword.TabIndex = 0;
			this.txtPassword.WordWrap = false;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(2, 439);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "G&enerate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(250, 439);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// rbUppercase
			// 
			this.rbUppercase.AutoSize = true;
			this.rbUppercase.Checked = true;
			this.rbUppercase.Location = new System.Drawing.Point(9, 20);
			this.rbUppercase.Name = "rbUppercase";
			this.rbUppercase.Size = new System.Drawing.Size(113, 17);
			this.rbUppercase.TabIndex = 13;
			this.rbUppercase.TabStop = true;
			this.rbUppercase.Text = "Uppercase Letters";
			this.rbUppercase.UseVisualStyleBackColor = true;
			// 
			// cbLowercase
			// 
			this.cbLowercase.AutoSize = true;
			this.cbLowercase.Location = new System.Drawing.Point(175, 20);
			this.cbLowercase.Name = "cbLowercase";
			this.cbLowercase.Size = new System.Drawing.Size(113, 17);
			this.cbLowercase.TabIndex = 14;
			this.cbLowercase.Text = "Lowercase Letters";
			this.cbLowercase.UseVisualStyleBackColor = true;
			// 
			// chkHyphens
			// 
			this.chkHyphens.AutoSize = true;
			this.chkHyphens.Location = new System.Drawing.Point(9, 21);
			this.chkHyphens.Name = "chkHyphens";
			this.chkHyphens.Size = new System.Drawing.Size(68, 17);
			this.chkHyphens.TabIndex = 15;
			this.chkHyphens.Text = "Hyphens";
			this.chkHyphens.UseVisualStyleBackColor = true;
			// 
			// chkBraces
			// 
			this.chkBraces.AutoSize = true;
			this.chkBraces.Location = new System.Drawing.Point(9, 44);
			this.chkBraces.Name = "chkBraces";
			this.chkBraces.Size = new System.Drawing.Size(58, 17);
			this.chkBraces.TabIndex = 16;
			this.chkBraces.Text = "Braces";
			this.chkBraces.UseVisualStyleBackColor = true;
			// 
			// grpText
			// 
			this.grpText.Controls.Add(this.chkBraces);
			this.grpText.Controls.Add(this.chkHyphens);
			this.grpText.Location = new System.Drawing.Point(3, 35);
			this.grpText.Name = "grpText";
			this.grpText.Size = new System.Drawing.Size(158, 71);
			this.grpText.TabIndex = 17;
			this.grpText.TabStop = false;
			this.grpText.Text = "Text Format";
			// 
			// grpBytes
			// 
			this.grpBytes.Controls.Add(this.rbExpanded);
			this.grpBytes.Controls.Add(this.rbShort);
			this.grpBytes.Location = new System.Drawing.Point(168, 35);
			this.grpBytes.Name = "grpBytes";
			this.grpBytes.Size = new System.Drawing.Size(158, 71);
			this.grpBytes.TabIndex = 18;
			this.grpBytes.TabStop = false;
			this.grpBytes.Text = "Byte Format";
			// 
			// rbText
			// 
			this.rbText.AutoSize = true;
			this.rbText.Checked = true;
			this.rbText.Location = new System.Drawing.Point(12, 12);
			this.rbText.Name = "rbText";
			this.rbText.Size = new System.Drawing.Size(47, 17);
			this.rbText.TabIndex = 19;
			this.rbText.TabStop = true;
			this.rbText.Text = "Text";
			this.rbText.UseVisualStyleBackColor = true;
			this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
			// 
			// rbBytes
			// 
			this.rbBytes.AutoSize = true;
			this.rbBytes.Location = new System.Drawing.Point(178, 12);
			this.rbBytes.Name = "rbBytes";
			this.rbBytes.Size = new System.Drawing.Size(52, 17);
			this.rbBytes.TabIndex = 20;
			this.rbBytes.Text = "Bytes";
			this.rbBytes.UseVisualStyleBackColor = true;
			this.rbBytes.CheckedChanged += new System.EventHandler(this.rbBytes_CheckedChanged);
			// 
			// rbShort
			// 
			this.rbShort.AutoSize = true;
			this.rbShort.Checked = true;
			this.rbShort.Enabled = false;
			this.rbShort.Location = new System.Drawing.Point(10, 20);
			this.rbShort.Name = "rbShort";
			this.rbShort.Size = new System.Drawing.Size(51, 17);
			this.rbShort.TabIndex = 0;
			this.rbShort.TabStop = true;
			this.rbShort.Text = "Short";
			this.rbShort.UseVisualStyleBackColor = true;
			// 
			// rbExpanded
			// 
			this.rbExpanded.AutoSize = true;
			this.rbExpanded.Enabled = false;
			this.rbExpanded.Location = new System.Drawing.Point(10, 43);
			this.rbExpanded.Name = "rbExpanded";
			this.rbExpanded.Size = new System.Drawing.Size(73, 17);
			this.rbExpanded.TabIndex = 1;
			this.rbExpanded.TabStop = true;
			this.rbExpanded.Text = "Expanded";
			this.rbExpanded.UseVisualStyleBackColor = true;
			// 
			// grpResult
			// 
			this.grpResult.Controls.Add(this.rbUppercase);
			this.grpResult.Controls.Add(this.cbLowercase);
			this.grpResult.Location = new System.Drawing.Point(3, 108);
			this.grpResult.Name = "grpResult";
			this.grpResult.Size = new System.Drawing.Size(323, 50);
			this.grpResult.TabIndex = 21;
			this.grpResult.TabStop = false;
			this.grpResult.Text = "Result";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnGenerate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 466);
			this.Controls.Add(this.grpResult);
			this.Controls.Add(this.rbBytes);
			this.Controls.Add(this.rbText);
			this.Controls.Add(this.grpBytes);
			this.Controls.Add(this.grpText);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtPassword);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "GuidGen";
			this.grpText.ResumeLayout(false);
			this.grpText.PerformLayout();
			this.grpBytes.ResumeLayout(false);
			this.grpBytes.PerformLayout();
			this.grpResult.ResumeLayout(false);
			this.grpResult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.RadioButton rbUppercase;
		private System.Windows.Forms.RadioButton cbLowercase;
		private System.Windows.Forms.CheckBox chkHyphens;
		private System.Windows.Forms.CheckBox chkBraces;
		private System.Windows.Forms.GroupBox grpText;
		private System.Windows.Forms.GroupBox grpBytes;
		private System.Windows.Forms.RadioButton rbExpanded;
		private System.Windows.Forms.RadioButton rbShort;
		private System.Windows.Forms.RadioButton rbText;
		private System.Windows.Forms.RadioButton rbBytes;
		private System.Windows.Forms.GroupBox grpResult;
	}
}

