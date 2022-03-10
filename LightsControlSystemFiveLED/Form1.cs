using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LightsControlSystemFiveLED
{
    public partial class Form1 : Form
    {
        // global variables
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        // LED 1 variables
        string ON_LED1 = "1";
        string OFF_LED1 = "a";
        int countdown_seconds1 = 0;
        bool dateTime_start1 = false;
        DateTime myStartDate1;
        DateTime myStopDate1;

        // LED 2 variables
        string ON_LED2 = "2";
        string OFF_LED2 = "b";
        int countdown_seconds2 = 0;
        bool dateTime_start2 = false;
        DateTime myStartDate2;
        DateTime myStopDate2;

        // LED 3 variables
        string ON_LED3 = "3";
        string OFF_LED3 = "c";
        int countdown_seconds3 = 0;
        bool dateTime_start3 = false;
        DateTime myStartDate3;
        DateTime myStopDate3;

        // LED 4 variables
        string ON_LED4 = "4";
        string OFF_LED4 = "d";
        int countdown_seconds4 = 0;
        bool dateTime_start4 = false;
        DateTime myStartDate4;
        DateTime myStopDate4;

        // LED 5 variables
        string ON_LED5 = "5";
        string OFF_LED5 = "e";
        int countdown_seconds5 = 0;
        bool dateTime_start5 = false;
        DateTime myStartDate5;
        DateTime myStopDate5;

        // all LED variables
        string ON_allLED = "6";
        string OFF_allLED = "f";


        public Form1()
        {
            InitializeComponent();
            getAvailableCOMPorts();

            // display port names in combo box
            foreach (string port in ports)
            {
                cbx_portCOMBox.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] == null)
                {
                    cbx_portCOMBox.SelectedItem = ports[0];
                }
            }
        }

        void getAvailableCOMPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connect()
        {
            isConnected = true;
            string selectedPort = cbx_portCOMBox.GetItemText(cbx_portCOMBox.SelectedItem);
            port = new SerialPort(selectedPort, 9600);
            port.ReadTimeout = (2000);
            port.WriteTimeout = (2000);
            try
            {
                port.Open();
                btn_portConnect.Text = "Disconnect";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btn_portConnect.Text = "Connect";
            }
        }

        private void disconnect()
        {
            isConnected = false;
            port.Close();
            btn_portConnect.Text = "Connect";
        }

        private void btn_portConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connect();
            } else
            {
                disconnect();
            }
        }

        private void turn(string command)
        {
            try
            {
                port.WriteLine(command);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showImage(string command)
        {
            if (command == ON_LED1)
            {
                pic_ON_LED1.Visible = true;
                pic_OFF_LED1.Visible = false;
            } else if (command == OFF_LED1)
            {
                pic_ON_LED1.Visible = false;
                pic_OFF_LED1.Visible = true;
            } else if (command == ON_LED2)
            {
                pic_ON_LED2.Visible = true;
                pic_OFF_LED2.Visible = false;
            } else if (command == OFF_LED2)
            {
                pic_ON_LED2.Visible = false;
                pic_OFF_LED2.Visible = true;
            } else if (command == ON_LED3)
            {
                pic_ON_LED3.Visible = true;
                pic_OFF_LED3.Visible = false;
            } else if (command == OFF_LED3)
            {
                pic_ON_LED3.Visible = false;
                pic_OFF_LED3.Visible = true;
            } else if (command == ON_LED4)
            {
                pic_ON_LED4.Visible = true;
                pic_OFF_LED4.Visible = false;
            } else if (command == OFF_LED4)
            {
                pic_ON_LED4.Visible = false;
                pic_OFF_LED4.Visible = true;
            } else if (command == ON_LED5)
            {
                pic_ON_LED5.Visible = true;
                pic_OFF_LED5.Visible = false;
            } else if (command == OFF_LED5)
            {
                pic_ON_LED5.Visible = false;
                pic_OFF_LED5.Visible = true;

            } else if (command == ON_allLED)
            {
                showImage(ON_LED1);
                showImage(ON_LED2);
                showImage(ON_LED3);
                showImage(ON_LED4);
                showImage(ON_LED5);
                pic_ON_allLED.Visible = true;
                pic_OFF_allLED.Visible = false;
            } else if (command == OFF_allLED)
            {
                showImage(OFF_LED1);
                showImage(OFF_LED2);
                showImage(OFF_LED3);
                showImage(OFF_LED4);
                showImage(OFF_LED5);
                pic_ON_allLED.Visible = false;
                pic_OFF_allLED.Visible = true;
            }
        }


        // LED 1 functions
        private void btn_ON_LED1_Click(object sender, EventArgs e)
        {
            turn(ON_LED1);
            showImage(ON_LED1);
        }

        private void btn_OFF_LED1_Click(object sender, EventArgs e)
        {
            turn(OFF_LED1);
            showImage(OFF_LED1);
        }

        // LED 2 functions
        private void btn_ON_LED2_Click(object sender, EventArgs e)
        {
            turn(ON_LED2);
            showImage(ON_LED2);
        }

        private void btn_OFF_LED2_Click(object sender, EventArgs e)
        {
            turn(OFF_LED2);
            showImage(OFF_LED2);
        }

        // LED 3 functions
        private void btn_ON_LED3_Click(object sender, EventArgs e)
        {
            turn(ON_LED3);
            showImage(ON_LED3);
        }

        private void btn_OFF_LED3_Click(object sender, EventArgs e)
        {
            turn(OFF_LED3);
            showImage(OFF_LED3);
        }

        // LED 4 functions
        private void btn_ON_LED4_Click(object sender, EventArgs e)
        {
            turn(ON_LED4);
            showImage(ON_LED4);
        }

        private void btn_OFF_LED4_Click(object sender, EventArgs e)
        {
            turn(OFF_LED4);
            showImage(OFF_LED4);
        }

        // LED 5 functions
        private void btn_ON_LED5_Click(object sender, EventArgs e)
        {
            turn(ON_LED5);
            showImage(ON_LED5);
        }

        private void btn_OFF_LED5_Click(object sender, EventArgs e)
        {
            turn(OFF_LED5);
            showImage(OFF_LED5);
        }

        // all LED functions
        private void btn_ON_allLED_Click(object sender, EventArgs e)
        {
            turn(ON_allLED);
            showImage(ON_allLED);
            
        }

        private void btn_OFF_allLED_Click(object sender, EventArgs e)
        {
            turn(OFF_allLED);
            showImage(OFF_allLED);
        }
    }
}
