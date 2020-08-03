namespace OptimaSensorSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btConnect = new System.Windows.Forms.Button();
            this.txtBrokerIp = new System.Windows.Forms.TextBox();
            this.btPublish = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbB295 = new System.Windows.Forms.CheckBox();
            this.numOxygen = new System.Windows.Forms.NumericUpDown();
            this.lbOxygen = new System.Windows.Forms.Label();
            this.numInletTemp = new System.Windows.Forms.NumericUpDown();
            this.lbInletTemp = new System.Windows.Forms.Label();
            this.lbOutletTemp = new System.Windows.Forms.Label();
            this.numOutletTemp = new System.Windows.Forms.NumericUpDown();
            this.publTimer = new System.Windows.Forms.Timer(this.components);
            this.cbCyclic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutletTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(24, 37);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // txtBrokerIp
            // 
            this.txtBrokerIp.Location = new System.Drawing.Point(105, 39);
            this.txtBrokerIp.Name = "txtBrokerIp";
            this.txtBrokerIp.Size = new System.Drawing.Size(97, 20);
            this.txtBrokerIp.TabIndex = 1;
            this.txtBrokerIp.Text = "192.168.1.138";
            // 
            // btPublish
            // 
            this.btPublish.Location = new System.Drawing.Point(24, 91);
            this.btPublish.Name = "btPublish";
            this.btPublish.Size = new System.Drawing.Size(75, 23);
            this.btPublish.TabIndex = 2;
            this.btPublish.Text = "Publish";
            this.btPublish.UseVisualStyleBackColor = true;
            this.btPublish.Click += new System.EventHandler(this.BtPublish_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cbB295
            // 
            this.cbB295.AutoSize = true;
            this.cbB295.Location = new System.Drawing.Point(24, 149);
            this.cbB295.Name = "cbB295";
            this.cbB295.Size = new System.Drawing.Size(51, 17);
            this.cbB295.TabIndex = 3;
            this.cbB295.Text = "B295";
            this.cbB295.UseVisualStyleBackColor = true;
            // 
            // numOxygen
            // 
            this.numOxygen.Location = new System.Drawing.Point(144, 146);
            this.numOxygen.Name = "numOxygen";
            this.numOxygen.Size = new System.Drawing.Size(58, 20);
            this.numOxygen.TabIndex = 4;
            this.numOxygen.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lbOxygen
            // 
            this.lbOxygen.AutoSize = true;
            this.lbOxygen.Location = new System.Drawing.Point(81, 150);
            this.lbOxygen.Name = "lbOxygen";
            this.lbOxygen.Size = new System.Drawing.Size(43, 13);
            this.lbOxygen.TabIndex = 5;
            this.lbOxygen.Text = "Oxygen";
            // 
            // numInletTemp
            // 
            this.numInletTemp.Location = new System.Drawing.Point(144, 186);
            this.numInletTemp.Name = "numInletTemp";
            this.numInletTemp.Size = new System.Drawing.Size(58, 20);
            this.numInletTemp.TabIndex = 6;
            // 
            // lbInletTemp
            // 
            this.lbInletTemp.AutoSize = true;
            this.lbInletTemp.Location = new System.Drawing.Point(21, 188);
            this.lbInletTemp.Name = "lbInletTemp";
            this.lbInletTemp.Size = new System.Drawing.Size(90, 13);
            this.lbInletTemp.TabIndex = 7;
            this.lbInletTemp.Text = "Inlet Temperature";
            // 
            // lbOutletTemp
            // 
            this.lbOutletTemp.AutoSize = true;
            this.lbOutletTemp.Location = new System.Drawing.Point(21, 214);
            this.lbOutletTemp.Name = "lbOutletTemp";
            this.lbOutletTemp.Size = new System.Drawing.Size(98, 13);
            this.lbOutletTemp.TabIndex = 9;
            this.lbOutletTemp.Text = "Outlet Temperature";
            // 
            // numOutletTemp
            // 
            this.numOutletTemp.Location = new System.Drawing.Point(144, 212);
            this.numOutletTemp.Name = "numOutletTemp";
            this.numOutletTemp.Size = new System.Drawing.Size(58, 20);
            this.numOutletTemp.TabIndex = 8;
            // 
            // publTimer
            // 
            this.publTimer.Interval = 500;
            this.publTimer.Tick += new System.EventHandler(this.PublTimer_Tick);
            // 
            // cbCyclic
            // 
            this.cbCyclic.AutoSize = true;
            this.cbCyclic.Location = new System.Drawing.Point(105, 95);
            this.cbCyclic.Name = "cbCyclic";
            this.cbCyclic.Size = new System.Drawing.Size(54, 17);
            this.cbCyclic.TabIndex = 10;
            this.cbCyclic.Text = "Cyclic";
            this.cbCyclic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCyclic);
            this.Controls.Add(this.lbOutletTemp);
            this.Controls.Add(this.numOutletTemp);
            this.Controls.Add(this.lbInletTemp);
            this.Controls.Add(this.numInletTemp);
            this.Controls.Add(this.lbOxygen);
            this.Controls.Add(this.numOxygen);
            this.Controls.Add(this.cbB295);
            this.Controls.Add(this.btPublish);
            this.Controls.Add(this.txtBrokerIp);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.Text = "Optima Sensor Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.numOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutletTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtBrokerIp;
        private System.Windows.Forms.Button btPublish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbB295;
        private System.Windows.Forms.NumericUpDown numOxygen;
        private System.Windows.Forms.Label lbOxygen;
        private System.Windows.Forms.NumericUpDown numInletTemp;
        private System.Windows.Forms.Label lbInletTemp;
        private System.Windows.Forms.Label lbOutletTemp;
        private System.Windows.Forms.NumericUpDown numOutletTemp;
        private System.Windows.Forms.Timer publTimer;
        private System.Windows.Forms.CheckBox cbCyclic;
    }
}

