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
        List<Dictionary<int,String>> data = new List<Dictionary<int, String>>();

        public main_form()
        {
            InitializeComponent();
        }

        void Draw()
        {
            bmp = new Bitmap(pb_image.Width, pb_image.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red);
            //graph.DrawLine(pen, 10,50,150,200);

            for(int i=0; i < data.Count; i++)
            {
                graph.DrawLine(pen, 5 * float.Parse(data[i][10],System.Globalization.CultureInfo.InvariantCulture),
                    5 * float.Parse(data[i][20], System.Globalization.CultureInfo.InvariantCulture),
                    5 * float.Parse(data[i][11], System.Globalization.CultureInfo.InvariantCulture),
                    5 * float.Parse(data[i][21], System.Globalization.CultureInfo.InvariantCulture));
            }


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

                List<string> input = new List<string>();
                while ((read = reader.ReadLine()) != null)
                    input.Add(read);
                file1.Close();

                int index = input.IndexOf("ENTITIES");
                input.RemoveRange(0, index);
                index = input.IndexOf("ENDSEC");
                input.RemoveRange(index, input.Count-index);

                while (true)
                {
                    index = input.IndexOf("LINE");
                    if (index == -1)
                        break;
                    Dictionary<int, String> temp = new Dictionary<int, String>();
                    temp.Add(0, input[index]);
                    int[] dxf_code = { 10, 20, 30, 11, 21, 31 };

                    for(int i=0;i < dxf_code.Length; i++)
                    {
                        index = input.IndexOf(" "+dxf_code[i].ToString());
                        temp.Add(dxf_code[i], input[index + 1]);
                    }
                    input.RemoveRange(0, index+2);
                    data.Add(temp);
                }
                Draw();
                
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