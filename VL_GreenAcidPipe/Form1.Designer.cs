namespace VL_GreenAcidPipe
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			webView = new Microsoft.Web.WebView2.WinForms.WebView2();
			status = new ReaLTaiizor.Controls.BigLabel();
			urlText = new ReaLTaiizor.Controls.NightLabel();
			((System.ComponentModel.ISupportInitialize)webView).BeginInit();
			SuspendLayout();
			// 
			// webView
			// 
			webView.AllowExternalDrop = true;
			webView.CreationProperties = null;
			webView.DefaultBackgroundColor = Color.White;
			webView.Dock = DockStyle.Bottom;
			webView.Location = new Point(0, 65);
			webView.Name = "webView";
			webView.Size = new Size(800, 385);
			webView.Source = new Uri("https://vercel.com/login", UriKind.Absolute);
			webView.TabIndex = 0;
			webView.ZoomFactor = 1D;
			// 
			// status
			// 
			status.BackColor = Color.Transparent;
			status.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			status.ForeColor = Color.FromArgb(80, 80, 80);
			status.Location = new Point(12, 9);
			status.Name = "status";
			status.Size = new Size(396, 46);
			status.TabIndex = 1;
			status.Text = "Wait...";
			// 
			// urlText
			// 
			urlText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			urlText.BackColor = Color.Transparent;
			urlText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			urlText.ForeColor = Color.FromArgb(114, 118, 127);
			urlText.Location = new Point(414, 9);
			urlText.Name = "urlText";
			urlText.Size = new Size(374, 46);
			urlText.TabIndex = 2;
			urlText.Text = "Wait...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.RosyBrown;
			this.ClientSize = new Size(800, 450);
			this.Controls.Add(urlText);
			this.Controls.Add(status);
			this.Controls.Add(webView);
			this.DoubleBuffered = true;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "GAP VL";
			this.TransparencyKey = Color.Fuchsia;
			((System.ComponentModel.ISupportInitialize)webView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Microsoft.Web.WebView2.WinForms.WebView2 webView;
		private ReaLTaiizor.Controls.BigLabel status;
		private ReaLTaiizor.Controls.NightLabel urlText;
	}
}