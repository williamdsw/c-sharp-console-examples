using System;
using System.IO;

namespace CSharpConsoleExamples
{
    class ScanDevicesSimple
    {
        public ScanDevicesSimple ()
        {
            try
            {
                Console.WriteLine ("##### List of devices #####");

                foreach (DriveInfo drive in DriveInfo.GetDrives ())
                {
                    if (drive.IsReady)
                    {
                        /* Information */
                        string information = "\nDEVICE:: \nName: {0} \nVolume Label: {1} " +
                                             "\nTotal Size: {2} \nTotal Free Space {3} " +
                                             "\nAvailable Free Space: {4} \nDrive Type: {5} " +
                                             "\nDrive Format: {6} \nRoot Directory: {7} ";

                        /* Properties of device */
                        information = String.Format (information, drive.Name, drive.VolumeLabel,
                                                     drive.TotalSize, drive.TotalFreeSpace, drive.AvailableFreeSpace,
                                                     drive.DriveType, drive.DriveFormat, drive.RootDirectory);

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
