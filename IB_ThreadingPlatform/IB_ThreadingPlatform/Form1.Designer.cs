
namespace IB_ThreadingPlatform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbSymbol = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.ExchangeSymbol = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.Open_Closing_time = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(103, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(103, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop\t";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbSymbol
            // 
            this.tbSymbol.Location = new System.Drawing.Point(0, 142);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(187, 23);
            this.tbSymbol.TabIndex = 8;
            this.tbSymbol.Text = "MSFT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 618);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1345, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "when data has been updated.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1245, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "TimerTick";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1023, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 23);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "AAPL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 23);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(579, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 23);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(772, 113);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 23);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(965, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 23);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1158, 113);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(187, 23);
            this.textBox8.TabIndex = 17;
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.HorizontalScrollbar = true;
            this.lbData.ItemHeight = 15;
            this.lbData.Location = new System.Drawing.Point(54, 404);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(1055, 199);
            this.lbData.TabIndex = 18;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "1.7 columns in row to display the next 7 days regular trading hours.",
            "2.",
            "3.",
            "3.",
            "4.",
            "5.",
            "6.",
            "7."});
            this.listBox2.Location = new System.Drawing.Point(193, 229);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(187, 154);
            this.listBox2.TabIndex = 19;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(386, 229);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(187, 154);
            this.listBox3.TabIndex = 20;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(579, 229);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(187, 154);
            this.listBox4.TabIndex = 21;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.HorizontalScrollbar = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(772, 229);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(187, 154);
            this.listBox5.TabIndex = 22;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.HorizontalScrollbar = true;
            this.listBox6.ItemHeight = 15;
            this.listBox6.Location = new System.Drawing.Point(965, 229);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(187, 154);
            this.listBox6.TabIndex = 23;
            // 
            // ExchangeSymbol
            // 
            this.ExchangeSymbol.Location = new System.Drawing.Point(0, 113);
            this.ExchangeSymbol.Name = "ExchangeSymbol";
            this.ExchangeSymbol.Size = new System.Drawing.Size(187, 23);
            this.ExchangeSymbol.TabIndex = 24;
            this.ExchangeSymbol.TextChanged += new System.EventHandler(this.ExchangeSymbol_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(965, 142);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(187, 23);
            this.textBox10.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(772, 142);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(187, 23);
            this.textBox11.TabIndex = 26;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(579, 142);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(187, 23);
            this.textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(386, 142);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(187, 23);
            this.textBox13.TabIndex = 28;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(193, 113);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(187, 23);
            this.textBox14.TabIndex = 29;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1158, 142);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(187, 23);
            this.textBox15.TabIndex = 30;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(579, 171);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(187, 23);
            this.textBox16.TabIndex = 31;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(386, 171);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(187, 23);
            this.textBox17.TabIndex = 32;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(193, 171);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(187, 23);
            this.textBox18.TabIndex = 33;
            // 
            // Open_Closing_time
            // 
            this.Open_Closing_time.Location = new System.Drawing.Point(0, 171);
            this.Open_Closing_time.Name = "Open_Closing_time";
            this.Open_Closing_time.Size = new System.Drawing.Size(187, 23);
            this.Open_Closing_time.TabIndex = 35;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(1158, 171);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(187, 23);
            this.textBox19.TabIndex = 36;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(965, 171);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(187, 23);
            this.textBox21.TabIndex = 37;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(772, 171);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(187, 23);
            this.textBox22.TabIndex = 38;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(965, 200);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(187, 23);
            this.textBox23.TabIndex = 39;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(772, 200);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(187, 23);
            this.textBox24.TabIndex = 40;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(579, 200);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(187, 23);
            this.textBox25.TabIndex = 41;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(386, 200);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(187, 23);
            this.textBox26.TabIndex = 42;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(193, 200);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(187, 23);
            this.textBox27.TabIndex = 43;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(0, 200);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(187, 23);
            this.textBox28.TabIndex = 44;
            this.textBox28.Text = "Countdown time to opening/closing s";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(1158, 200);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(187, 23);
            this.textBox29.TabIndex = 45;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(1158, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 154);
            this.listBox1.TabIndex = 46;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.HorizontalScrollbar = true;
            this.listBox7.ItemHeight = 15;
            this.listBox7.Location = new System.Drawing.Point(0, 229);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(187, 154);
            this.listBox7.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 682);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.Open_Closing_time);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.ExchangeSymbol);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbSymbol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.TextBox ExchangeSymbol;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox Open_Closing_time;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox7;
    }
}

