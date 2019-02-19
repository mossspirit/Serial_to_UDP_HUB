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

namespace VRHoleHub_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            // すべてのシリアル・ポート名を取得する
            string[] ports = SerialPort.GetPortNames();

            // シリアルポートを毎回取得して表示するために表示の度にリストをクリアする
            comboBox1.Items.Clear();

            foreach (string port in ports)
            {
                // 取得したシリアル・ポート名を出力する
                comboBox1.Items.Add(port);
            }
            
        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string[] boundRates =
            {
                "9600",
                "19200",
                "38400",
                "57600",
                "115200"
            };
            comboBox2.Items.Clear();

            foreach (string boundRate in boundRates)
            {
                comboBox2.Items.Add(boundRate);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button_Clicked");
        }

        
    }
}
