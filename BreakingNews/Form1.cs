using System.Collections.Generic;
using System.Windows.Forms;

namespace BreakingNews
{
    public partial class Form1 : Form
    {
        private List<string> ListHtml;
        private IWebCollector _myWebCollector;
        private IWebCalculator _myWebCalculator;
        private string _aftonbladet = " https://www.aftonbladet.se";
        private string _expressen = "https://www.expressen.se/";
        private string _dn = "https://www.dn.se/";
        private string _checker;

        public Form1()
        {
            InitializeComponent();
            ListHtml = new List<string>();
            _myWebCalculator = new WebCalculator();
            _myWebCollector = new WebCollector();


        }


        private void DownLoadHtml(string url)
        {
            _myWebCollector.GetHtmlFromUrl(url);
            var html = _myWebCollector.HtmlCode;
            var splitHtml = html.Split('>');

            foreach (var t in splitHtml)
            {

                ListHtml.Add(t + '>');
            }

            foreach (var t in ListHtml)
            {

                listBox1.Items.Add(t);
            }



        }



        private void Form1_Load(object sender, System.EventArgs e)
        {


        }

        private void buttonGetStat_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show(this.groupBox1.SelectedRadioButton().Text);

            if (radioButtonAftonbladet.Checked == true && radioButtonAftonbladet.Text == "aftonbladet")
            {

                switch (this.groupBox1.SelectedRadioButton().Text)
                {
                    case "ekonomi":

                        DownLoadHtml(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text).ToString();
                        return;

                    case "polis":
                        DownLoadHtml(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonPolis.Text).ToString();
                        return;


                    case "bostad":
                        DownLoadHtml(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonBostad.Text).ToString();
                        return;

                    case "korea":
                        DownLoadHtml(_aftonbladet);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonKorea.Text).ToString();
                        return;
                }
            }
            if (radioButtonExpressen.Checked == true && radioButtonExpressen.Text == "expressen")
            {

                switch (this.groupBox1.SelectedRadioButton().Text)
                {
                    case "ekonomi":

                        DownLoadHtml(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text).ToString();
                        return;

                    case "polis":
                        DownLoadHtml(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonPolis.Text).ToString();
                        return;


                    case "bostad":
                        DownLoadHtml(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonBostad.Text).ToString();
                        return;

                    case "korea":
                        DownLoadHtml(_expressen);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonKorea.Text).ToString();
                        return;
                }
            }
            if (radioButtonDN.Checked == true && radioButtonDN.Text == "dagensNyheter")
            {

                switch (this.groupBox1.SelectedRadioButton().Text)
                {
                    case "ekonomi":

                        DownLoadHtml(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text).ToString();
                        return;

                    case "polis":
                        DownLoadHtml(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonPolis.Text).ToString();
                        return;


                    case "bostad":
                        DownLoadHtml(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonBostad.Text).ToString();
                        return;

                    case "korea":
                        DownLoadHtml(_dn);
                        labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonKorea.Text).ToString();
                        return;
                }
            }


        }
    }
}

