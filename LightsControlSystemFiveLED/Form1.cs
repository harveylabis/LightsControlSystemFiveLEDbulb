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
        int countdown_seconds_allLED = 0;


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

        private void dateTimeSelectionControls(string pinNumber, bool state)
        {
            if (pinNumber == ON_LED1)
            {
                dtp_dateTime_startTime1.Enabled = state;
                dtp_dateTime_startDate1.Enabled = state;
                dtp_dateTime_stopTime1.Enabled = state;
                dtp_dateTime_stopDate1.Enabled = state;
            } else if (pinNumber == ON_LED2)
            {
                dtp_dateTime_startTime2.Enabled = state;
                dtp_dateTime_startDate2.Enabled = state;
                dtp_dateTime_stopTime2.Enabled = state;
                dtp_dateTime_stopDate2.Enabled = state;
            } else if (pinNumber == ON_LED3)
            {
                dtp_dateTime_startTime3.Enabled = state;
                dtp_dateTime_startDate3.Enabled = state;
                dtp_dateTime_stopTime3.Enabled = state;
                dtp_dateTime_stopDate3.Enabled = state;
            } else if (pinNumber == ON_LED4)
            {
                dtp_dateTime_startTime4.Enabled = state;
                dtp_dateTime_startDate4.Enabled = state;
                dtp_dateTime_stopTime4.Enabled = state;
                dtp_dateTime_stopDate4.Enabled = state;
            } /* else if (pinNumber == ON_LED5)
            {
                dtp_dateTime_startTime5.Enabled = state;
                dtp_dateTime_startDate5.Enabled = state;
                dtp_dateTime_stopTime5.Enabled = state;
                dtp_dateTime_stopDate5.Enabled = state;
            } */
        }


        // LED 1 functions
        // basic control
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

        // countdown timer control
        private void btn_countdownStart1_Click(object sender, EventArgs e)
        {
            countdown_seconds1 = Convert.ToInt32(txtbox_countdownTime1.Text);
            txtbox_countdownTime1.Enabled = false;
            timer_countdown1.Start();
            if (rb_countdownON1.Checked)
            {
                turn(ON_LED1);
                showImage(ON_LED1);
            } else
            {
                turn(OFF_LED1);
                showImage(OFF_LED1);
            }
            lbl_countdownSeconds1.Text = countdown_seconds1.ToString();
        }

        private void timer_countdown1_Tick(object sender, EventArgs e)
        {
            countdown_seconds1--;
            if (countdown_seconds1 == 0)
            {
                if (rb_countdownON1.Checked)
                {
                    turn(OFF_LED1);
                    showImage(OFF_LED1);
                } else
                {
                    turn(ON_LED1);
                    showImage(ON_LED1);
                }
                timer_countdown1.Stop();
                txtbox_countdownTime1.Enabled = true;
            }
            lbl_countdownSeconds1.Text = countdown_seconds1.ToString();
        }

        private void btn_countdownReset1_Click(object sender, EventArgs e)
        {
            txtbox_countdownTime1.Enabled = true;
            turn(OFF_LED1);
            showImage(OFF_LED1);
            timer_countdown1.Stop();
            countdown_seconds1 = 0;
            lbl_countdownSeconds1.Text = countdown_seconds1.ToString();

        }

        // date and time control
        private void btn_dateTime_Set1_Click(object sender, EventArgs e)
        {
            myStartDate1 = dtp_dateTime_startDate1.Value.Date + dtp_dateTime_startTime1.Value.TimeOfDay;
            myStopDate1 = dtp_dateTime_stopDate1.Value.Date + dtp_dateTime_stopTime1.Value.TimeOfDay;
            dateTimeSelectionControls(ON_LED1, false);
            timer_dateTime1.Start();
        }

        private void timer_dateTime1_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeNow1 = DateTime.Now;
            if (!dateTime_start1)
            {
                bool compare_start1 = (dateTimeNow1.Date == myStartDate1.Date) && (dateTimeNow1.Hour == myStartDate1.Hour) && (dateTimeNow1.Minute == myStartDate1.Minute);
                if (compare_start1)
                {
                    if (rb_dateTimeON1.Checked)
                    {
                        turn(ON_LED1);
                        showImage(ON_LED1);
                    } else
                    {
                        turn(OFF_LED1);
                        showImage(OFF_LED1);
                    }
                    dateTime_start1 = true;
                }
            } else
            {
                bool compare_stop1 = (dateTimeNow1.Date == myStopDate1.Date) && (dateTimeNow1.Hour == myStopDate1.Hour) && (dateTimeNow1.Minute == myStopDate1.Minute);
                if (compare_stop1)
                {
                    if (rb_dateTimeON1.Checked)
                    {
                        turn(OFF_LED1);
                        showImage(OFF_LED1);
                    }
                    else
                    {
                        turn(ON_LED1);
                        showImage(ON_LED1);
                    }
                    timer_dateTime1.Stop();
                    dateTimeSelectionControls(ON_LED1, true);
                    dateTime_start1 = false;
                }
            }
        }

        private void btn_dateTime_Reset1_Click(object sender, EventArgs e)
        {
            timer_dateTime1.Stop();
            dateTimeSelectionControls(ON_LED1, true);
            turn(OFF_LED1);
            showImage(OFF_LED1);
            dateTime_start1 = false;
        }

        // LED 2 functions
        // basic control
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

        // countdown timer control
        private void btn_countdownStart2_Click(object sender, EventArgs e)
        {
            countdown_seconds2 = Convert.ToInt32(txtbox_countdownTime2.Text);
            txtbox_countdownTime2.Enabled = false;
            timer_countdown2.Start();
            if (rb_countdownON2.Checked)
            {
                turn(ON_LED2);
                showImage(ON_LED2);
            }
            else
            {
                turn(OFF_LED2);
                showImage(OFF_LED2);
            }
            lbl_countdownSeconds2.Text = countdown_seconds2.ToString();
        }

        private void timer_countdown2_Tick(object sender, EventArgs e)
        {
            countdown_seconds2--;
            if (countdown_seconds2 == 0)
            {
                if (rb_countdownON2.Checked)
                {
                    turn(OFF_LED2);
                    showImage(OFF_LED2);
                }
                else
                {
                    turn(ON_LED2);
                    showImage(ON_LED2);
                }
                timer_countdown2.Stop();
                txtbox_countdownTime2.Enabled = true;
            }
            lbl_countdownSeconds2.Text = countdown_seconds2.ToString();
        }

        private void btn_countdownReset2_Click(object sender, EventArgs e)
        {
            txtbox_countdownTime2.Enabled = true;
            turn(OFF_LED2);
            showImage(OFF_LED2);
            timer_countdown2.Stop();
            countdown_seconds2 = 0;
            lbl_countdownSeconds2.Text = countdown_seconds2.ToString();
        }

        // date and time control
        private void btn_dateTime_Set2_Click(object sender, EventArgs e)
        {
            myStartDate2 = dtp_dateTime_startDate2.Value.Date + dtp_dateTime_startTime2.Value.TimeOfDay;
            myStopDate2 = dtp_dateTime_stopDate2.Value.Date + dtp_dateTime_stopTime2.Value.TimeOfDay;
            dateTimeSelectionControls(ON_LED2, false);
            timer_dateTime2.Start();
        }

        private void timer_dateTime2_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeNow2 = DateTime.Now;
            if (!dateTime_start2)
            {
                bool compare_start2 = (dateTimeNow2.Date == myStartDate2.Date) && (dateTimeNow2.Hour == myStartDate2.Hour) && (dateTimeNow2.Minute == myStartDate2.Minute);
                if (compare_start2)
                {
                    if (rb_dateTimeON2.Checked)
                    {
                        turn(ON_LED2);
                        showImage(ON_LED2);
                    }
                    else
                    {
                        turn(OFF_LED2);
                        showImage(OFF_LED2);
                    }
                    dateTime_start2 = true;
                }
            }
            else
            {
                bool compare_stop2 = (dateTimeNow2.Date == myStopDate2.Date) && (dateTimeNow2.Hour == myStopDate2.Hour) && (dateTimeNow2.Minute == myStopDate2.Minute);
                if (compare_stop2)
                {
                    if (rb_dateTimeON2.Checked)
                    {
                        turn(OFF_LED2);
                        showImage(OFF_LED2);
                    }
                    else
                    {
                        turn(ON_LED2);
                        showImage(ON_LED2);
                    }
                    timer_dateTime2.Stop();
                    dateTimeSelectionControls(ON_LED2, true);
                    dateTime_start2 = false;
                }
            }
        }

        private void btn_dateTime_Reset2_Click(object sender, EventArgs e)
        {
            timer_dateTime2.Stop();
            dateTimeSelectionControls(ON_LED2, true);
            turn(OFF_LED2);
            showImage(OFF_LED2);
            dateTime_start2 = false;
        }


        // LED 3 functions
        // basic control
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

        // countdown timer control
        private void btn_countdownStart3_Click(object sender, EventArgs e)
        {
            countdown_seconds3 = Convert.ToInt32(txtbox_countdownTime3.Text);
            txtbox_countdownTime3.Enabled = false;
            timer_countdown3.Start();
            if (rb_countdownON3.Checked)
            {
                turn(ON_LED3);
                showImage(ON_LED3);
            }
            else
            {
                turn(OFF_LED3);
                showImage(OFF_LED3);
            }
            lbl_countdownSeconds3.Text = countdown_seconds3.ToString();
        }

        private void timer_countdown3_Tick(object sender, EventArgs e)
        {
            countdown_seconds3--;
            if (countdown_seconds3 == 0)
            {
                if (rb_countdownON3.Checked)
                {
                    turn(OFF_LED3);
                    showImage(OFF_LED3);
                }
                else
                {
                    turn(ON_LED3);
                    showImage(ON_LED3);
                }
                timer_countdown3.Stop();
                txtbox_countdownTime3.Enabled = true;
            }
            lbl_countdownSeconds3.Text = countdown_seconds3.ToString();
        }

        private void btn_countdownReset3_Click(object sender, EventArgs e)
        {
            txtbox_countdownTime3.Enabled = true;
            turn(OFF_LED3);
            showImage(OFF_LED3);
            timer_countdown3.Stop();
            countdown_seconds3 = 0;
            lbl_countdownSeconds3.Text = countdown_seconds3.ToString();
        }

        // date and time control
        private void btn_dateTime_Set3_Click(object sender, EventArgs e)
        {
            myStartDate3 = dtp_dateTime_startDate3.Value.Date + dtp_dateTime_startTime3.Value.TimeOfDay;
            myStopDate3 = dtp_dateTime_stopDate3.Value.Date + dtp_dateTime_stopTime3.Value.TimeOfDay;
            dateTimeSelectionControls(ON_LED3, false);
            timer_dateTime3.Start();
        }

        private void timer_dateTime3_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeNow3 = DateTime.Now;
            if (!dateTime_start3)
            {
                bool compare_start3 = (dateTimeNow3.Date == myStartDate3.Date) && (dateTimeNow3.Hour == myStartDate3.Hour) && (dateTimeNow3.Minute == myStartDate3.Minute);
                if (compare_start3)
                {
                    if (rb_dateTimeON3.Checked)
                    {
                        turn(ON_LED3);
                        showImage(ON_LED3);
                    }
                    else
                    {
                        turn(OFF_LED3);
                        showImage(OFF_LED3);
                    }
                    dateTime_start3 = true;
                }
            }
            else
            {
                bool compare_stop3 = (dateTimeNow3.Date == myStopDate3.Date) && (dateTimeNow3.Hour == myStopDate3.Hour) && (dateTimeNow3.Minute == myStopDate3.Minute);
                if (compare_stop3)
                {
                    if (rb_dateTimeON3.Checked)
                    {
                        turn(OFF_LED3);
                        showImage(OFF_LED3);
                    }
                    else
                    {
                        turn(ON_LED3);
                        showImage(ON_LED3);
                    }
                    timer_dateTime3.Stop();
                    dateTimeSelectionControls(ON_LED3, true);
                    dateTime_start3 = false;
                }
            }
        }

        private void btn_dateTime_Reset3_Click(object sender, EventArgs e)
        {
            timer_dateTime3.Stop();
            dateTimeSelectionControls(ON_LED3, true);
            turn(OFF_LED3);
            showImage(OFF_LED3);
            dateTime_start3 = false;
        }

        // LED 4 functions
        // basic controls
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

        // countdown timer control
        private void btn_countdownStart4_Click(object sender, EventArgs e)
        {
            countdown_seconds4 = Convert.ToInt32(txtbox_countdownTime4.Text);
            txtbox_countdownTime4.Enabled = false;
            timer_countdown4.Start();
            if (rb_countdownON4.Checked)
            {
                turn(ON_LED4);
                showImage(ON_LED4);
            }
            else
            {
                turn(OFF_LED4);
                showImage(OFF_LED4);
            }
            lbl_countdownSeconds4.Text = countdown_seconds4.ToString();
        }

        private void timer_countdown4_Tick(object sender, EventArgs e)
        {
            countdown_seconds4--;
            if (countdown_seconds4 == 0)
            {
                if (rb_countdownON4.Checked)
                {
                    turn(OFF_LED4);
                    showImage(OFF_LED4);
                }
                else
                {
                    turn(ON_LED4);
                    showImage(ON_LED4);
                }
                timer_countdown4.Stop();
                txtbox_countdownTime4.Enabled = true;
            }
            lbl_countdownSeconds4.Text = countdown_seconds4.ToString();
        }

        private void btn_countdownReset4_Click(object sender, EventArgs e)
        {
            txtbox_countdownTime4.Enabled = true;
            turn(OFF_LED4);
            showImage(OFF_LED4);
            timer_countdown4.Stop();
            countdown_seconds4 = 0;
            lbl_countdownSeconds4.Text = countdown_seconds4.ToString();
        }

        // date and time control
        private void btn_dateTime_Set4_Click(object sender, EventArgs e)
        {
            myStartDate4 = dtp_dateTime_startDate4.Value.Date + dtp_dateTime_startTime4.Value.TimeOfDay;
            myStopDate4 = dtp_dateTime_stopDate4.Value.Date + dtp_dateTime_stopTime4.Value.TimeOfDay;
            dateTimeSelectionControls(ON_LED4, false);
            timer_dateTime4.Start();
        }

        private void timer_dateTime4_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeNow4 = DateTime.Now;
            if (!dateTime_start4)
            {
                bool compare_start4 = (dateTimeNow4.Date == myStartDate4.Date) && (dateTimeNow4.Hour == myStartDate4.Hour) && (dateTimeNow4.Minute == myStartDate4.Minute);
                if (compare_start4)
                {
                    if (rb_dateTimeON4.Checked)
                    {
                        turn(ON_LED4);
                        showImage(ON_LED4);
                    }
                    else
                    {
                        turn(OFF_LED4);
                        showImage(OFF_LED4);
                    }
                    dateTime_start4 = true;
                }
            }
            else
            {
                bool compare_stop4 = (dateTimeNow4.Date == myStopDate4.Date) && (dateTimeNow4.Hour == myStopDate4.Hour) && (dateTimeNow4.Minute == myStopDate4.Minute);
                if (compare_stop4)
                {
                    if (rb_dateTimeON4.Checked)
                    {
                        turn(OFF_LED4);
                        showImage(OFF_LED4);
                    }
                    else
                    {
                        turn(ON_LED4);
                        showImage(ON_LED4);
                    }
                    timer_dateTime4.Stop();
                    dateTimeSelectionControls(ON_LED4, true);
                    dateTime_start4 = false;
                }
            }
        }

        private void btn_dateTime_Reset4_Click(object sender, EventArgs e)
        {
            timer_dateTime4.Stop();
            dateTimeSelectionControls(ON_LED4, true);
            turn(OFF_LED4);
            showImage(OFF_LED4);
            dateTime_start4 = false;
        }

        // LED 5 functions
        // basic controls
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

        // countdown timer control
        private void btn_countdownStart5_Click(object sender, EventArgs e)
        {
            countdown_seconds5 = Convert.ToInt32(txtbox_countdownTime5.Text);
            txtbox_countdownTime5.Enabled = false;
            timer_countdown5.Start();
            if (rb_countdownON5.Checked)
            {
                turn(ON_LED5);
                showImage(ON_LED5);
            }
            else
            {
                turn(OFF_LED5);
                showImage(OFF_LED5);
            }
            lbl_countdownSeconds5.Text = countdown_seconds5.ToString();
        }

        private void timer_countdown5_Tick(object sender, EventArgs e)
        {
            countdown_seconds5--;
            if (countdown_seconds5 == 0)
            {
                if (rb_countdownON5.Checked)
                {
                    turn(OFF_LED5);
                    showImage(OFF_LED5);
                }
                else
                {
                    turn(ON_LED5);
                    showImage(ON_LED5);
                }
                timer_countdown5.Stop();
                txtbox_countdownTime5.Enabled = true;
            }
            lbl_countdownSeconds5.Text = countdown_seconds5.ToString();
        }

        private void btn_countdownReset5_Click(object sender, EventArgs e)
        {
            txtbox_countdownTime5.Enabled = true;
            turn(OFF_LED5);
            showImage(OFF_LED5);
            timer_countdown5.Stop();
            countdown_seconds5 = 0;
            lbl_countdownSeconds5.Text = countdown_seconds5.ToString();
        }

        // all LED functions
        // basic controls
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

        // countdown timer control
        private void btn_countdownStart_allLED_Click(object sender, EventArgs e)
        {
            countdown_seconds_allLED = Convert.ToInt32(txtbox_countdownTime_allLED.Text);
            txtbox_countdownTime_allLED.Enabled = false;
            timer_countdown_allLED.Start();
            if (rb_countdownON_allLED.Checked)
            {
                turn(ON_allLED);
                showImage(ON_allLED);
            }
            else
            {
                turn(OFF_allLED);
                showImage(OFF_allLED);
            }
            lbl_countdownSeconds_allLED.Text = countdown_seconds_allLED.ToString();
        }

        private void timer_countdown_allLED_Tick(object sender, EventArgs e)
        {
            countdown_seconds_allLED--;
            if (countdown_seconds_allLED == 0)
            {
                if (rb_countdownON_allLED.Checked)
                {
                    turn(OFF_allLED);
                    showImage(OFF_allLED);
                }
                else
                {
                    turn(ON_allLED);
                    showImage(ON_allLED);
                }
                timer_countdown_allLED.Stop();
                txtbox_countdownTime_allLED.Enabled = true;
            }
            lbl_countdownSeconds_allLED.Text = countdown_seconds_allLED.ToString();
        }

        private void btn_countdownReset_allLED_Click(object sender, EventArgs e)
        {
            txtbox_countdownTime_allLED.Enabled = true;
            turn(OFF_allLED);
            showImage(OFF_allLED);
            timer_countdown_allLED.Stop();
            countdown_seconds_allLED = 0;
            lbl_countdownSeconds_allLED.Text = countdown_seconds_allLED.ToString();
        }
    }
}
