using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telegram_Clone.Global_Classes
{
    public class clsUtil
    {
        public static string GroupImagesFolder { get { return @"C:\Users\acer\Desktop\Toufik projects\Telgarm App\Groups Images\"; } }
        public static string ChannelImagesFolder { get { return @"C:\Users\acer\Desktop\Toufik projects\Telgarm App\Channel Images\"; } }
        public static string UsersImagesFolder { get { return @"C:\Users\acer\Desktop\Toufik projects\Telgarm App\Users Images\"; } }

        public static bool LoadImage(string ImagePath)
        {
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    return true;
                else
                    MessageBox.Show("Could Find This Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public static bool CreateFolderIFDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }
            return true;
        }
        public static string GenerateGUID()
        {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();
        }
        public static string ReplaceFileWithGUID(string SourceFile)
        {
            FileInfo fi = new FileInfo(SourceFile);
            return GenerateGUID() + fi.Extension;
        }
        public static bool CopyImageToProjectImagesFolder(ref string SourceFile, string _DestinationFolder)
        {
            string DestinationFolder = _DestinationFolder;
            if (!CreateFolderIFDoesNotExist(DestinationFolder))
                return false;
            string DestinationFile = DestinationFolder + ReplaceFileWithGUID(SourceFile);
            try
            {
                File.Copy(SourceFile, DestinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            SourceFile = DestinationFile;
            return true;
        }
        public static void HandleUserImage(string UserImagePath, ref string pbUserImageLocation, string DestinationFolder)
        {
            if (UserImagePath != pbUserImageLocation)
            {
                if (UserImagePath != "")
                {
                    try
                    {
                        File.Delete(UserImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }

                }
                if (pbUserImageLocation != null && pbUserImageLocation != "")
                {
                    if (clsUtil.CopyImageToProjectImagesFolder(ref pbUserImageLocation, DestinationFolder))
                        return;
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            return;
        }
    }
}
