using System;
using System.Management;

namespace CSharpConsoleExamples
{
    class ScanDevicesAdvanced
    {
        public ScanDevicesAdvanced ()
        {
            Console.WriteLine ("\n##### Searching using Win32_USBHub #####");
            searchDevices("Win32_USBHub");

            Console.WriteLine("\n##### Searching using Win32_PnPEntity #####");
            searchDevices("Win32_PnPEntity");

            Console.WriteLine("\n##### Searching using Win32_USBController #####");
            searchDevices("Win32_USBController");
        }

        private void searchDevices (string type)
        {
            try
            {
                string query = "";

                /* Defines query for searcher */
                if (type.Equals ("Win32_USBHub"))
                {
                    query = @"Select * from Win32_USBHub";
                }
                else if (type.Equals("Win32_PnPEntity"))
                {
                    query = @"Select * from Win32_PnPEntity where DeviceID Like ""%USB%"" ";
                }
                else if (type.Equals("Win32_USBController"))
                {
                    query = @"Select * from Win32_USBController";
                }

                using (var searcher = new ManagementObjectSearcher(query))
                {
                    using (var collection = searcher.Get())
                    {
                        foreach (var device in collection)
                        {
                            /* Information */
                            string information = "\nDEVICE::" +
                                                 "\nUSBVersion: {0}" +
                                                 "\nDeviceID: {1}" +
                                                 "\nPNPDeviceID: {2}" +
                                                 "\nDescription: {3}" +
                                                 "\nName: {4}" +
                                                 "\nInstallDate: {5}";

                            /* Properties */
                            int USBVersion = (type.Equals("Win32_USBHub") ? (device.GetPropertyValue("USBVersion") != null ? Convert.ToUInt16(device.GetPropertyValue("USBVersion")) : 0) : 0);
                            string DeviceID = (device.GetPropertyValue("DeviceID") != null ? device.GetPropertyValue("DeviceID").ToString() : "");
                            string PNPDeviceID = (device.GetPropertyValue("PNPDeviceID") != null ? device.GetPropertyValue("PNPDeviceID").ToString() : "");
                            string Description = (device.GetPropertyValue("Description") != null ? device.GetPropertyValue("Description").ToString() : "");
                            string Name = (device.GetPropertyValue("Name") != null ? device.GetPropertyValue("Name").ToString() : "");
                            string InstallDate = (device.GetPropertyValue("InstallDate") != null ? device.GetPropertyValue("InstallDate").ToString() : "");

                            information = String.Format(information, USBVersion, DeviceID, PNPDeviceID, Description, Name, InstallDate);
                            Console.WriteLine(information);
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
