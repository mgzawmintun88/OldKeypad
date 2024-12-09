namespace OldPhoneKeypadDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn2 = new CommonFormControl.CommonButton();
            this.btn3 = new CommonFormControl.CommonButton();
            this.btn6 = new CommonFormControl.CommonButton();
            this.btn9 = new CommonFormControl.CommonButton();
            this.btnEnter = new CommonFormControl.CommonButton();
            this.btn5 = new CommonFormControl.CommonButton();
            this.btn8 = new CommonFormControl.CommonButton();
            this.btn0 = new CommonFormControl.CommonButton();
            this.btnStar = new CommonFormControl.CommonButton();
            this.btn7 = new CommonFormControl.CommonButton();
            this.btn4 = new CommonFormControl.CommonButton();
            this.btn1 = new CommonFormControl.CommonButton();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(28, 30);
            this.txtDisplay.MaxLength = 15;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(258, 55);
            this.txtDisplay.TabIndex = 0;
            // 
            // btn2
            // 
            this.btn2.LeftText = "2";
            this.btn2.Location = new System.Drawing.Point(116, 100);
            this.btn2.Name = "btn2";
            this.btn2.RightText = "abc";
            this.btn2.Size = new System.Drawing.Size(82, 35);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2 abc";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn3
            // 
            this.btn3.LeftText = "def";
            this.btn3.Location = new System.Drawing.Point(204, 100);
            this.btn3.Name = "btn3";
            this.btn3.RightText = "3";
            this.btn3.Size = new System.Drawing.Size(82, 35);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "def 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn6
            // 
            this.btn6.LeftText = "mno";
            this.btn6.Location = new System.Drawing.Point(204, 141);
            this.btn6.Name = "btn6";
            this.btn6.RightText = "6";
            this.btn6.Size = new System.Drawing.Size(82, 35);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "mno 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn9
            // 
            this.btn9.LeftText = "wxyz";
            this.btn9.Location = new System.Drawing.Point(204, 182);
            this.btn9.Name = "btn9";
            this.btn9.RightText = "9";
            this.btn9.Size = new System.Drawing.Size(82, 35);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "wxyz 9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btnEnter
            // 
            this.btnEnter.LeftText = ">";
            this.btnEnter.Location = new System.Drawing.Point(204, 223);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.RightText = "#";
            this.btnEnter.Size = new System.Drawing.Size(82, 35);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "> #";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn5
            // 
            this.btn5.LeftText = "5";
            this.btn5.Location = new System.Drawing.Point(116, 141);
            this.btn5.Name = "btn5";
            this.btn5.RightText = "jkl";
            this.btn5.Size = new System.Drawing.Size(82, 35);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5 jkl";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn8
            // 
            this.btn8.LeftText = "8";
            this.btn8.Location = new System.Drawing.Point(116, 182);
            this.btn8.Name = "btn8";
            this.btn8.RightText = "tuv";
            this.btn8.Size = new System.Drawing.Size(82, 35);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8 tuv";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn0
            // 
            this.btn0.LeftText = "0";
            this.btn0.Location = new System.Drawing.Point(116, 223);
            this.btn0.Name = "btn0";
            this.btn0.RightText = "-";
            this.btn0.Size = new System.Drawing.Size(82, 35);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0 -";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btnStar
            // 
            this.btnStar.LeftText = "*";
            this.btnStar.Location = new System.Drawing.Point(28, 223);
            this.btnStar.Name = "btnStar";
            this.btnStar.RightText = "<";
            this.btnStar.Size = new System.Drawing.Size(82, 35);
            this.btnStar.TabIndex = 14;
            this.btnStar.Text = "* <";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn7
            // 
            this.btn7.LeftText = "7";
            this.btn7.Location = new System.Drawing.Point(28, 182);
            this.btn7.Name = "btn7";
            this.btn7.RightText = "pqrs";
            this.btn7.Size = new System.Drawing.Size(82, 35);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7 pqrs";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn4
            // 
            this.btn4.LeftText = "4";
            this.btn4.Location = new System.Drawing.Point(28, 141);
            this.btn4.Name = "btn4";
            this.btn4.RightText = "ghi";
            this.btn4.Size = new System.Drawing.Size(82, 35);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4 ghi";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // btn1
            // 
            this.btn1.LeftText = "1";
            this.btn1.Location = new System.Drawing.Point(28, 100);
            this.btn1.Name = "btn1";
            this.btn1.RightText = "&&\'(";
            this.btn1.Size = new System.Drawing.Size(82, 35);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1 &&\'(";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnControl_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 279);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old Phone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private CommonFormControl.CommonButton btn2;
        private CommonFormControl.CommonButton btn3;
        private CommonFormControl.CommonButton btn6;
        private CommonFormControl.CommonButton btn9;
        private CommonFormControl.CommonButton btnEnter;
        private CommonFormControl.CommonButton btn5;
        private CommonFormControl.CommonButton btn8;
        private CommonFormControl.CommonButton btn0;
        private CommonFormControl.CommonButton btnStar;
        private CommonFormControl.CommonButton btn7;
        private CommonFormControl.CommonButton btn4;
        private CommonFormControl.CommonButton btn1;
    }
}

