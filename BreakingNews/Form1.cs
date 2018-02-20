using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BreakingNews
{
    public partial class Form1 : Form
    {
        private List<string> ListHtml;
        private IWebCollector _myWebCollector;
        private IWebCalculator _myWebCalculator;
        public Form1()
        {
            InitializeComponent();
            ListHtml = new List<string>();
            _myWebCalculator = new WebCalculator();
            _myWebCollector = new WebCollector();

        }


        private void CheckedRadioButtons(RadioButton rb, RadioButton sb, string url)
        {
            if (rb.Checked == true || sb.Checked == true)
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

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {


        }

        private void buttonGetStat_Click(object sender, System.EventArgs e)
        {

            CheckedRadioButtons(radioButtonAftonbladet, radioButtonEkonomi, "https://www.aftonbladet.se/");
            listBox2.Items.Add(_myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text));
            labelCount.Text = _myWebCalculator.CalculateNumberOfHits(_myWebCollector, radioButtonEkonomi.Text).ToString();

        }
    }
}

