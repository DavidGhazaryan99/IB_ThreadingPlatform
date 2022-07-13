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
    public partial class Form1 : Form
    {
        // Create the ibClient object to represent the connection
        // This will be used throughout the form
        EWrapperImpl ibClient;
        public Form1()
        {
            InitializeComponent();

            // Instantiate the ibClient
            ibClient = new EWrapperImpl();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Connect to the IB Server through TWS. Parameters are:
            // host       - Host name or IP address of the host running TWS
            // port       - The port TWS listens through for connections
            // clientId   - The identifier of the client application
            ibClient.ClientSocket.eConnect("127.0.0.1", 7496, 0);

            // For IB TWS API version 9.72 and higher, implement this
            // signal-handling code. Otherwise comment it out.

            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();
            new Thread(() => {
                while (ibClient.ClientSocket.IsConnected())
                {
                    ibClient.Signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();

            // Pause here until the connection is complete 
            while (ibClient.NextOrderId <= 0) { }
            // Set up the form object in the EWrapper
            ibClient.myform = (Form1)Application.OpenForms[0];

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // Disconnect from interactive Brokers
            ibClient.ClientSocket.eDisconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Create a new contract to specify the security we are searching for
            IBApi.Contract contract = new IBApi.Contract();
            // Create a new TagValueList object (for API version 9.71 and later) 
            List<IBApi.TagValue> mktDataOptions = new List<IBApi.TagValue>();

            // Set the underlying stock symbol from the tbSymbol text box
            contract.Symbol = tbSymbol.Text;
            // Set the Security type to STK for a Stock
            contract.SecType = "STK";
            // Use "SMART" as the general exchange
            contract.Exchange = "SMART";
            // Set the primary exchange (sometimes called Listing exchange)
            // Use either NYSE or ISLAND
            contract.PrimaryExch = "ISLAND";
            // Set the currency to USD
            contract.Currency = "USD";

            // If using delayed market data subscription un-comment 
            // the line below to request delayed data
            ibClient.ClientSocket.reqMarketDataType(3);

            // Kick off the subscription for real-time data (add the mktDataOptions list for API v9.71)
            ibClient.ClientSocket.reqMktData(1, contract, "",false, false, mktDataOptions);
            // For API v9.72 and higher, add one more parameter for regulatory snapshot
            // ibClient.ClientSocket.reqMktData(1, contract, "", false, false, mktDataOptions);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Make the call to cancel the market data subscription
            ibClient.ClientSocket.cancelMktData(1);
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a ListBox control.
        delegate void SetTextCallback(string text);

        public void AddListBoxItem(string text)
        {
            // See if a new invocation is required form a different thread
            if (this.lbData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddListBoxItem);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Add the text string to the list box
                this.lbData.Items.Add(text);
            }
        }
    }
}
