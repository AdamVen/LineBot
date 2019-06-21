namespace LineBot.CustomControls
{
    partial class DeviceCommunicationSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelComPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelFlowControl = new System.Windows.Forms.Label();
            this.numericUpDownBaudRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDataBits = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStopBits = new System.Windows.Forms.NumericUpDown();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.checkBoxI2COverSerial = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopBits)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(3, 10);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(56, 13);
            this.labelComPort.TabIndex = 2;
            this.labelComPort.Text = "COM Port:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(3, 44);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(61, 13);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Baud Rate:";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(3, 78);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(53, 13);
            this.labelDataBits.TabIndex = 4;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(3, 112);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(52, 13);
            this.labelStopBits.TabIndex = 5;
            this.labelStopBits.Text = "Stop Bits:";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(3, 146);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(36, 13);
            this.labelParity.TabIndex = 6;
            this.labelParity.Text = "Parity:";
            // 
            // labelFlowControl
            // 
            this.labelFlowControl.AutoSize = true;
            this.labelFlowControl.Location = new System.Drawing.Point(3, 180);
            this.labelFlowControl.Name = "labelFlowControl";
            this.labelFlowControl.Size = new System.Drawing.Size(68, 13);
            this.labelFlowControl.TabIndex = 7;
            this.labelFlowControl.Text = "Flow Control:";
            // 
            // numericUpDownBaudRate
            // 
            this.numericUpDownBaudRate.Location = new System.Drawing.Point(77, 42);
            this.numericUpDownBaudRate.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownBaudRate.Name = "numericUpDownBaudRate";
            this.numericUpDownBaudRate.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownBaudRate.TabIndex = 8;
            // 
            // numericUpDownDataBits
            // 
            this.numericUpDownDataBits.Location = new System.Drawing.Point(77, 76);
            this.numericUpDownDataBits.Name = "numericUpDownDataBits";
            this.numericUpDownDataBits.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownDataBits.TabIndex = 9;
            // 
            // numericUpDownStopBits
            // 
            this.numericUpDownStopBits.Location = new System.Drawing.Point(77, 110);
            this.numericUpDownStopBits.Name = "numericUpDownStopBits";
            this.numericUpDownStopBits.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownStopBits.TabIndex = 10;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(77, 143);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(64, 21);
            this.comboBoxParity.TabIndex = 11;
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.FormattingEnabled = true;
            this.comboBoxFlowControl.Location = new System.Drawing.Point(77, 177);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(64, 21);
            this.comboBoxFlowControl.TabIndex = 12;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(77, 7);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(64, 21);
            this.comboBoxComPort.TabIndex = 13;
            // 
            // checkBoxI2COverSerial
            // 
            this.checkBoxI2COverSerial.AutoSize = true;
            this.checkBoxI2COverSerial.Location = new System.Drawing.Point(27, 214);
            this.checkBoxI2COverSerial.Name = "checkBoxI2COverSerial";
            this.checkBoxI2COverSerial.Size = new System.Drawing.Size(97, 17);
            this.checkBoxI2COverSerial.TabIndex = 14;
            this.checkBoxI2COverSerial.Text = "I2C Over Serial";
            this.checkBoxI2COverSerial.UseVisualStyleBackColor = true;
            // 
            // DeviceCommunicationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxI2COverSerial);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.comboBoxFlowControl);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.numericUpDownStopBits);
            this.Controls.Add(this.numericUpDownDataBits);
            this.Controls.Add(this.numericUpDownBaudRate);
            this.Controls.Add(this.labelFlowControl);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelComPort);
            this.Name = "DeviceCommunicationSettings";
            this.Size = new System.Drawing.Size(150, 236);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDataBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelFlowControl;
        private System.Windows.Forms.NumericUpDown numericUpDownBaudRate;
        private System.Windows.Forms.NumericUpDown numericUpDownDataBits;
        private System.Windows.Forms.NumericUpDown numericUpDownStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxFlowControl;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.CheckBox checkBoxI2COverSerial;
    }
}
