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
        List<TextBox> ExchangeNames = new List<TextBox>();
        List<TextBox> Open_Closing_Times = new List<TextBox>();
        List<ListBox> NextDayDateTimes = new List<ListBox>();
        List<TextBox> ToCloseTextBox = new List<TextBox>();
        List<DateTime> timesToOpen = new List<DateTime>();
        List<DateTime> timesToClosed = new List<DateTime>();

        delegate void SetTextCallback(string text);

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


            UtcNow.AppendText(DateTime.UtcNow.ToShortTimeString());
            // For IB TWS API version 9.72 and higher, implement this
            // signal-handling code. Otherwise comment it out.

            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();
            new Thread(() =>
            {
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
            Contract contract1 = CreateContract(ExchangeSymbol1.Text);
            Contract contract2 = CreateContract(ExchangeSymbol2.Text);
            Contract contract3 = CreateContract(ExchangeSymbol3.Text);
            Contract contract4 = CreateContract(ExchangeSymbol4.Text);
            Contract contract5 = CreateContract(ExchangeSymbol5.Text);
            Contract contract6 = CreateContract(ExchangeSymbol6.Text);
            Contract contract7 = CreateContract(ExchangeSymbol7.Text);

            // Create a new TagValueList object (for API version 9.71 and later) 
            List<IBApi.TagValue> mktDataOptions = new List<IBApi.TagValue>();
            GetAllTextBoxExchangeName();
            GetAllListBoxNextDayDateTimes();
            GetAllTextBoxOpenClosing();
            GetAllToCloseTextBox();
            contract1.ComboLegsDescription = "1";

            // If using delayed market data subscription un-comment 
            // the line below to request delayed data
            ibClient.ClientSocket.reqMarketDataType(3);
            // Kick off the subscription for real-time data (add the mktDataOptions list for API v9.71)
            ibClient.ClientSocket.reqMktData(1, contract1, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqMktData(1, contract2, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqMktData(1, contract3, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqMktData(1, contract4, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqMktData(1, contract5, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqMktData(1, contract6, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqMktData(1, contract7, "", false, false, mktDataOptions);
            // For API v9.72 and higher, add one more parameter for regulatory snapshot
            // ibClient.ClientSocket.reqMktData(1, contract, "", false, false, mktDataOptions);
            ibClient.ClientSocket.reqContractDetails(1, contract1);
            ibClient.ClientSocket.reqContractDetails(1, contract2);
            ibClient.ClientSocket.reqContractDetails(1, contract3);
            ibClient.ClientSocket.reqContractDetails(1, contract4);
            ibClient.ClientSocket.reqContractDetails(1, contract5);
            ibClient.ClientSocket.reqContractDetails(1, contract6);
            ibClient.ClientSocket.reqContractDetails(1, contract7);

        }
        private Contract CreateContract(string symbol)
        {
            // Create a new contract to specify the security we are searching for
            IBApi.Contract contract = new IBApi.Contract();

            // Set the underlying stock symbol from the tbSymbol text box
            contract.Symbol = symbol;
            // Set the Security type to STK for a Stock
            contract.SecType = "STK";
            // Use "SMART" as the general exchange
            contract.Exchange = "SMART";
            // Set the primary exchange (sometimes called Listing exchange)
            // Use either NYSE or ISLAND
            contract.PrimaryExch = "NASDAQ";
            // Set the currency to USD
            contract.Currency = "USD";
            return contract;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Make the call to cancel the market data subscription
            ibClient.ClientSocket.cancelMktData(1);
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a ListBox control.

        //public void AddListBoxItem(string text)
        //{
        //    // See if a new invocation is required form a different thread
        //    if (this.lbData.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(AddListBoxItem);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        // Add the text string to the list box
        //        this.lbData.Items.Add(text);
        //    }
        //}
        //public void AddExchangeSymbolItem(string text)
        //{
        //    if (this.lbData.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(AddExchangeSymbolItem);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.tbSymbol.AppendText(text);
        //    }
        //}
        public void AddOpen_Closing_time(string text)
        {

            if (this.lbData.InvokeRequired)
            {
                var st = chekingOpenTime(text);
                for (int i = 0; i < st.Count; i++)
                {
                    DateTime openTime = stringConvertToOpenDateTime(st[i]);
                    if (openTime > DateTime.UtcNow)
                    {
                        timesToOpen.Add(openTime);
                        break;
                    }
                }

                for (int i = 0; i < st.Count; i++)
                {
                    DateTime closedTime = stringConvertToClosedDateTime(st[i]);
                    if (closedTime > DateTime.UtcNow)
                    {
                        timesToClosed.Add(closedTime);
                        break;
                    }
                }
                SetTextCallback d = new SetTextCallback(AddOpen_Closing_time);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                foreach (var item in Open_Closing_Times)
                {
                    if (item.Text == "")
                    {
                        item.AppendText(stringConvertToOpenDateTime(text.Substring(0, 27)).ToShortTimeString() + " - " + stringConvertToClosedDateTime(text.Substring(0, 27)).ToShortTimeString());
                        break;
                    }
                }
            }
        }
        public DateTime stringConvertToOpenDateTime(string text)
        {
            DateTime dateTime = new DateTime(
               Convert.ToInt32(text.Substring(0, 4)),
               Convert.ToInt32(text.Substring(4, 2)),
               Convert.ToInt32(text.Substring(6, 2)),
               Convert.ToInt32(text.Substring(9, 2)),
               Convert.ToInt32(text.Substring(11, 2)),
               0
               );
            return dateTime;
        }
        public DateTime stringConvertToClosedDateTime(string text)
        {
            DateTime dateTime = new DateTime(
               Convert.ToInt32(text.Substring(14, 4)),
               Convert.ToInt32(text.Substring(18, 2)),
               Convert.ToInt32(text.Substring(20, 2)),
               Convert.ToInt32(text.Substring(23, 2)),
               Convert.ToInt32(text.Substring(25, 2)),
               0
               );
            return dateTime;
        }

        public List<string> chekingOpenTime(string text)
        {
            List<string> validDay = new List<string>();
            var daysTime = text.Split(';').ToList();
            foreach (var item in daysTime)
            {
                string st = item.Substring(9, 6);
                if (item.Substring(9, 6) != "CLOSED")
                {
                    validDay.Add(item);
                }
            }
            return validDay;
        }

        public void AddNext7dayTimes(string text)
        {
            if (this.lbData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddNext7dayTimes);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                foreach (var item in NextDayDateTimes)
                {
                    if (item.Items.Count == 1 || item.Items.Count == 0)
                    {
                        string[] daysList = text.Split(";");
                        for (int i = 0; i < daysList.Length; i++)
                        {
                            item.Items.Add((i + 1) + ". " + daysList[i]);
                        }
                        break;
                    }
                }

            }
        }

        public void AddLongName(string text)
        {
            if (this.lbData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddLongName);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                foreach (var item in ExchangeNames)
                {
                    if (item.Text == "")
                    {
                        item.AppendText(text);
                        break;
                    }
                }
            }
        }


        public void GetAllTextBoxExchangeName()
        {
            ExchangeNames.Add(ExchangeName1);
            ExchangeNames.Add(ExchangeName2);
            ExchangeNames.Add(ExchangeName3);
            ExchangeNames.Add(ExchangeName4);
            ExchangeNames.Add(ExchangeName5);
            ExchangeNames.Add(ExchangeName6);
            ExchangeNames.Add(ExchangeName7);
        }

        public void GetAllTextBoxOpenClosing()
        {
            Open_Closing_Times.Add(Open_Closing_time1);
            Open_Closing_Times.Add(Open_Closing_time2);
            Open_Closing_Times.Add(Open_Closing_time3);
            Open_Closing_Times.Add(Open_Closing_time4);
            Open_Closing_Times.Add(Open_Closing_time5);
            Open_Closing_Times.Add(Open_Closing_time6);
            Open_Closing_Times.Add(Open_Closing_time7);
        }

        public void GetAllListBoxNextDayDateTimes()
        {
            NextDayDateTimes.Add(NextDayDateTime1);
            NextDayDateTimes.Add(NextDayDateTime2);
            NextDayDateTimes.Add(NextDayDateTime3);
            NextDayDateTimes.Add(NextDayDateTime4);
            NextDayDateTimes.Add(NextDayDateTime5);
            NextDayDateTimes.Add(NextDayDateTime6);
            NextDayDateTimes.Add(NextDayDateTime7);
        }
        public void GetAllToCloseTextBox()
        {
            ToCloseTextBox.Add(ToCloseTextBox1);
            ToCloseTextBox.Add(ToCloseTextBox2);
            ToCloseTextBox.Add(ToCloseTextBox3);
            ToCloseTextBox.Add(ToCloseTextBox4);
            ToCloseTextBox.Add(ToCloseTextBox5);
            ToCloseTextBox.Add(ToCloseTextBox6);
            ToCloseTextBox.Add(ToCloseTextBox7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < timesToClosed.Count - 1; i++)
            //{
            //    System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            //    t.Interval = 500;
            //    t.Tick += (s, args) => t_Tick(timesToClosed[i], ToCloseTextBox[i]);
            //    TimeSpan ts = timesToClosed[i].Subtract(DateTime.UtcNow);
            //    ToCloseTextBox[i].ResetText();
            //    ToCloseTextBox[i].AppendText(ts.ToString("h' : 'm' : 's"));
            //    t.Start();
            //}
            //for (int i = 0; i < timesToOpen.Count; i++)
            //{
            //    System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
            //    t2.Interval = 500;
            //    t2.Tick += new EventHandler(t_Tick2);
            //    TimeSpan ts = DateTime.UtcNow.Subtract(timesToOpen[i]);
            //    ToCloseTextBox1.ResetText();
            //    ToCloseTextBox1.AppendText(ts.ToString("h' : 'm' : 's"));
            //    t2.Start();
            //}

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 500;
            t.Tick += (s, args) => t_Tick(timesToClosed.First(), ToCloseTextBox.First());
            TimeSpan ts = timesToClosed.First().Subtract(DateTime.UtcNow);
            ToCloseTextBox.First().ResetText();
            ToCloseTextBox.First().AppendText(ts.ToString("h' : 'm' : 's"));
            t.Start();

            System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
            t2.Interval = 500;
            t2.Tick += new EventHandler(t_Tick2);
            TimeSpan st = timesToOpen.First().Subtract(DateTime.UtcNow);
            Timer1.ResetText();
            ToCloseTextBox1.AppendText(st.ToString("h' : 'm' : 's"));
            t2.Start();
        }
        void t_Tick2(object sender, EventArgs e)
        {
            Timer1.ResetText();
            TimeSpan ts = timesToOpen.First().Subtract(DateTime.UtcNow);
            Timer1.AppendText(ts.ToString("h' : 'm' : 's"));
        }

        void t_Tick(DateTime text, TextBox textBox)
        {
            textBox.ResetText();
            TimeSpan ts = text.Subtract(DateTime.UtcNow);
            textBox.AppendText(ts.ToString("h' : 'm' : 's"));
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < ExchangeNames.Count; i++)
            {
                ExchangeNames[i].ResetText();
                Open_Closing_Times[i].ResetText();
                NextDayDateTimes[i].Items.Clear();
            };
            ExchangeNames = new List<TextBox>();
            Open_Closing_Times = new List<TextBox>();
            NextDayDateTimes = new List<ListBox>();
            btnStart_Click(sender, e);
            textBox1.ResetText();
            textBox1.AppendText(DateTime.UtcNow.ToString());
        }
    }
}
