using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Domain;

namespace WindowsFormsApplication1.UserControls
{
    public partial class AddressTextArea : UserControl
    {
        public AddressTextArea()
        {
            InitializeComponent();
        }

        public Address GetAddressInfo()
        {
            var addressInfo = new Address();
            addressInfo.FirstName = txtFirstName.Text;
            addressInfo.LastName = txtLastName.Text;
            addressInfo.Division = txtDivision.Text;
            addressInfo.AddressLine1 = txtAddress1.Text;
            addressInfo.AddressLine2 = txtAddress2.Text;
            addressInfo.City = txtCity.Text;
            return addressInfo;
        }
    }
}
