using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using Newtonsoft.Json;

namespace OptimaSensorSimulator
{
    public partial class Form1 : Form
    {
        //var mqttClient;
        //var options;
        MqttFactory factory;
        IMqttClient mqttClient;
        IMqttClientOptions options;
        SensorData mySensorData;

        public Form1()
        {
            InitializeComponent();
            factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();
            timer1.Start();
            mySensorData = new SensorData();
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            options = new MqttClientOptionsBuilder()
                            .WithTcpServer(txtBrokerIp.Text, 1883) // Port is optional
                            .Build();

            if (mqttClient.IsConnected)
            {
                mqttClient.DisconnectAsync();
            }
            else
            {
                mqttClient.ConnectAsync(options, System.Threading.CancellationToken.None);
            }
        }

        private void BtPublish_Click(object sender, EventArgs e)
        {
            PublishSensorData();
        }

        private void PublishSensorData()
        {
            if (mqttClient.IsConnected)
            {
                mySensorData.b295 = cbB295.Checked;
                mySensorData.inletTemperature = (uint)numInletTemp.Value;
                mySensorData.outletTemperature = (uint)numOutletTemp.Value;
                string jsonOutput = JsonConvert.SerializeObject(mySensorData);
                mqttClient.PublishAsync("TestTopic", jsonOutput);
            }
        }
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (mqttClient.IsConnected)
            {
                btConnect.BackColor = Color.Green;
            }
            else
            {
                btConnect.BackColor = DefaultBackColor;
            }

            if(cbCyclic.Checked && !publTimer.Enabled)
            {
                publTimer.Start();
            }
            else if (!cbCyclic.Checked && publTimer.Enabled)
            {
                publTimer.Stop();
            }
        }

        private void PublTimer_Tick(object sender, EventArgs e)
        {
            PublishSensorData();
        }
    }
}
