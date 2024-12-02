using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMain : Form
    {
        List<IPModel> IPCollection = IPApplication.model;

        public frmMain()
        {
            InitializeComponent();
            LoadAndDisplayIPs();
        }

        private void ReloadIPs()
        {
            dgvIPList.Invoke(new Action(() =>
            {
                dgvIPList.DataSource = null;
                dgvIPList.DataSource = IPCollection;
            }));

        }
        private void LoadAndDisplayIPs()
        {
            IPApplication.LoadIPsFromFile();
            dgvIPList.DataSource = IPCollection;
            //foreach (var ip in IPApplication.ipList)
            //{
            //    dgvIPList.Rows.Add(ip.Ip, ip.Port, ip.Ttl, ip.Infoport);
            //}
        }




        private void menuGenrateSampleData_Click(object sender, EventArgs e)
        {
            try
            {
                bgWorker.RunWorkerAsync();
            }
            catch
            {
                MessageBox.Show("Error in generate data!");
            }

        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (long i = 0; i < 100; i++)
            {
                IPModel model = new IPModel();
                model.Infoport = "open udp";
                model.Ip = "192.168.1.1";
                model.Port = 338;
                model.Ttl = 29210;
                IPCollection.Add(model);
                ReloadIPs();
                System.Threading.Thread.Sleep(25);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("generate file completed!");
            //if (IPCollection.Count() > 0)
            //{
            //    menuOptionDelete.Enabled = true;
            //}
            //else
            //{
            //    menuOptionDelete.Enabled=false;
            //}
        }

        private void menuFileSaveFile_Click(object sender, EventArgs e)
        {
            IPApplication.SaveIPsToFile();
            MessageBox.Show("IP list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuOptionSeparator_Click(object sender, EventArgs e)
        {


            dgvIPList.Columns["Infoport"].Visible = false;
            dgvIPList.Columns["Ttl"].Visible = false;
            dgvIPList.Columns["Port"].DisplayIndex = 2;
            dgvIPList.Columns["Ip"].DisplayIndex = 1;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string IPtitle = dgvIPList.CurrentRow.Cells("Infoport").Value.ToString();
            //foreach (var item in IPCollection)
            //{
            //    if (item.Infoport == IPtitle)
            //    {
            //        item.Infoport.Remove(item);
            //        break;
            //    }
            //}

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit this App?", "close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuFileLoadFile_Click(object sender, EventArgs e)
        {
         
            IPApplication.LoadIPsFromFile();
            MessageBox.Show("IP list Loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadIPs();
        }

        private void menuProperthisLoad_Click(object sender, EventArgs e)
        {
            ReloadIPs();
        }
    }
}
