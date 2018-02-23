using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakingNews
{
    public partial class Form1 : Form
    {
        private IWebCollector _myWebCollector;
        private IWebCalculator _myWebCalculator;
        private string _aftonbladet = "https://www.aftonbladet.se";
        private string _expressen = "https://www.expressen.se/";
        private string _dn = "https://www.dn.se/";
        private string _changeurl;

        public Form1()
        {
            InitializeComponent();
            _myWebCalculator = new WebCalculator();
            _myWebCollector = new WebCollector();
        }

        private void LogicRadioButton()
        {
            if (radioButtonAftonbladet.Checked)
                _changeurl = _aftonbladet;

            else if (radioButtonExpressen.Checked)
                _changeurl = _expressen;

            else if (radioButtonDN.Checked)
                _changeurl = _dn;
        }

        private async void RadioButtonNews(RadioButton s)
        {
            if (s.Checked)
            {
                try
                {
                    textBoxCount.Text = "Loading...";
                    await Task.Delay(1500);
                    await Task.Run(() => _myWebCollector.GetHtmlFromUrl(_changeurl));
                }
                finally
                {
                    textBoxCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, s.Text.ToLower()).ToString();
                }
            }
        }

        private void buttonGetStat_Click(object sender, System.EventArgs e)
        {
            LogicRadioButton();
            RadioButtonNews(groupBoxKeyWords.SelectedRadioButton());
        }
    }
}

