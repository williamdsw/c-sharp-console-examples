using System;
using System.Management;

namespace c_sharp_console_examples
{
    class ScanDevicesAdvanced
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public ScanDevicesAdvanced ()
        {
            Console.WriteLine ("\n##### Searching using Win32_USBHub #####");
            SearchDevices ("Win32_USBHub");

            Console.WriteLine ("\n##### Searching using Win32_PnPEntity #####");
            SearchDevices ("Win32_PnPEntity");

            Console.WriteLine ("\n##### Searching using Win32_USBController #####");
            SearchDevices ("Win32_USBController");
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void SearchDevices (string type)
        {
            try
            {
                string query = string.Empty;

                // Defines query for searcher
                switch (type)
                {
                    case "Win32_USBHub": { query = @"Select * from Win32_USBHub"; break; }
                    case "Win32_PnPEntity": { query = @"Select * from Win32_PnPEntity where DeviceID Like ""%USB%"" "; break; }
                    case "Win32_USBController": { query = @"Select * from Win32_USBController"; break; }
                    default: { break; }
                }

                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher (query))
                {
                    using (ManagementObjectCollection collection = searcher.Get ())
                    {
                        foreach (ManagementObject device in collection)
                        {
                            // Information
                            string information = "\nDEVICE::" + "\nUSBVersion: {0}" + "\nDeviceID: {1}" + "\nPNPDeviceID: {2}" +
                                                 "\nDescription: {3}" + "\nName: {4}" + "\nInstallDate: {5}";

                            // Properties
                            int usbVersion = (type.Equals ("Win32_USBHub") ? (device.GetPropertyValue("USBVersion") != null ? Convert.ToUInt16 (device.GetPropertyValue ("USBVersion")) : 0) : 0);
                            string deviceID = (device.GetPropertyValue ("DeviceID") != null ? device.GetPropertyValue ("DeviceID").ToString () : "");
                            string pnpDeviceID = (device.GetPropertyValue ("PNPDeviceID") != null ? device.GetPropertyValue ("PNPDeviceID").ToString () : "");
                            string description = (device.GetPropertyValue ("Description") != null ? device.GetPropertyValue ("Description").ToString () : "");
                            string name = (device.GetPropertyValue ("Name") != null ? device.GetPropertyValue ("Name").ToString() : "");
                            string installDate = (device.GetPropertyValue ("InstallDate") != null ? device.GetPropertyValue ("InstallDate").ToString () : "");

                            // Output
                            information = String.Format (information, usbVersion, deviceID, pnpDeviceID, description, name, installDate);
                            Console.WriteLine (information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}