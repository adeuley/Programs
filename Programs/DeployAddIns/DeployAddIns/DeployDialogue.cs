using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeployAddIns
{
    public partial class DeployDialogue : Form
    {
        private string fromFolder;
        private string[] deployLocations;
        private string deployLocationsFile = "";
        public DeployDialogue()
        {
            InitializeComponent();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            fromFolder = folderBrowserDialog1.SelectedPath;
            labelSelectedFolder.Text = fromFolder;
        }

        private void readLocationList()
        {
            deployLocations = System.IO.File.ReadAllLines(deployLocationsFile);
        }

        private void buttonDeploy_Click(object sender, EventArgs e)
        {
            listBoxReslts.Items.Clear();
            readLocationList();
            foreach (string deployString in deployLocations)
            {
                try
                {
                    DirectoryCopy(fromFolder, deployString, true);
                    string result = deployString + " : Succeeded";
                    listBoxReslts.Items.Add(result);
                }
                catch
                {
                    string result = deployString + " : Failed";
                    listBoxReslts.Items.Add(result);
                }
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            MessageBox.Show(sourceDirName);
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath,true);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void buttonSelectTextFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            deployLocationsFile = openFileDialog1.FileName;
            labelSelectedFile.Text = deployLocationsFile;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
