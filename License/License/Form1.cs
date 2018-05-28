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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace License
{
    public partial class Form1 : Form
    {
        CommonOpenFileDialog fileOrFolderDialog;
        CommonOpenFileDialog licenseDialog;
        string codePath;
        string licensePath;
        List<string> fileTypes = new List<string>();
        bool isFolder;
        string license = "";
        int openedCounter = 0;
        int addedCounter = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void browseFilesBtn_Click(object sender, EventArgs e)
        {
            fileOrFolderDialog = new CommonOpenFileDialog();
            fileOrFolderDialog.InitialDirectory = "D:\\";
            if (folderRadioBtn.Checked)
            {
                fileOrFolderDialog.IsFolderPicker = true;
                isFolder = true;
            }
            else if (fileRadioBtn.Checked)
            {
                fileOrFolderDialog.IsFolderPicker = false;
                isFolder = false;
            }
            else return;
            if (fileOrFolderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                codePath = fileOrFolderDialog.FileName;
                selectedPathLbl.Text = codePath;
            }
        }

        private void browseLicenseFileBtrn_Click(object sender, EventArgs e)
        {
            licenseDialog = new CommonOpenFileDialog();
            licenseDialog.InitialDirectory = "C:\\";
            try
            {
                if (licenseDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    licensePath = licenseDialog.FileName;
                    selectedLicensePathLbl.Text = licensePath;
                    ReadLicense(licensePath);
                    appendLicenseBtn.Enabled = true;

                }
            }
            catch (Exception exc)
            {
                appendLicenseBtn.Enabled = false;
            }

        }

        private async void appendLicenseBtn_Click(object sender, EventArgs e)
        {
            if (csCheckBox.Checked)
            {
                fileTypes.Add(".cs");
            }
            if (cppCheckBox.Checked)
            {
                fileTypes.Add(".cpp");
            }
            if (headerCheckBox.Checked)
            {
                fileTypes.Add(".h");
            }
            if (inoCheckBox.Checked)
            {
                fileTypes.Add(".ino");
            }

            workTimeProgressBar.Value = 50;

            if (isFolder)
            {
                await Task.Factory.StartNew(() =>
                /*await*/ ProcessDirectory(codePath));
                //workTimeProgressBar.Value = 0;
                //Console.WriteLine("done");
                if (addedCounter == openedCounter)
                {
                    Console.WriteLine("done");
                }

            }
            else
            {
                await ProcessFile(codePath);
                //workTimeProgressBar.Value = 0;
                //Console.WriteLine("done");
            }

            
        }

        private Task ProcessDirectory(string path)
        {
            return Task.Factory.StartNew(() =>
            {
                string[] fileEntries = Directory.GetFiles(path);
                foreach (string fileName in fileEntries)
                {
                    ProcessFile(fileName);
                }

                string[] subdirectoryEntries = Directory.GetDirectories(path);
                foreach (string subdirectory in subdirectoryEntries)
                    ProcessDirectory(subdirectory);
            });
        }

        private Task ProcessFile(string fileName)
        {
            return Task.Factory.StartNew(async () =>
            {
                string extension = Path.GetExtension(fileName);
                string file;
                if (fileTypes.Contains(extension))
                {
                    using (StreamReader reader = File.OpenText(fileName))
                    {
                        Console.WriteLine("Opened file: " + Path.GetFullPath(fileName));
                        openedCounter++;

                        file = reader.ReadToEnd();
                    }
                    if ((!file.StartsWith("/**") || !file.StartsWith("//")) && license.Length > 1)
                    {
                        //File.Delete(fileName);
                        string newFile = license + file;
                        await Write(newFile, fileName);
                        
                        Console.WriteLine("added license to file: " + Path.GetFullPath(fileName));
                        addedCounter++;

                    }
                }
            });

        }

        
        private void ReadLicense(string path)
        {
            using (StreamReader reader = File.OpenText(path))
            {
                Console.WriteLine("Opened license file.");
                license = reader.ReadToEnd();
                Console.WriteLine("License read ended");
            }
        }

        async Task Write(string text, string filePath)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(filePath, FileMode.Truncate))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            }
        }

    }
}
