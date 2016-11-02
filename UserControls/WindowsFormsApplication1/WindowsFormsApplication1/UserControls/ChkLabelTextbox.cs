using System.Windows.Forms;

namespace WindowsFormsApplication1.UserControls
{
    public partial class ChkLabelTextbox : UserControl
    {
        public ChkLabelTextbox()
        {
            InitializeComponent();

            InitializeUI();
        }

        private void InitializeUI()
        {
            txtTextbox.TextChanged += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(txtTextbox.Text))
                {
                    chkCheckbox.CheckState = CheckState.Checked;
                }
                else
                {
                    chkCheckbox.CheckState = CheckState.Unchecked;
                }
            };
        }

        public void SetContentsOfLabelAndTextboxTo(string labelText, string textboxText)
        {
            chkCheckbox.Text = labelText;
            txtTextbox.NullText = textboxText;
        }
    }
}
