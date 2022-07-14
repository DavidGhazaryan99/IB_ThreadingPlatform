using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;     // Add this for multi-threading support
using IBApi;        // Add this for IB API Support

namespace IB_ThreadingPlatform
{
    public partial class Form2 : Form
    {
        EWrapperImpl ibClient;

        public Form2()
        {
            InitializeComponent();
            ibClient = new EWrapperImpl();
        }
        public void ViewContractDetalis(string contract)
        {

            ContractListBox.Items.Add(contract);
        }
    }
}
