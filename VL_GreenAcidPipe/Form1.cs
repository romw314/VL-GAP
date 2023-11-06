using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace VL_GreenAcidPipe
{
	public partial class MainForm : Form
	{
		public const string DEFAULT_USER = "romw314";
		public const string DEFAULT_NAME = "My-supersite";
		protected HttpClient client;

		public MainForm()
		{
			InitializeComponent();
			client = new()
			{
				BaseAddress = new Uri("http://localhost:18349")
			};
			InitAsync();
			Cursor = new Cursor("Cursor.cur");
		}

		protected async void InitAsync()
		{
			bool logIn = true, deploy = false;
			string user = await GetJSProperty("login"), name = await GetJSProperty("appName"), repo = $"{user}/GAP-{name}", lowerName = name.ToLowerInvariant();
			Timer t = new() { Interval = 100 };
			t.Tick += async (_, _) =>
			{
				var modUri = webView.Source.AbsoluteUri.Replace("/", "");
    				if (modUri.Contains("projects"))
					modUri = "https:vercel.comdashboard";
				if (!modUri.Contains("new"))
					deploy = false;
				urlText.Text = modUri;
				status.Text = modUri switch
				{
					"https:vercel.comlogin" => "Log in to your vercel account",
					"https:vercel.comdashboard" => new Func<string>(() =>
					{
						logIn = false;
						return "Go to Add New>Project";
					})(),
					"https:vercel.comnew" => new Func<string>(() =>
					{
						deploy = true;
						webView.CoreWebView2.Navigate(
							$"https://vercel.com/new/import/" +
							$"?s=https%3A%2F%2Fgithub.com%2F{HttpUtility.UrlEncode(repo)}" +
							$"&showOptionalTeamCreation=false" +
							$"&project-name=gap1-site-{lowerName}");
						return "Wait...";
					})(),
					_ => logIn ? "Continue" : (deploy ? "Scroll down, then, DEPLOY" : await new Func<Task<string>>(async () =>
					{
						if (modUri.Contains($"{user}gap1-site-{lowerName}"))
						{
							t.Stop();
							status.Text = "Now close this app.";
							Refresh();
							try
							{
								await End();
							}
							catch { }
						}
						else
							Application.Restart();
						return "";
					})())
				};
			};
			t.Start();
		}

		protected virtual async Task<string> GetJSProperty(string name)
		{
			return await client.GetStringAsync($"/opt/{name}");
		}

		protected virtual async Task End()
		{
			await client.GetAsync("/done");
		}
	}
}
