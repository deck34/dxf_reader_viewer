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

namespace dxf_reader_viewer
{
    public partial class main_form : Form
    {
        Bitmap bmp;

        public main_form()
        {
            InitializeComponent();
            Draw();
        }

        void Draw()
        {
            bmp = new Bitmap(pb_image.Width, pb_image.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red);
            graph.DrawLine(pen, 10,50,150,200);
            pb_image.Image = bmp;
        }

        private void ts_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы dxf|*.dxf";
            string File = "";

            if (OPF.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OPF.FileNames)
                {
                    File = file;
                }
                if (File.Length == 0)
                    throw new Exception("Невозможно распознать набор чисел");
            }
            string read = "";
            if (File.Length != 0)
            {
                FileStream file1 = new FileStream(File, FileMode.Open); //создаем файловый поток
                StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
                                                               //read = reader.ReadToEnd();

                List<string> str = new List<string>();
                //List<string[]> str1 = new List<string[]>();
                while ((read = reader.ReadLine()) != null)
                    str.Add(read);

                //for (int i = 0; i < str.Count; i++)
                //    str1.Add(str[i].Split(';'));
                file1.Close();
            }
            else
            {
                MessageBox.Show("Не удалось прочитать файл!\n", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ts_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP file|*.bmp";
            sfd.Title = "Save an BMP File";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                 bmp.Save(sfd.FileName);
            }
        }
    }
}