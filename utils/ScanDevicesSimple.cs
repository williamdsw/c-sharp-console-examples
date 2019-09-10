using System;
using System.IO;
using System.Text;

namespace c_sharp_console_examples
{
    class ScanDevicesSimple
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTORS

        public ScanDevicesSimple ()
        {
            try
            {
                Console.WriteLine ("##### List of devices #####");

                foreach (DriveInfo drive in DriveInfo.GetDrives ())
                {
                    if (drive.IsReady)
                    {
                        // Information
                        StringBuilder information = new StringBuilder ();
                        information.Append ("\nDEVICE:: ");
                        information.AppendFormat ("\nName: {0}", drive.Name);
                        information.AppendFormat ("\nVolume Label: {0}", drive.VolumeLabel);
                        information.AppendFormat ("\nTotal Size: {0}", drive.TotalSize);
                        information.AppendFormat ("\nTotal Free Space {0}", drive.TotalFreeSpace);
                        information.AppendFormat ("\nAvailable Free Space: {0}", drive.AvailableFreeSpace);
                        information.AppendFormat ("\nDrive Type: {0}", drive.DriveType);
                        information.AppendFormat ("\nDrive Format: {0}", drive.DriveFormat);
                        information.AppendFormat ("\nRoot Directory: {0}", drive.RootDirectory);
                        information.AppendFormat ("\nIsReady: {0}", drive.IsReady);
                        Console.WriteLine (information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
