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
        Graphics graph;
        List<Geometry> data = new List<Geometry>();
        Dictionary<String, int[]> dxf_codes = new Dictionary<string, int[]>();
        Color[] colors = {Color.Blue,
                Color.Green,
                Color.Red,
                Color.Cyan,
                Color.Olive,
                Color.YellowGreen,
                Color.Black,
                Color.BlueViolet,
                Color.Gold,
                Color.Pink,
                Color.Aqua,
                Color.Brown,
                Color.DarkBlue,
                Color.DarkGreen,
                Color.DeepSkyBlue,
                Color.Green,
                Color.Indigo,
                Color.Lime,
                Color.MistyRose,
                Color.Navy};

        public main_form()
        {
            InitializeComponent();
            Init();
            init_dxf_codes();
            numPenWidth.ValueChanged += ReDraw;
            numScale.ValueChanged += ReDraw;
            lbColors.SelectedIndexChanged += ReDraw;
        }

        void init_dxf_codes()
        {
            dxf_codes.Add("LINE", new int[] { 10, 20, 30, 11, 21, 31 });
            dxf_codes.Add("CIRCLE", new int[] { 10, 20, 30, 40 });
        }

        void Init()
        {
            bmp = new Bitmap(pb_image.Width, pb_image.Height);
            graph = Graphics.FromImage(bmp);
            foreach (var color in colors)
                lbColors.Items.Add(color.ToString());
            lbColors.SelectedIndex = 2;
        }

        private void ReDraw(object sender, EventArgs e)
        {
            Draw();
        }

        void Draw()
        {
            graph.Clear(Color.White);
            Pen pen = new Pen(colors[lbColors.SelectedIndex]);
            pen.Width = (float)numPenWidth.Value;
            for (int i=0; i < data.Count; i++)
            {
                data[i].Draw(graph, pen, (float)numScale.Value/100);
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
                    var keys = dxf_codes.Keys;
                    index = input.Count;
                    int counter = 0;
                    foreach(var key in keys)
                    {
                        int i = input.IndexOf(key);
                        if (i < index && i != -1)
                            index = i;
                        else if (i == -1)
                            counter++;
                    }
                    if (counter == keys.Count)
                        break;

                    String type = input[index];
                    
                    Dictionary<int, float> temp = new Dictionary<int, float>();

                    try
                    {
                        for (int i = 0; i < dxf_codes[type].Length; i++)
                        {
                            index = input.IndexOf(" " + dxf_codes[type][i].ToString());
                            temp.Add(dxf_codes[type][i], float.Parse(input[index + 1], System.Globalization.CultureInfo.InvariantCulture));
                        }
                        data.Add(new Geometry(type,temp));
                    }
                    catch (Exception) { }

                    input.RemoveRange(0, index+2);
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

