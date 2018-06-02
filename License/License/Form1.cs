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
        int fileCounter = 0;
        int addedCounter = 0;
        bool recursively;
        int mappedValue;


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


            //workTimeProgressBar.Value = 50;

            if (isFolder)
            {
                fileCounter = CountFiles(codePath, fileTypes, recursivelyIterateCheckBox.Checked);
                totalFilesLbl.Text = fileCounter.ToString();
                await Task.Factory.StartNew(() =>
                    ProcessDirectory(codePath));

            }
            else
            {
                await ProcessFile(codePath);

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

                        file = reader.ReadToEnd();
                       
                    }

                    addedCounter++;
                    Console.WriteLine("counter: " + addedCounter);
                    mappedValue = (int)Map(addedCounter, 0, fileCounter, 0, 100);
                    Invoke((MethodInvoker)delegate
                    {
                        curentFileLbl.Text = Path.GetFullPath(fileName);
                        fileCounterLbl.Text = addedCounter.ToString();
                        if (mappedValue <= 100 && mappedValue >= 0)
                        {
                            workTimeProgressBar.Value = mappedValue;
                        }
                        if (addedCounter == fileCounter)
                        {
                            curentFileLbl.Text = "done";
                        }
                    });
                    if ((!file.StartsWith("/**") || !file.StartsWith("//")) && license.Length > 1)
                    {
                        //File.Delete(fileName);
                        string newFile = license + file;
                        await Write(newFile, fileName);
                        
                        Console.WriteLine("added license to file: " + Path.GetFullPath(fileName));
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

        private void recursivelyIterateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(recursivelyIterateCheckBox.Checked)
            {
                recursively = true;
            }
            else
            {
                recursively = false;
            }
        }

        private int CountFiles(string path, List <string> types, bool isRecursive)
        {

            int counter = 0;
            foreach(string type in types)
            {
                if(isRecursive)
                    counter += Directory.EnumerateFiles(path, "*" + type, SearchOption.AllDirectories).Count();
                else
                {
                    counter += Directory.EnumerateFiles(path, "*" + type, SearchOption.TopDirectoryOnly).Count();
                }

            }
            Console.WriteLine("total files: " + counter);
            return counter;
        }

        public static double Map(double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
    }
}
