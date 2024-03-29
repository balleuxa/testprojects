using System.IO.Compression;

namespace _8zip
{
    public partial class Form8zip : Form
    {
        public Form8zip()
        {
            InitializeComponent();
        }
        private static string pathToFile = "";
        private static string pathToZip = "";
        private static int nbOfFiles = 0;

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            Color semiTransparentGreen = Color.FromArgb(50, 0, 255, 0);
            Color semiTransparentRed = Color.FromArgb(50, 255, 0, 0);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                lblPlaceHolder.Visible = false;
                string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                {
                    pathToFile = path;
                    panel1.BackColor = semiTransparentGreen;
                    e.Effect = DragDropEffects.Copy;
                }
                else if (path.Contains(".zip"))
                {
                    pathToZip = path;
                    panel1.BackColor = semiTransparentGreen;
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    panel1.BackColor = semiTransparentRed;
                    e.Effect = DragDropEffects.None;
                }

            }
        }
        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control;
            lblPlaceHolder.Visible = true;
        }
        private async void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.BackColor = SystemColors.Control;


            if (pathToZip.EndsWith(".zip") && File.Exists(pathToZip))
            {
                DisplayZipInfo();
                Decompress(pathToZip);
            }
            else if (Directory.Exists(pathToFile))
            {
                DisplayFolderInfo();
                Compress(pathToFile);
            }
            else
            {
                MessageBox.Show("Not a valid file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblProgress.Text = "Completed";
            await Task.Delay(2000);
            ResetValues();
        }

        private void Compress(string folderPath)
        {
            string zipArchivePath = folderPath + ".zip";

            if (File.Exists(zipArchivePath))
            {
                FindUniqueName(zipArchivePath, out string newPath);
                zipArchivePath = newPath;
            }

            using FileStream fs1 = new(zipArchivePath, FileMode.Create);

            using ZipArchive archive = new(fs1, ZipArchiveMode.Update);

            DirectoryInfo directory = new(folderPath);

            FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);

            int count = 1;
            foreach (FileInfo file in files)
            {
                using (FileStream fs = new(file.FullName, FileMode.Open))
                {
                    using FileStream cfs = File.Create(file.FullName + ".8zip");

                    using DeflateStream compressor = new(cfs, CompressionMode.Compress);
                    fs.CopyTo(compressor);
                }
                string relativePath = Path.GetRelativePath(folderPath, file.FullName);
                archive.CreateEntryFromFile(file.FullName + ".8zip", relativePath.Replace(".8zip", ""));

                File.Delete(file.FullName + ".8zip");

                UpdateProgressBar(count++);
            }
        }

        private void Decompress(string zipArchivePath)
        {
            string folderDestinationPath = zipArchivePath.Replace(".zip", "");

            if (Directory.Exists(folderDestinationPath))
            {
                FindUniqueName(folderDestinationPath, out string newPath);
                folderDestinationPath = newPath;
            }

            Directory.CreateDirectory(folderDestinationPath);

            using FileStream fs = new(zipArchivePath, FileMode.Open);

            using ZipArchive archive = new(fs, ZipArchiveMode.Update);

            int count = 1;
            foreach (ZipArchiveEntry entry in archive.Entries)
            {
                string? currentDir = Path.GetDirectoryName(entry.FullName);
                if (!Directory.Exists(folderDestinationPath + "\\" + currentDir))

                {
                    Directory.CreateDirectory(folderDestinationPath + "\\" + currentDir);
                }

                using (Stream stream = entry.Open())
                {
                    using FileStream dfs = new(folderDestinationPath + "\\" + entry.FullName, FileMode.Create);

                    using DeflateStream decompressor = new(stream, CompressionMode.Decompress);
                    decompressor.CopyTo(dfs);
                }

                UpdateProgressBar(count++);
            }
        }

        private void FindUniqueName(string path, out string newPath)
        {
            string dir = Path.GetDirectoryName(path);
            string file = Path.GetFileNameWithoutExtension(path);
            string ext = Path.GetExtension(path);

            int i = 1;
            do
            {
                path = Path.Combine(dir, file + "(" + i++.ToString() + ")" + ext);

            } while (File.Exists(path));
            newPath = path;
        }

        private void UpdateProgressBar(int count)
        {
            progressBar1.Increment(1);
            lblProgress.Text = "Progress: " + count + "/" + progressBar1.Maximum + " files";
        }

        private void ResetValues()
        {
            lblFilePath.Text = "";
            lblFileSize.Text = "";
            lblProgress.Text = "";
            pathToFile = "";
            pathToZip = "";
            nbOfFiles = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            lblProgress.Visible = false;
            lblPlaceHolder.Visible = true;
        }

        private void DisplayZipInfo()
        {
            long totalSize = 0;
            lblFilePath.Visible = true;
            lblFilePath.Text = pathToZip;

            using ZipArchive archive = ZipFile.OpenRead(pathToZip);

            foreach (ZipArchiveEntry entry in archive.Entries)
            {
                totalSize += entry.Length;
            }

            lblFileSize.Visible = true;
            lblFileSize.Text = "Total Size: " + totalSize + " bytes".ToString();

            lblProgress.Visible = true;
            nbOfFiles = archive.Entries.Count;

            progressBar1.Visible = true;
            progressBar1.Maximum = nbOfFiles;

            lblPlaceHolder.Visible = false;
        }

        private void DisplayFolderInfo()
        {
            DirectoryInfo di = new(pathToFile);

            lblFilePath.Visible = true;
            lblFilePath.Text = di.FullName;

            int totalSize = (int)di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
            lblFileSize.Visible = true;
            lblFileSize.Text = "Total Size: " + totalSize + " bytes".ToString();

            lblProgress.Visible = true;
            nbOfFiles = di.GetFiles("*", SearchOption.AllDirectories).Length;

            progressBar1.Visible = true;
            progressBar1.Maximum = nbOfFiles;

            lblPlaceHolder.Visible = false;
        }
    }
}