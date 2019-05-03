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

		private void TitleTimer_Tick(object sender, System.EventArgs e)
		{
			// دو متغیر ذیل نباید به صورت محلی تعریف شوند
			// و باید بیرون تابع و در سطح کلاس تعریف شوند
			//int minute = 0;
			//int second = 0;

			titleLabel.Text = $"{ minute } : { second }";

			second++;

			if (second > 59)
			{
				second = 0;
				minute++;

				if (minute > 59)
				{
					minute = 0;
					second = 0;
				}
			}
		}
	}
}
