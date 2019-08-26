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

namespace ProgressBarAndCopy
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog ccc = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
        }

        private void CopyFile(string source, string destination, DoWorkEventArgs e)
        {
            FileStream fsOut = new FileStream(destination, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] buffer = new byte[4096];
            int readBytes;
            while((readBytes = fsIn.Read(buffer,0,buffer.Length))>0)
            {
                if(worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.ReportProgress(0);
                    fsIn.Close();
                    fsOut.Close();
                    return;
                }
                else
                {
                    fsOut.Write(buffer, 0, readBytes);
                    float prog = fsIn.Position * 100 / fsIn.Length; 
                    worker.ReportProgress((int) prog);
                    
                }                
            }
            fsIn.Close();
            fsOut.Close();
        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                progressBar1.Visible = false;
                MessageBox.Show("Копирование отменено", "Отменено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                progressBar1.Visible = false;
                MessageBox.Show("Копирование завершено", "Отменено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(inputFile, outputFile + @"\" + Path.GetFileName(inputFile), e);
        }

        string inputFile = null;
        string outputFile = null;
        private void btnFile1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                inputFile = ofd.FileName;
                txtSourse.Text = inputFile;
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            if (ccc.ShowDialog() == DialogResult.OK)
            {
                outputFile = ccc.SelectedPath;
                txtDestination.Text = outputFile + @"\" + Path.GetFileName(inputFile);
                
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(worker.IsBusy)
            {
                label3.Visible = true;
                //label3.Text = string.Format(" {0:F1}% ", prog);
            }
            else
            {
                progressBar1.Visible = true;
                worker.RunWorkerAsync();

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
        }       
    }
}
