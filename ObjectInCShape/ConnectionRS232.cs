using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ObjectInCShape
{
    class ConnectionRS232
    {
        private SerialPort Serial;
        public string comName { get; set; }
        public int baudRate { get; set; }

        public ConnectionRS232()
        {
            this.baudRate = 9600;
        }
        public ConnectionRS232(string comName)
        {
            this.comName = comName;
        }
        public ConnectionRS232(string comName, int baudRate)
        {
            this.comName = comName;
            this.baudRate = baudRate;
        }


        public bool Open()
        {
            Serial = new SerialPort(this.comName, this.baudRate);
            Serial.Open();
            return Serial.IsOpen;
        }
        public bool Close()
        {
            if (Serial.IsOpen) Serial.Close();
            return !Serial.IsOpen;
        }
        public void Write(string text)
        {
            if (Serial.IsOpen)
                Serial.Write(text);
        }
        public string Read()
        {
            string text = "";
            lock (this)
            {
                do
                {
                    Thread.Sleep(100);
                    if (Serial.IsOpen)
                        text = Serial.ReadExisting();

                } while (!text.EndsWith("\r\n"));
            }
            return text;
        }
    }
}
