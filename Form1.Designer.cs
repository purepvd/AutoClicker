namespace AutoClickerNetCore
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            numericClickCount = new System.Windows.Forms.NumericUpDown();
            numericClickDelay = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            numericXPos = new System.Windows.Forms.NumericUpDown();
            numericYPos = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            checkBoxClickHold = new System.Windows.Forms.CheckBox();
            numericUpDownClickHoldDuration = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            groupBoxClickHold = new System.Windows.Forms.GroupBox();
            groupBoxClickies = new System.Windows.Forms.GroupBox();
            numericUpDownPause = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            checkBoxAlternateClickStrategy = new System.Windows.Forms.CheckBox();
            checkBoxDarkMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericClickCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericClickDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericXPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericYPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownClickHoldDuration).BeginInit();
            groupBoxClickHold.SuspendLayout();
            groupBoxClickies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPause).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(37, 363);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Click XY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonXyClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "X Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Y Position";
            // 
            // button2
            // 
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(119, 363);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "Click Random";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClickHold_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Count";
            // 
            // numericClickCount
            // 
            numericClickCount.Location = new System.Drawing.Point(112, 20);
            numericClickCount.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numericClickCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericClickCount.Name = "numericClickCount";
            numericClickCount.Size = new System.Drawing.Size(100, 23);
            numericClickCount.TabIndex = 7;
            numericClickCount.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericClickDelay
            // 
            numericClickDelay.Location = new System.Drawing.Point(112, 49);
            numericClickDelay.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numericClickDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericClickDelay.Name = "numericClickDelay";
            numericClickDelay.Size = new System.Drawing.Size(100, 23);
            numericClickDelay.TabIndex = 8;
            numericClickDelay.Value = new decimal(new int[] { 250, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 51);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Delay (ms)";
            // 
            // numericXPos
            // 
            numericXPos.Location = new System.Drawing.Point(121, 12);
            numericXPos.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numericXPos.Name = "numericXPos";
            numericXPos.Size = new System.Drawing.Size(104, 23);
            numericXPos.TabIndex = 10;
            numericXPos.Value = new decimal(new int[] { 960, 0, 0, 0 });
            // 
            // numericYPos
            // 
            numericYPos.Location = new System.Drawing.Point(121, 41);
            numericYPos.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numericYPos.Name = "numericYPos";
            numericYPos.Size = new System.Drawing.Size(104, 23);
            numericYPos.TabIndex = 11;
            numericYPos.Value = new decimal(new int[] { 540, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Firebrick;
            label5.Location = new System.Drawing.Point(40, 345);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 15);
            label5.TabIndex = 12;
            label5.Text = "Ctrl + Shift + T = HALT CLICKIES";
            // 
            // checkBoxClickHold
            // 
            checkBoxClickHold.Location = new System.Drawing.Point(6, 22);
            checkBoxClickHold.Name = "checkBoxClickHold";
            checkBoxClickHold.Size = new System.Drawing.Size(104, 24);
            checkBoxClickHold.TabIndex = 13;
            checkBoxClickHold.Text = "Enable";
            checkBoxClickHold.UseVisualStyleBackColor = true;
            checkBoxClickHold.CheckedChanged += checkBoxClickHold_CheckedChanged;
            // 
            // numericUpDownClickHoldDuration
            // 
            numericUpDownClickHoldDuration.Location = new System.Drawing.Point(131, 52);
            numericUpDownClickHoldDuration.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numericUpDownClickHoldDuration.Name = "numericUpDownClickHoldDuration";
            numericUpDownClickHoldDuration.Size = new System.Drawing.Size(81, 23);
            numericUpDownClickHoldDuration.TabIndex = 15;
            numericUpDownClickHoldDuration.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 54);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 15);
            label6.TabIndex = 14;
            label6.Text = "Duration (seconds)";
            // 
            // groupBoxClickHold
            // 
            groupBoxClickHold.Controls.Add(label6);
            groupBoxClickHold.Controls.Add(numericUpDownClickHoldDuration);
            groupBoxClickHold.Controls.Add(checkBoxClickHold);
            groupBoxClickHold.Location = new System.Drawing.Point(7, 194);
            groupBoxClickHold.Name = "groupBoxClickHold";
            groupBoxClickHold.Size = new System.Drawing.Size(218, 89);
            groupBoxClickHold.TabIndex = 16;
            groupBoxClickHold.TabStop = false;
            groupBoxClickHold.Text = "Click Hold";
            // 
            // groupBoxClickies
            // 
            groupBoxClickies.Controls.Add(numericUpDownPause);
            groupBoxClickies.Controls.Add(label7);
            groupBoxClickies.Controls.Add(numericClickDelay);
            groupBoxClickies.Controls.Add(numericClickCount);
            groupBoxClickies.Controls.Add(label4);
            groupBoxClickies.Controls.Add(label3);
            groupBoxClickies.Location = new System.Drawing.Point(7, 72);
            groupBoxClickies.Name = "groupBoxClickies";
            groupBoxClickies.Size = new System.Drawing.Size(218, 116);
            groupBoxClickies.TabIndex = 17;
            groupBoxClickies.TabStop = false;
            groupBoxClickies.Text = "Clickies";
            // 
            // numericUpDownPause
            // 
            numericUpDownPause.Location = new System.Drawing.Point(129, 78);
            numericUpDownPause.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numericUpDownPause.Name = "numericUpDownPause";
            numericUpDownPause.Size = new System.Drawing.Size(83, 23);
            numericUpDownPause.TabIndex = 10;
            numericUpDownPause.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPause.ValueChanged += numericUpDownPause_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 80);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(117, 15);
            label7.TabIndex = 11;
            label7.Text = "Down Up Pause (ms)";
            // 
            // checkBoxAlternateClickStrategy
            // 
            checkBoxAlternateClickStrategy.Location = new System.Drawing.Point(6, 289);
            checkBoxAlternateClickStrategy.Name = "checkBoxAlternateClickStrategy";
            checkBoxAlternateClickStrategy.Size = new System.Drawing.Size(218, 24);
            checkBoxAlternateClickStrategy.TabIndex = 18;
            checkBoxAlternateClickStrategy.Text = "Use alternate click strategy";
            checkBoxAlternateClickStrategy.UseVisualStyleBackColor = true;
            // 
            // checkBoxDarkMode
            // 
            checkBoxDarkMode.Checked = true;
            checkBoxDarkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxDarkMode.Location = new System.Drawing.Point(6, 318);
            checkBoxDarkMode.Name = "checkBoxDarkMode";
            checkBoxDarkMode.Size = new System.Drawing.Size(218, 24);
            checkBoxDarkMode.TabIndex = 19;
            checkBoxDarkMode.Text = "Dark mode";
            checkBoxDarkMode.UseVisualStyleBackColor = true;
            checkBoxDarkMode.CheckedChanged += checkBoxDarkMode_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(232, 396);
            Controls.Add(checkBoxDarkMode);
            Controls.Add(checkBoxAlternateClickStrategy);
            Controls.Add(label5);
            Controls.Add(numericYPos);
            Controls.Add(numericXPos);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBoxClickHold);
            Controls.Add(groupBoxClickies);
            ShowIcon = false;
            Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)numericClickCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericClickDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericXPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericYPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownClickHoldDuration).EndInit();
            groupBoxClickHold.ResumeLayout(false);
            groupBoxClickHold.PerformLayout();
            groupBoxClickies.ResumeLayout(false);
            groupBoxClickies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPause).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBoxDarkMode;

        private System.Windows.Forms.NumericUpDown numericUpDownPause;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.CheckBox checkBoxAlternateClickStrategy;

        private System.Windows.Forms.GroupBox groupBoxClickies;

        private System.Windows.Forms.CheckBox checkBoxClickHold;
        private System.Windows.Forms.NumericUpDown numericUpDownClickHoldDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxClickHold;

        #endregion

        private System.Windows.Forms.Button button1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericClickCount;
        private System.Windows.Forms.NumericUpDown numericClickDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericXPos;
        private System.Windows.Forms.NumericUpDown numericYPos;
        private System.Windows.Forms.Label label5;
    }
}