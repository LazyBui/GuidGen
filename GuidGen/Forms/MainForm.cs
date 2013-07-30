using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GuidGen.Forms {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e) {
			txtPassword.Text = Guid.NewGuid().ToString("N").ToUpperInvariant();
			btnClipboard.Enabled = true;
		}

		private void btnExit_Click(object sender, EventArgs e) { Close(); }

		private void btnClipboard_Click(object sender, EventArgs e) {
			try {
				Clipboard.Clear();
				Clipboard.SetDataObject(txtPassword.Text, true, 10, 100);
			}
			catch (ExternalException) { }
		}
	}
}
