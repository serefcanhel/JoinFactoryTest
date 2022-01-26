using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinFactoryTestV1
{
    public partial class Form1 : Form
    {
        string dataIN;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;


            gBoxSerial.Visible              = false;
            gBoxTCPIP.Visible               = false;

            btnClose.Enabled                = false;
            btnStartFactoryTest.Enabled     = false;
            btnRelayCondition.Enabled       = false;
            btnGroundCondition.Enabled      = false;
            btnACVoltageCondition.Enabled   = false;
            
            Form1_Load();
        }

        private void Form1_Load()
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxDeviceComPort.Items.AddRange(ports);
        }

        /*@brief Events_Disconnected, Function works when client disconnect from server.
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @retval None
         */
        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                lServerStatus.Text = "KAPALI";
                tBoxServerStatus.Text += $"Server connected {Environment.NewLine}";
            });
        }

        /*@brief Events_DataReceived, Function works when data received from server.
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @retval None
         */
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                data(e);
                //textBox1.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        /*@brief Events_Connected, Function works when client connect from server.
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @retval None
         */
        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                tBoxServerStatus.Text += $"Server connected {Environment.NewLine}";
                lServerStatus.Text = "AÇIK";
            });
        }

        SimpleTcpClient client;
        SerialPort serialPort1 = new SerialPort();

        /* @brief rButSerial_CheckedChanged, Checks Serial Radio Button
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null 
         */
        private void rButSerial_CheckedChanged(object sender, EventArgs e)
        {
            if(rButSerial.Checked == true)
            {
                gBoxSerial.Visible = true;
            }
            else
            {
                rButSerial.Checked = false;
                gBoxSerial.Visible = false;
            }
        }

        /*@brief rButTCPIP_CheckedChanged, Checks TCP/IP Radio Button
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null 
         */
        private void rButTCPIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rButTCPIP.Checked == true)
            {
                gBoxTCPIP.Visible = true;
            }
            else
            {
                rButTCPIP.Checked = false;
                gBoxTCPIP.Visible = false;
            }
        }

        /* @brief btnOpen_Click,  Open Button Functions
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null 
         */
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                if (rButSerial.Checked == true)
                {
                    OpenSerialPort();
                }
                else if (rButTCPIP.Checked == true)
                {
                    OpenTCPIPClient();
                }
                btnRelayCondition.Enabled       = true;
                btnGroundCondition.Enabled      = true;
                btnACVoltageCondition.Enabled   = true;
                btnStartFactoryTest.Enabled     = true;
                btnClose.Enabled                = true;
                btnOpen.Enabled                 = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lütfen bağlantı şeklini seçiniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*@brief serialPort1_DataReceived, Serial Data Receive Function
         * 
        * @param sender    = Reference to the controlled object
        * @param e         = Event data
        * 
        * @return: Null
        */
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(Showdata));
        }

        /* @brief Showdata, Data manipulation of serial data function
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void Showdata(object sender, EventArgs e)
        {
            textBox1.Text += dataIN;
        }

        /*@brief OpenSerialPort, Opens serial port
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void OpenSerialPort()
        {
            try
            {
                if (tBoxServerAddr.Text == "")
                {
                    MessageBox.Show("LÜTFEN SERİ GİRİŞ SEÇİNİZ!!");
                }
                else
                {
                    serialPort1.PortName = cBoxDeviceComPort.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");

                    serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived);

                    serialPort1.Open();

                    btnClose.Enabled = true;
                    btnStartFactoryTest.Enabled = true;
                    btnOpen.Enabled = false;
                    lServerStatus.Text = "AÇ";
                    progressBar1.Value = 100;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort1.Close();
            }
        }

        /*@brief OpenTCPIPClient, Opens TCP/IP Client
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void OpenTCPIPClient()
        {
            try
            {
                client = new(tBoxServerAddr.Text);
                client.Events.Connected     += Events_Connected;
                client.Events.DataReceived  += Events_DataReceived;
                client.Events.Disconnected  += Events_Disconnected;
                client.Connect();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Client server bağlantısı kurulamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* @brief btnClose_Click, Close button function
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (rButSerial.Checked == true)
                {
                    CloseSerialPort();
                }
                else if(rButTCPIP.Checked == true)
                {
                    CloseTCPIPClient();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Client server kapatırken bir hata ile karşılaşıldı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*@brief CloseSerialPort, Close Serial Ports
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void CloseSerialPort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                ClearButtons();
                CloseCondition();
            }
        }

        /*@brief CloseTCPIPClient, Close TCP/IP client server
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void CloseTCPIPClient()
        {
            client.Disconnect();
            ClearButtons();
            CloseCondition();
        }

        /*@brief CloseCondition, Clear application if serial port or TCP/IP server is closed.
         * 
         * @param None
         * 
         * @retval None
         */
        private void CloseCondition()
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            btnRelay.Enabled = false;
            btnStartFactoryTest.Enabled = false;
            progressBar1.Value = 0;
            lServerStatus.Text = "KAPALI";
        }

        /*@brief btnRelay_Click, Relay open/close button function
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void btnRelay_Click(object sender, EventArgs e)
        {
            if(btnRelay.Text == "RÖLE AÇ")
            {
                btnRelay.Text = "RÖLE KAPAT";
                byte[] OpenRelayBuffer = { 0xB1, 0x05, 0x05, 0x01, 0xCC };
                if (client.IsConnected)
                {
                    client.Send(OpenRelayBuffer);
                }
            }
            else
            {
                btnRelay.Text = "RÖLE AÇ";
                byte[] CloseRelayBuffer = { 0xB1, 0x05, 0x05, 0x00, 0xCC };
                if (client.IsConnected)
                {
                    client.Send(CloseRelayBuffer);
                    
                }
            }
        }

        /*@brief data, Data manipulation for TCP/IP.
         * 
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void data(DataReceivedEventArgs e)
        {
            //textBox1.Text += $"{e.IpPort}:{Encoding.UTF8.(e.Data)}{Environment.NewLine}";
            string ReceivedData = "";
            foreach(char character in e.Data)
            {
                ReceivedData += String.Format("{0:X}", Convert.ToInt32(character));
            }
            textBox1.Text += ReceivedData+Environment.NewLine;

            if (ReceivedData == "B1550B1")
            {
                if(btnRelay.Text == "RÖLE KAPAT")
                {
                    btnRelayCondition.Text = "AÇIK";
                    btnRelayCondition.BackColor = Color.Green;
                    byte[] EarthConnection = { 0xB1, 0x04, 0x07, 0xCC };
                    client.Send(EarthConnection);
                }
            }
            if (ReceivedData == "B1551B0")
            {
               if(btnRelay.Text == "RÖLE AÇ")
                {
                    btnRelayCondition.Text = "KAPALI";
                    btnRelayCondition.BackColor = Color.Red;
                    byte[] ACVoltage = { 0xB1, 0x04, 0x01, 0xCC };
                    client.Send(ACVoltage);
                }              
            }
            if(ReceivedData == "B1571B2")
            {
                btnGroundCondition.Text = "GEÇTİ";
                btnGroundCondition.BackColor = Color.Green;
                byte[] ACVoltage = { 0xB1, 0x04, 0x01, 0xCC };
                client.Send(ACVoltage);
            }
            if(ReceivedData == "B1511B4")
            {
                btnACVoltageCondition.Text = "KAPALI";
                btnACVoltageCondition.BackColor = Color.Red;
            }
        }

        /*@brief btnStartFactoryTest_Click, Start factory test button function
         * 
         * @param sender    = Reference to the controlled object
         * @param e         = Event data
         * 
         * @return: Null
         */
        private void btnStartFactoryTest_Click(object sender, EventArgs e)
        {
            byte[] FactoryTestStartCode = { 0xB1, 0x08, 0x06, 0x00, 0x7F, 0x00, 0x00 };
            client.Send(FactoryTestStartCode);
        }

        /*@brief ClearButtons, Clears all buttons
         * 
         * @param None
         * 
         * @return: Null
         */
        private void ClearButtons()
        {
            btnACVoltageCondition.Text  = "";
            btnGroundCondition.Text     = "";
            btnRelayCondition.Text      = "";

            btnRelayCondition.BackColor     = Color.White;
            btnGroundCondition.BackColor    = Color.White;
            btnACVoltageCondition.BackColor = Color.White;

            btnClose.Enabled                = false;
            btnStartFactoryTest.Enabled     = false;
            btnOpen.Enabled                 = true;
            btnRelay.Text                   = "RÖLE AÇ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Select(textBox1.TextLength, 0);
            textBox1.ScrollToCaret();

        }
    }
}
