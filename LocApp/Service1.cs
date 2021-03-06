﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NativeWifi;

namespace LocApp
{
    public partial class LocApp : ServiceBase
    {

        protected Thread m_thread;

        public LocApp()
        {

            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("LocAppSource")) 
		{         
				System.Diagnostics.EventLog.CreateEventSource(
					"LocAppSource","LocAppLog");
		}
		eventLog1.Source = "LocAppSource";
		eventLog1.Log = "LocAppLog";

        }

        protected override void OnStart(string[] args)
        {
            try
            {
                ThreadStart ts = new ThreadStart(this.showInterfaces);
                m_thread = new Thread(ts);
                m_thread.Start();
                eventLog1.WriteEntry("LocApp è partita");
            }
            catch (Exception e) {
                eventLog1.WriteEntry(e.Message);
                throw;
            }
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
       {
           return Encoding.ASCII.GetString( ssid.SSID, 0, (int) ssid.SSIDLength );
       }

        //convert MAC Address to String
        static string MACToString(byte[] ba)
        {
            StringBuilder sb = new StringBuilder(ba.Length * 2);
            int i = 0;
            foreach (byte b in ba)
            {
                if (i < ba.Length - 1)
                {
                    sb.AppendFormat("{0:x2}:", b);
                }
                else
                {
                    sb.AppendFormat("{0:x2}", b);
                }
                i++;
            }
            return sb.ToString();
        }
        static string ConvertMACAddr(byte[] ba)
        {
            StringBuilder sb = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }

        protected void showInterfaces() {

            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                //some other processing to do possible
                if (stopwatch.ElapsedMilliseconds >= 30)
                {
                    break;
                }
            }

            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                // Lists all networks with WEP security
                Wlan.WlanBssEntry[] bsss=wlanIface.GetNetworkBssList();
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                

                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    string m;

                    m=GetStringForSSID(network.dot11Ssid)+" "+network.wlanSignalQuality;
                        eventLog1.WriteEntry(m);
                    
                    
                }
            } 
        }
        

        protected override void OnStop()
        {
            m_thread.Abort();
            eventLog1.WriteEntry("LocApp finita1");
            eventLog1.WriteEntry("LocApp finita2");
            eventLog1.WriteEntry("LocApp ");

        }


    }
}
