using System.Windows.Forms;

namespace Домашня_робота_25._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            string path = richTextBoxPath.Text;

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Папки не існує");
                return;
            }

            listView1.Items.Clear();

            foreach (var dir in Directory.GetDirectories(path))
            {
                ListViewItem item = new ListViewItem("Папка " + Path.GetFileName(dir));
                listView1.Items.Add(item);
            }

            foreach (var file in Directory.GetFiles(path))
            {
                ListViewItem item = new ListViewItem("Файл " + Path.GetFileName(file));
                listView1.Items.Add(item);
            }
        }
    }
}
