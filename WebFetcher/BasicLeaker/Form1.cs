using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BasicLeaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
        private static string outputPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private List<string> imagesLinks = new List<string>();
        private async void btnGetImg_ClickAsync(object sender, EventArgs e)
        {
            string host = txtWebsite.Text;
            await GetImagesFromWebsite(host);
            await DownloadImagesFromWebsite(imagesLinks);
            btnGetImg.Enabled = false;
            await Task.Delay(3000);
        }

        private async Task GetImagesFromWebsite(string host)
        {
            string htmlFile = Path.Combine(outputPath, "WebFetcher", "Website.html");
            try
            {
                string responseBody = await client.GetStringAsync(host);

                using FileStream result = new FileStream(htmlFile, FileMode.Create);

                result.Write(Encoding.ASCII.GetBytes(responseBody));

                imagesLinks = ExtractImages(responseBody);

            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async Task DownloadImagesFromWebsite(List<string> imgLinks)
        {
            string imageFolder = Path.Combine(outputPath, "WebFetcher", "images");
            int imgFailed = 0;
            for (int i = 0; i < imgLinks.Count; i++)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(imgLinks[i]);
                    response.EnsureSuccessStatusCode();

                    using Stream imgData = await response.Content.ReadAsStreamAsync();

                    if (!Directory.Exists(imageFolder))
                    {
                        Directory.CreateDirectory(imageFolder);
                    }

                    using FileStream outImgsFolder = new FileStream($"{imageFolder}\\image{i}.jpg", FileMode.Create);

                    await imgData.CopyToAsync(outImgsFolder);
                }
                catch (Exception ex)
                {
                    imgFailed++;
                    Debug.WriteLine(ex.Message);
                }
            }
            lblResult.Visible = true;
            lblResult.Text = imgLinks.Count - imgFailed + " images found";
        }

        private List<string> ExtractImages(string HtmlCode)
        {
            List<string> downloadLinks = new List<string>();

            Regex htmlImgTag = new Regex(@"<img[^>]+>");
            MatchCollection imgTags = htmlImgTag.Matches(HtmlCode);

            foreach (Match tag in imgTags)
            {
                Regex htmlSrcValue = new Regex(@"src=""(.+?)""");

                Match imgSrc = htmlSrcValue.Match(tag.Value);

                int startIndex = imgSrc.Value.IndexOf("src=\"");

                string link = imgSrc.Value.Substring(startIndex + 5, imgSrc.Value.Length - 6);

                string[] extensions = { "jpeg", ".jpg", ".png", ".gif" };

                foreach (string extension in extensions)
                {
                    if (link.EndsWith(extension))
                    {
                        downloadLinks.Add(link);
                    }
                }
            }

            Debug.WriteLine(downloadLinks.Count + " downloadable images found:");
            foreach (string link in downloadLinks)
            {
                Debug.WriteLine(link);
            }
            return downloadLinks;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = outputPath;
            folderBrowserDialog.ShowDialog();
            outputPath = folderBrowserDialog.SelectedPath;

            string exportPath = Path.Combine(outputPath, "WebFetcher", "images");
            if (!Directory.Exists(exportPath))
            {
                Directory.CreateDirectory(exportPath);
                Debug.WriteLine($"Main folder created at {Path.GetDirectoryName(exportPath)}");
            }
            txtWebsite.Enabled = true;
            lblFolderPath.Text = Path.GetDirectoryName(exportPath);
        }

        private void txtWebsite_Click(object sender, EventArgs e)
        {
            txtWebsite.Text = "";
            txtWebsite.ForeColor = Color.Black;
        }

        private void txtWebsite_TextChanged(object sender, EventArgs e)
        {
            btnGetImg.Enabled = true;
        }
    }
}