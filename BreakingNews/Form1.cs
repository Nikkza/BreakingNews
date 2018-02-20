using System.Collections.Generic;
using System.Windows.Forms;

namespace BreakingNews
{
    public partial class Form1 : Form
    {
        private IWebCollector _myWebCollector;
        private IWebCalculator _myWebCalculator;
        private string _aftonbladet = " https://www.aftonbladet.se";
        private string _expressen = "https://www.expressen.se/";
        private string _dn = "https://www.dn.se/";

        public Form1()
        {
            InitializeComponent();
            _myWebCalculator = new WebCalculator();
            _myWebCollector = new WebCollector();

        }

   
        private void buttonGetStat_Click(object sender, System.EventArgs e)
        {
            if (radioButtonAftonbladet.Checked == true && radioButtonAftonbladet.Text == "aftonbladet")
            {
                switch (this.groupBox1.SelectedRadioButton().Text)
                {
                    case "ekonomi":
                        _myWebCollector.GetHtmlFromUrl(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text.ToLower()).ToString();
                        return;

                    case "polis":
                        _myWebCollector.GetHtmlFromUrl(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonPolis.Text.ToLower()).ToString();
                        return;

                    case "bostad":
                        _myWebCollector.GetHtmlFromUrl(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonBostad.Text.ToLower()).ToString();
                        return;

                    case "korea":
                        _myWebCollector.GetHtmlFromUrl(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonKorea.Text.ToLower()).ToString();
                        return;
                }
            }
            if (radioButtonExpressen.Checked == true && radioButtonExpressen.Text == "expressen")
            {
               switch (this.groupBox1.SelectedRadioButton().Text)
                {
                    case "ekonomi":
                        _myWebCollector.GetHtmlFromUrl(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text.ToLower()).ToString();
                        return;

                    case "polis":
                        _myWebCollector.GetHtmlFromUrl(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonPolis.Text.ToLower()).ToString();
                        return;

                    case "bostad":
                        _myWebCollector.GetHtmlFromUrl(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonBostad.Text.ToLower()).ToString();
                        return;

                    case "korea":
                        _myWebCollector.GetHtmlFromUrl(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonKorea.Text.ToLower()).ToString();
                        return;
                }
            }

            if (radioButtonDN.Checked == true && radioButtonDN.Text == "dagensNyheter")
            {
               switch (this.groupBox1.SelectedRadioButton().Text)
                {
                    case "ekonomi":
                        _myWebCollector.GetHtmlFromUrl(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text.ToLower()).ToString();
                        return;

                    case "polis":
                        _myWebCollector.GetHtmlFromUrl(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonPolis.Text.ToLower()).ToString();
                        return;

                    case "bostad":
                        _myWebCollector.GetHtmlFromUrl(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonBostad.Text.ToLower()).ToString();
                        return;

                    case "korea":
                        _myWebCollector.GetHtmlFromUrl(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonKorea.Text.ToLower()).ToString();
                        return;
                }
            }
        }
    }
}

