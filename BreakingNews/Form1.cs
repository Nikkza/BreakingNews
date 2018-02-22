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
        private const string _ekonomi = "ekonomi";
        private string _changeurl;

        public Form1()
        {
            InitializeComponent();
            _myWebCalculator = new WebCalculator();
            _myWebCollector = new WebCollector();
        }
        private async Task Loading()
        {
            labelCount.Text = "Loading...";
            await Task.Delay(1500);
        }

        private void LogicRadioButton()
        {
            if (radioButtonAftonbladet.Checked)
            {
                _changeurl = _aftonbladet;
            }
            else if (radioButtonExpressen.Checked)
            {
                _changeurl = _expressen;
            }
            else if (radioButtonDN.Checked)
            {
                _changeurl = _dn;
            }
        }

        private async void buttonGetStat_Click(object sender, System.EventArgs e)
        {
            LogicRadioButton();

            switch (this.groupBox1.SelectedRadioButton().Text)
            {
                case "ekonomi":
                    await Loading();
                    await Task.Run(() => _myWebCollector.GetHtmlFromUrl(_changeurl));
                    labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, this.groupBox1.SelectedRadioButton().Text.ToLower()).ToString();
                    return;

                case "polis":
                    await Loading();
                    await Task.Run(() => _myWebCollector.GetHtmlFromUrl(_changeurl));
                    labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, this.groupBox1.SelectedRadioButton().Text.ToLower()).ToString();
                    return;

                case "bostad":
                    await Loading();
                    await Task.Run(() => _myWebCollector.GetHtmlFromUrl(_changeurl));
                    labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, this.groupBox1.SelectedRadioButton().Text.ToLower()).ToString();
                    return;

                case "korea":
                    await Loading();
                    await Task.Run(() => _myWebCollector.GetHtmlFromUrl(_changeurl));
                    labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, this.groupBox1.SelectedRadioButton().Text.ToLower()).ToString();
                    return;
            }
        }
    }
}

