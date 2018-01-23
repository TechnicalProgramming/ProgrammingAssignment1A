namespace ProgrammingAssignment1BusStop
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.travelDistanceResultTextBox = new System.Windows.Forms.TextBox();
            this.travelDistanceButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.travelTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.travelTimeResultTextBox = new System.Windows.Forms.TextBox();
            this.travelTimeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.travelDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Distance to the next stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Time travelling to the next stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "<- Calculate ->";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.travelDistanceResultTextBox);
            this.panel1.Controls.Add(this.travelDistanceButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.travelTimeTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 308);
            this.panel1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "km";
            // 
            // travelDistanceResultTextBox
            // 
            this.travelDistanceResultTextBox.Location = new System.Drawing.Point(12, 222);
            this.travelDistanceResultTextBox.Name = "travelDistanceResultTextBox";
            this.travelDistanceResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.travelDistanceResultTextBox.TabIndex = 11;
            // 
            // travelDistanceButton
            // 
            this.travelDistanceButton.Location = new System.Drawing.Point(12, 179);
            this.travelDistanceButton.Name = "travelDistanceButton";
            this.travelDistanceButton.Size = new System.Drawing.Size(145, 23);
            this.travelDistanceButton.TabIndex = 5;
            this.travelDistanceButton.Text = "Distance of next stop";
            this.travelDistanceButton.UseVisualStyleBackColor = true;
            this.travelDistanceButton.Click += new System.EventHandler(this.travelDistanceButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "minutes";
            // 
            // travelTimeTextBox
            // 
            this.travelTimeTextBox.Location = new System.Drawing.Point(12, 143);
            this.travelTimeTextBox.Name = "travelTimeTextBox";
            this.travelTimeTextBox.Size = new System.Drawing.Size(132, 20);
            this.travelTimeTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter total travel time granted";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "The bus needs 30s from 0km/h to 8 km/h. In that time the bus travels 333 metres f" +
    "ar. After that it travels with constant speed of 80 km/h.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Info";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.travelTimeResultTextBox);
            this.panel2.Controls.Add(this.travelTimeButton);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.travelDistanceTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(264, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 308);
            this.panel2.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "minutes";
            // 
            // travelTimeResultTextBox
            // 
            this.travelTimeResultTextBox.Location = new System.Drawing.Point(23, 222);
            this.travelTimeResultTextBox.Name = "travelTimeResultTextBox";
            this.travelTimeResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.travelTimeResultTextBox.TabIndex = 12;
            // 
            // travelTimeButton
            // 
            this.travelTimeButton.Location = new System.Drawing.Point(23, 179);
            this.travelTimeButton.Name = "travelTimeButton";
            this.travelTimeButton.Size = new System.Drawing.Size(163, 23);
            this.travelTimeButton.TabIndex = 5;
            this.travelTimeButton.Text = "Time to next stop";
            this.travelTimeButton.UseVisualStyleBackColor = true;
            this.travelTimeButton.Click += new System.EventHandler(this.travelTimeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "km";
            // 
            // travelDistanceTextBox
            // 
            this.travelDistanceTextBox.Location = new System.Drawing.Point(23, 143);
            this.travelDistanceTextBox.Name = "travelDistanceTextBox";
            this.travelDistanceTextBox.Size = new System.Drawing.Size(132, 20);
            this.travelDistanceTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter total distance to travel";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "The bus needs 30s from 0km/h to 8 km/h. In that time the bus travels 333 metres f" +
    "ar. After that it travels with constant speed of 80 km/h.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Bus Stop Calculations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button travelDistanceButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox travelTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button travelTimeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox travelDistanceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox travelDistanceResultTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox travelTimeResultTextBox;
    }
}

