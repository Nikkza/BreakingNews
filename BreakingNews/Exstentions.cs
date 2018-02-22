using System.Linq;
using System.Windows.Forms;

namespace BreakingNews
{
    public static class Exstentions
    {
        public static RadioButton SelectedRadioButton(this GroupBox b)
        {
            return b.Controls.OfType<RadioButton>().Where(rb => rb.Checked).SingleOrDefault();
        }

        public static RadioButton SelectedRadioButtoNews(this GroupBox b)
        {
            return b.Controls.OfType<RadioButton>().Where(rb => rb.Checked).SingleOrDefault();
        }

    }
}
