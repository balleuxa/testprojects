using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void btnNewText_Click(object sender, EventArgs e)
        {
            rtxtInput.Text = string.Empty;

        }
        private void btnSaveText_Click(object sender, EventArgs e)
        {
            try
            {
                CreateHmtlFile(out string filePath);
                File.WriteAllText(filePath, rtxtInput.Text);
                ProcessStartInfo psi = new ProcessStartInfo(filePath);
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateHmtlFile(out string filePath)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save file as... ";
            sfd.Filter = "HTML files (*.html)|*.html";
            sfd.ShowDialog();
            filePath = sfd.FileName;
        }

        private async void btnChatGPT_Click(object sender, EventArgs e)
        {
            OpenAI ai = new OpenAI("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");
            rtxtInput.Text = await ai.GenerateText("Generate a COMPLETE basic HTML code for testing purposes, it should contain html,head and body tags only.");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try 
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                rtxtInput.Text = File.ReadAllText(ofd.FileName);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}