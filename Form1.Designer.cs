namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.BUTTON_EQUAL = new System.Windows.Forms.Button();
            this.BUTTON_DIVIDE = new System.Windows.Forms.Button();
            this.BUTTON_MULTIPLY = new System.Windows.Forms.Button();
            this.BUTTON_SUBTRACT = new System.Windows.Forms.Button();
            this.BUTTON_ADD = new System.Windows.Forms.Button();
            this.BUTTON_AC = new System.Windows.Forms.Button();
            this.BUTTON_C = new System.Windows.Forms.Button();
            this.currentActionText = new System.Windows.Forms.Label();
            this.prevInputBox = new System.Windows.Forms.TextBox();
            this.BUTTON_DOT = new System.Windows.Forms.Button();
            this.BUTTON_NEGATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mainTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.Location = new System.Drawing.Point(12, 24);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mainTextBox.Size = new System.Drawing.Size(265, 33);
            this.mainTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(53, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(94, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(53, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(94, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 34);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(53, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 34);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(94, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(53, 186);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 34);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // BUTTON_EQUAL
            // 
            this.BUTTON_EQUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_EQUAL.Location = new System.Drawing.Point(283, 260);
            this.BUTTON_EQUAL.Name = "BUTTON_EQUAL";
            this.BUTTON_EQUAL.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_EQUAL.TabIndex = 11;
            this.BUTTON_EQUAL.Text = "=";
            this.BUTTON_EQUAL.UseVisualStyleBackColor = true;
            this.BUTTON_EQUAL.Click += new System.EventHandler(this.BUTTON_EQUAL_Click);
            // 
            // BUTTON_DIVIDE
            // 
            this.BUTTON_DIVIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_DIVIDE.Location = new System.Drawing.Point(283, 220);
            this.BUTTON_DIVIDE.Name = "BUTTON_DIVIDE";
            this.BUTTON_DIVIDE.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_DIVIDE.TabIndex = 12;
            this.BUTTON_DIVIDE.Text = "/";
            this.BUTTON_DIVIDE.UseVisualStyleBackColor = true;
            this.BUTTON_DIVIDE.Click += new System.EventHandler(this.BUTTON_DIVIDE_Click);
            // 
            // BUTTON_MULTIPLY
            // 
            this.BUTTON_MULTIPLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_MULTIPLY.Location = new System.Drawing.Point(283, 180);
            this.BUTTON_MULTIPLY.Name = "BUTTON_MULTIPLY";
            this.BUTTON_MULTIPLY.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_MULTIPLY.TabIndex = 13;
            this.BUTTON_MULTIPLY.Text = "*";
            this.BUTTON_MULTIPLY.UseVisualStyleBackColor = true;
            this.BUTTON_MULTIPLY.Click += new System.EventHandler(this.BUTTON_MULTIPLY_Click);
            // 
            // BUTTON_SUBTRACT
            // 
            this.BUTTON_SUBTRACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_SUBTRACT.Location = new System.Drawing.Point(283, 140);
            this.BUTTON_SUBTRACT.Name = "BUTTON_SUBTRACT";
            this.BUTTON_SUBTRACT.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_SUBTRACT.TabIndex = 14;
            this.BUTTON_SUBTRACT.Text = "-";
            this.BUTTON_SUBTRACT.UseVisualStyleBackColor = true;
            this.BUTTON_SUBTRACT.Click += new System.EventHandler(this.BUTTON_SUBTRACT_Click);
            // 
            // BUTTON_ADD
            // 
            this.BUTTON_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_ADD.Location = new System.Drawing.Point(283, 100);
            this.BUTTON_ADD.Name = "BUTTON_ADD";
            this.BUTTON_ADD.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_ADD.TabIndex = 15;
            this.BUTTON_ADD.Text = "+";
            this.BUTTON_ADD.UseVisualStyleBackColor = true;
            this.BUTTON_ADD.Click += new System.EventHandler(this.BUTTON_ADD_Click);
            // 
            // BUTTON_AC
            // 
            this.BUTTON_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_AC.Location = new System.Drawing.Point(214, 260);
            this.BUTTON_AC.Name = "BUTTON_AC";
            this.BUTTON_AC.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_AC.TabIndex = 16;
            this.BUTTON_AC.Text = "AC";
            this.BUTTON_AC.UseVisualStyleBackColor = true;
            this.BUTTON_AC.Click += new System.EventHandler(this.BUTTON_AC_Click);
            // 
            // BUTTON_C
            // 
            this.BUTTON_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_C.Location = new System.Drawing.Point(145, 260);
            this.BUTTON_C.Name = "BUTTON_C";
            this.BUTTON_C.Size = new System.Drawing.Size(63, 34);
            this.BUTTON_C.TabIndex = 17;
            this.BUTTON_C.Text = "C";
            this.BUTTON_C.UseVisualStyleBackColor = true;
            this.BUTTON_C.Click += new System.EventHandler(this.BUTTON_C_Click);
            // 
            // currentActionText
            // 
            this.currentActionText.AutoSize = true;
            this.currentActionText.Location = new System.Drawing.Point(13, 8);
            this.currentActionText.Name = "currentActionText";
            this.currentActionText.Size = new System.Drawing.Size(105, 13);
            this.currentActionText.TabIndex = 18;
            this.currentActionText.Text = "Current action: None";
            // 
            // prevInputBox
            // 
            this.prevInputBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevInputBox.Location = new System.Drawing.Point(283, 24);
            this.prevInputBox.Name = "prevInputBox";
            this.prevInputBox.ReadOnly = true;
            this.prevInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.prevInputBox.Size = new System.Drawing.Size(63, 33);
            this.prevInputBox.TabIndex = 19;
            // 
            // BUTTON_DOT
            // 
            this.BUTTON_DOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_DOT.Location = new System.Drawing.Point(12, 186);
            this.BUTTON_DOT.Name = "BUTTON_DOT";
            this.BUTTON_DOT.Size = new System.Drawing.Size(35, 34);
            this.BUTTON_DOT.TabIndex = 20;
            this.BUTTON_DOT.Text = ".";
            this.BUTTON_DOT.UseVisualStyleBackColor = true;
            this.BUTTON_DOT.Click += new System.EventHandler(this.BUTTON_DOT_Click);
            // 
            // BUTTON_NEGATE
            // 
            this.BUTTON_NEGATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_NEGATE.Location = new System.Drawing.Point(94, 186);
            this.BUTTON_NEGATE.Name = "BUTTON_NEGATE";
            this.BUTTON_NEGATE.Size = new System.Drawing.Size(35, 34);
            this.BUTTON_NEGATE.TabIndex = 21;
            this.BUTTON_NEGATE.Text = "+/-";
            this.BUTTON_NEGATE.UseVisualStyleBackColor = true;
            this.BUTTON_NEGATE.Click += new System.EventHandler(this.BUTTON_NEGATE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 306);
            this.Controls.Add(this.BUTTON_NEGATE);
            this.Controls.Add(this.BUTTON_DOT);
            this.Controls.Add(this.prevInputBox);
            this.Controls.Add(this.currentActionText);
            this.Controls.Add(this.BUTTON_C);
            this.Controls.Add(this.BUTTON_AC);
            this.Controls.Add(this.BUTTON_ADD);
            this.Controls.Add(this.BUTTON_SUBTRACT);
            this.Controls.Add(this.BUTTON_MULTIPLY);
            this.Controls.Add(this.BUTTON_DIVIDE);
            this.Controls.Add(this.BUTTON_EQUAL);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "placeholdertext";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button BUTTON_EQUAL;
        private System.Windows.Forms.Button BUTTON_DIVIDE;
        private System.Windows.Forms.Button BUTTON_MULTIPLY;
        private System.Windows.Forms.Button BUTTON_SUBTRACT;
        private System.Windows.Forms.Button BUTTON_ADD;
        private System.Windows.Forms.Button BUTTON_AC;
        private System.Windows.Forms.Button BUTTON_C;
        private System.Windows.Forms.Label currentActionText;
        private System.Windows.Forms.TextBox prevInputBox;
        private System.Windows.Forms.Button BUTTON_DOT;
        private System.Windows.Forms.Button BUTTON_NEGATE;
    }
}

