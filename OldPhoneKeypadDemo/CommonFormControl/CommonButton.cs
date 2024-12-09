using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonFormControl
{
    public class CommonButton:Button
    {  

        private string custLeftText; 
        public string LeftText
        {
            get => custLeftText;
            set
            {
                // Validate that the value is a single word (no spaces allowed)
                if (string.IsNullOrWhiteSpace(value) || value.Contains(" "))
                {
                    // If in design mode, show a MessageBox to the user
                    if (DesignMode)
                    {
                        MessageBox.Show(
                            "CustomValue must be a single word with no spaces.",
                            "Invalid Input",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }

                    // Throw an exception to prevent invalid assignment
                    throw new ArgumentException("CustomValue must be a single word with no spaces.");
                } 
                custLeftText = value; 
                this.Text = value + " " + RightText;

            }
        }

        private string custRightText;
        public string RightText
        {
            get => custRightText;
            set
            {
                // Validate that the value is a single word (no spaces allowed)
                if (string.IsNullOrWhiteSpace(value) || value.Contains(" "))
                {
                    // If in design mode, show a MessageBox to the user
                    if (DesignMode)
                    {
                        MessageBox.Show(
                            "CustomValue must be a single word with no spaces.",
                            "Invalid Input",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }

                    // Throw an exception to prevent invalid assignment
                    throw new ArgumentException("CustomValue must be a single word with no spaces.");
                }
                custRightText = value;
                this.Text = LeftText + " " + value;
            }
        }
    }
}
