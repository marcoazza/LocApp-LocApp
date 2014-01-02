using System;
using System.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using LocApplication;
using System.Management;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using System.Threading.Tasks;



namespace LocApplication
{
    class Class1
    {

        public class itemApp {

            public string applicazione
            {
                get;
                set;
            }
            public String icon
            {
                get;
                set;
            }

            public string name
            {
                get;
                set;
            }
        }


        public static void startProcess(string stringProc) {

            Process p = new Process();

            p.StartInfo.FileName = stringProc;
            

            p.Start();
        
        }
    
        public delegate void updateAppList (System.Windows.Controls.ListBox l,string s,string ico,string n);



        public static void getInstalledSoftware(Object li)
        {
            string Software = null;
            //Dispatcher uiDispatcher = LocApplication.;
            //AppList.handle.contr
            System.Windows.Controls.ListBox l = (System.Windows.Controls.ListBox)li;
            //int i = 0;
            //The registry key:
            string SoftwareKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey))
            //{
                //Let's go through the registry keys and get the info we need:
            
                foreach (string skName in rk.GetSubKeyNames())
                {
                    
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            string[] prova=sk.GetValueNames();

                            //If the key has value, continue, if not, skip it:
                            if (!(sk.GetValue("") == null))
                            {
                                Icon ico = Icon.ExtractAssociatedIcon((string)sk.GetValue(""));
                                
                                Bitmap b = ico.ToBitmap();
                                
                                
                                    object[] myArray = new object[4];
                                    myArray[0] = l;
                                    myArray[1] = sk.GetValue("");
                                    string rp = Environment.CurrentDirectory.ToString();

                                    b.Save(rp + "\\images\\" + System.IO.Path.GetFileNameWithoutExtension((string)sk.GetValue("")) + ".ico");
                                    myArray[2] = rp + "\\images\\" + System.IO.Path.GetFileNameWithoutExtension((string)sk.GetValue("")) + ".ico";
                                    myArray[3] = System.IO.Path.GetFileNameWithoutExtension((string)sk.GetValue(""));

                                    l.Dispatcher.BeginInvoke(new updateAppList(addItem), myArray);
                                  
                                //Software += sk.GetValue("DisplayName") + " - " + sk.GetValue("InstallLocation") + "\n"; //Yes, here it is...

                                
                            }
                        }
                        catch (Exception ex)
                        {
                            //No, that exception is not getting away... :P
                        }
                    }
                   //  i++;
                }
            }






        public static void addItem(System.Windows.Controls.ListBox myL,string s,String ico,string n) {

            myL.Items.Add(new itemApp { applicazione=s,icon=ico, name=n });

        }



    }
}
