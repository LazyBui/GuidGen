using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GuidGen.Forms {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e) {
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < 15; i++) {
				sb.AppendLine(GetGuid());
			}
			txtPassword.Text = sb.ToString();
		}

		private string GetGuid() { return Guid.NewGuid().ToString("N").ToUpperInvariant(); }

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
