using System;
using System.Drawing;
using System.Windows.Forms;

namespace TSPP_Lab1
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        //Volk lab4
=======
        //Lab4 - GitHub
>>>>>>> refs/remotes/origin/Second
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSPP_LabDataSet.Master' table. You can move, or remove it, as needed.
            this.masterTableAdapter.Fill(this.tSPP_LabDataSet.Master);
            // TODO: This line of code loads data into the 'tSPP_LabDataSet.Holding' table. You can move, or remove it, as needed.
            this.holdingTableAdapter.Fill(this.tSPP_LabDataSet.Holding);
            // TODO: This line of code loads data into the 'tSPP_LabDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.tSPP_LabDataSet.Client);
            
        }

        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            clientTableAdapter.Update(tSPP_LabDataSet.Client);
            tSPP_LabDataSet.Client.AcceptChanges();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSPP_LabDataSet);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSPP_LabDataSet);

        }

        private void toolStripButton22_Click_1(object sender, EventArgs e)
        {
            string path = "";
            openFileDialog1.Title = "Выберите файл";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            path = openFileDialog1.FileName;
            Bitmap img = new Bitmap(path);
            int i = 0;
            i = clientDataGridView.CurrentRow.Index;
            clientDataGridView.Rows[i].Cells[5].Value = img;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнили студенты 336гр. \nГромов");
        }

        private void helpContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\shado\Documents\Visual Studio 2015\Projects\TSPP_Lab1\TSPP_Lab1\bin\Debug\chm.chm");
        }

        private void clientDataGridView_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = "Статус:";
        }

        private void masterDataGridView_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "Статус:";
        }

        private void clientDataGridView_MouseEnter(object sender, EventArgs e)
        {
            label6.Text += " Данная таблица предназначена для хранения информации о клиентах";
        }

        private void holdingDataGridView_MouseEnter(object sender, EventArgs e)
        {
            label6.Text += " Данная таблица предназначена для хранения информации об участках";
        }

        private void masterDataGridView_MouseEnter(object sender, EventArgs e)
        {
            label5.Text += " Данная таблица предназначена для хранения информации о владельцах";
        }

        private void holdingDataGridView1_MouseEnter(object sender, EventArgs e)
        {
            label5.Text += " Данная таблица предназначена для хранения информации об участках";
        }
    }
}
