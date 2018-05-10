namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		int minute;
		int second;

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			minute = 0;
			second = 0;
		}

		private void titleTimer_Tick(object sender, System.EventArgs e)
		{
			//int minute = 0;
			//int second = 0;

			titleLabel.Text = $"{ minute } : { second }";

			second++;

			if (second > 60)
			{
				second = 0;
				minute++;
			}
		}
	}
}
