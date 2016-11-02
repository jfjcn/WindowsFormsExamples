using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeUI();
        }

        private void InitializeUI()
        {
            lblClientContact.Focus();
            cltDiscreteChoice.SetContentsOfLabelAndTextboxTo("Discrete Choice", "Typically $25");
            cltMarketDriverModeling.SetContentsOfLabelAndTextboxTo("Market Driver Modeling", "Typically $25");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var address = addrClientContact.GetAddressInfo();
            Console.WriteLine(address.LastName);
        }
    }
}
