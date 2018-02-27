using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingNews
{
    public partial class Form1 : Form
    {
        private IWebCollector _myWebCollector;
        private IWebCalculator _myWebCalculator;

        public Form1()
        {
            InitializeComponent();
            _myWebCalculator = new WebCalculator();
            _myWebCollector = new WebCollector();
        }

        private string LogicRadioButton()
        {
            if (radioButtonAftonbladet.Checked)
                return "https://www.aftonbladet.se";

            if (radioButtonExpressen.Checked)
                return "https://www.expressen.se/";

            return radioButtonDN.Checked ? "https://www.dn.se/" : String.Empty;
        }

        private async void RadioButtonNews()
        {
            try
            {
                if (groupBoxKeyWords.SelectedRadioButton().Checked)
                {
                    textBoxCount.Text = "Loading...";
                    await Task.Delay(1000);
                    await Task.Run(() => _myWebCollector.GetHtmlFromUrl(LogicRadioButton()));
                }
            }
            finally
            {
                textBoxCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector,
                    groupBoxKeyWords.SelectedRadioButton().Text.ToLower()).ToString();
            }
        }

        private void buttonGetStat_Click(object sender, System.EventArgs e)
        {
            RadioButtonNews();
        }
    }
}

