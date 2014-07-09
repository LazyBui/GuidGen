using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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

		private string GetGuid() {
			string result = null;

			if (rbText.Checked) {
				if (chkHyphens.Checked && chkBraces.Checked) result = Guid.NewGuid().ToString("B");
				else if (chkHyphens.Checked) result = Guid.NewGuid().ToString("D");
				else if (chkBraces.Checked) result = "{" + Guid.NewGuid().ToString("N") + "}";
				else result = Guid.NewGuid().ToString("N");
				return rbUppercase.Checked ?
					result.ToUpperInvariant() :
					result;
			}
			if (rbBytes.Checked) {
				if (rbExpanded.Checked) result = Guid.NewGuid().ToString("X");
				else if (rbShort.Checked) result = "{" + string.Join(",", Guid.NewGuid().ToByteArray().Select(b => "0x" + b.ToString("x2"))) + "}";
				else throw new NotImplementedException();

				return Regex.Replace(result, "[a-f\\,]", match => {
					var ret = match.ToString();
					if (ret != ",") {
						return rbUppercase.Checked ?
							ret.ToUpperInvariant() :
							ret;
					}
					return ", ";
				});
			}
			throw new NotImplementedException();
		}

		private void btnExit_Click(object sender, EventArgs e) { Close(); }

		private void btnClipboard_Click(object sender, EventArgs e) {
			try {
				Clipboard.Clear();
				Clipboard.SetDataObject(txtPassword.Text, true, 10, 100);
			}
			catch (ExternalException) { }
		}

		private void rbBytes_CheckedChanged(object sender, EventArgs e) {
			EnableStateOnChildren(grpBytes.Controls, rbBytes.Checked);
		}

		private void rbText_CheckedChanged(object sender, EventArgs e) {
			EnableStateOnChildren(grpText.Controls, rbText.Checked);
		}

		private void EnableStateOnChildren(Control.ControlCollection pControls, bool pEnabled) {
			foreach (Control ctrl in pControls) {
				ctrl.Enabled = pEnabled;
				EnableStateOnChildren(ctrl.Controls, pEnabled);
			}
		}
	}
}
