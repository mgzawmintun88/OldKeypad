using CommonFormControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OldPhoneKeypadDemo
{
    public partial class frmMain : Form
    {
        string spaceChar = "-";
        string backChar = "<";
        private string[] charsArray; // Array of characters to cycle through
        private Timer clickTimer;
        private int clickCount;
        private const int clickInterval = 800; // 2 seconds
        private string strText = string.Empty;
        public frmMain()
        {
            InitializeComponent();
            // Initialize timer
            clickTimer = new Timer
            {
                Interval = clickInterval
            };
            clickTimer.Tick += OnTimerTick;
            txtDisplay.Focus();
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            try
            {
                clickTimer.Stop();
                clickCount = 0;
                if (strText == backChar)
                {
                    // Check if the TextBox is not empty
                    if (txtDisplay.Text.Length > 0)
                    {
                        // Remove the last character using Substring
                        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                    }
                }
                else
                {
                    txtDisplay.AppendText(strText);
                }
                strText = string.Empty;
                txtDisplay.Focus();
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                txtDisplay.SelectionLength = 0;
            }
            catch (Exception ex)
            { 
                throw ex;
            } 
        }
        private void btnControl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                int buttonWidth = ((CommonButton)sender).Width;
                if (e.X < buttonWidth / 2)
                {
                    HandleLeftSideClick(sender);
                }
                else
                {
                    HandleRightSideClick(sender);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
        private void HandleLeftSideClick(object sender)
        {
            CommonButton btnControl = (CommonButton)sender;
            DisplayText(btnControl.LeftText);
        }

        private void HandleRightSideClick(object sender)
        {
            CommonButton btnControl = (CommonButton)sender;
            DisplayText(btnControl.RightText);
        }
        private void DisplayText(string btnText)
        {
            try
            {
                char[] charArray = btnText.ToCharArray();
                if (!clickTimer.Enabled)
                {
                    // First click: Start the timer
                    clickTimer.Start();
                    clickCount = 0; // Reset click count
                    strText = string.Empty;
                }

                clickCount++; // Increment click count

                if (txtDisplay.Text.Length < txtDisplay.MaxLength)
                {
                    if (clickCount <= charArray.Length)
                    {
                        // Update button text with the corresponding character
                        strText = AddSpace(charArray[clickCount - 1].ToString());
                    }
                    else
                    {
                        // If click count exceeds array length, cycle back to first index
                        strText = AddSpace(charArray[0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("It reach to max limit.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
        private string AddSpace(string charValue)
        {
            return charValue == spaceChar ? " " : charValue; 
        } 
    }
}
