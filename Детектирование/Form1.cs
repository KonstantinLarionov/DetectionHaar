using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;

namespace Детектирование
{
    public partial class Form1 : Form
    {
        CascadeClassifier haarCascade;
        CascadeClassifier haarCascadee;
        CascadeClassifier haarCascadeee;
        CascadeClassifier smille;
        CascadeClassifier Nouz;

        VideoCapture capture;
        Mat m;
        Rectangle[] faces;
        Rectangle[] es;

        Image<Bgr, Byte> image;
        Rectangle face1;
        Rectangle Noze;
        Rectangle Mouz;
        Rectangle Eyes;

        Point Gl1, Gl2, Gl3, Gl4;   //  Левый глаз
        Point Gr1, Gr2, Gr3, Gr4;   //  Правый глаз
        Point UF, LF, RF, DF1, DF2; //  Лицо
        Point N1, N2, N3;           //  Нос
        Point M1, M2, M3, M4;       //  Рот
        
        FileStream data_file = new FileStream("Data_file.txt", FileMode.Open);

        public Form1()
        {
            InitializeComponent();
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void GetVideo()
        {
            capture = new VideoCapture();
            Application.Idle += video_NewFrame;
        }

        public void video_NewFrame(object sender, EventArgs e)
        {
            try
            {
                m = capture.QuerySmallFrame();

                image = m.ToImage<Bgr, Byte>();

                if (контурныйToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    Image<Gray, Byte> Cannybmp;
                    Image<Gray, Byte> GrayBmp;
                    Image<Bgr, Byte> imgSmooth;

                    imgSmooth = image.PyrDown().PyrUp();
                    imgSmooth._SmoothGaussian(3);
                    GrayBmp = imgSmooth.Convert<Gray, byte>();

                    Gray grayCannyThreshold = new Gray(160.0);
                    Gray grayThreshLinking = new Gray(80.0);

                    Cannybmp = GrayBmp.Canny(grayCannyThreshold.Intensity, grayThreshLinking.Intensity);
                    imageBox1.Image = Cannybmp;
                }
                var grayframe = image.Convert<Gray, byte>();
                if (лицоToolStripMenuItem.CheckState == CheckState.Checked)
                {
                   
                    faces = haarCascade.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);
                   
                    foreach (var face in faces)
                    {
                        image.Draw(face, new Bgr(Color.Green), 1);
                        face1 = face;
                       
                    }
                    if (faces.Length <1)
                    {


                        var faces2 = haarCascadeee.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);
                        foreach (var face2 in faces2)
                        {
                            image.Draw(face2, new Bgr(Color.Green), 1);
                        }
                    }
                    
                    
                }
                if (эмоцияУлыбкаToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    smille = new CascadeClassifier("Mouth.xml");
                    var smilles = smille.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);
                    foreach (var sm in smilles)
                    {
                        image.Draw(sm, new Bgr(Color.Green), 1);
                        Mouz = sm;
                        
                    }
                }
                //Детектирование лица
                if (глазаToolStripMenuItem.CheckState == CheckState.Checked)
                {
                   
                     es = haarCascadee.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);
                    foreach (var c in es)
                    {
                        image.Draw(c, new Bgr(Color.Red), 1);
                        Eyes = c;
                        
                    }
                }
                //Детектирование глаза
                if (номернойЗнакToolStripMenuItem.CheckState == CheckState.Checked)
                {
                    Nouz = new CascadeClassifier("Nariz.xml");
                    var numbers = Nouz.DetectMultiScale(grayframe, 1.1, 10, Size.Empty);
                    foreach (var number in numbers)
                    {
                        image.Draw(number, new Bgr(Color.Pink), 1);
                        Noze = number;
                       
                    }
                }
               
                //Детектирование тела
                if (контурныйToolStripMenuItem.CheckState != CheckState.Checked)
                {
                    imageBox1.Image = image;
                }
               
            }
            catch 
            {
                return;
            }
            
        }

        public void SearchPoint()
        {
            DF1 = new Point(face1.Location.X + 0, face1.Location.Y + face1.Height);
            DF2 = new Point(face1.Location.X + face1.Width, face1.Location.Y + face1.Height);
            LF = new Point(face1.Location.X + 0, face1.Location.Y + face1.Height / 2);
            RF = new Point(face1.Location.X + face1.Width, face1.Location.Y + face1.Height / 2);
            UF = new Point(face1.Location.X + face1.Width / 2, face1.Location.Y + 0);

            Gl1 = new Point(es[0].Location.X + es[0].Width / 2, es[0].Location.Y + 0);
            Gl2 = new Point(es[0].Location.X + es[0].Width, es[0].Location.Y + es[0].Height / 2);
            Gl3 = new Point(es[0].Location.X + es[0].Width / 2, es[0].Location.Y + es[0].Height);
            Gl4 = new Point(es[0].Location.X + 0, es[0].Location.Y + es[0].Height / 2);
            Gr1 = new Point(es[1].Location.X + es[1].Width / 2, es[1].Location.Y + 0);
            Gr2 = new Point(es[1].Location.X + es[1].Width, es[1].Location.Y + es[1].Height / 2);
            Gr3 = new Point(es[1].Location.X + es[1].Width / 2, es[1].Location.Y + es[1].Height);
            Gr4 = new Point(es[1].Location.X + 0, es[1].Location.Y + es[1].Height / 2);

            N1 = new Point(Noze.Location.X + Noze.Width / 2, Noze.Location.Y + Noze.Height / 2);
            N2 = new Point(Noze.Location.X + Noze.Width, Noze.Location.Y + Noze.Height);
            N3 = new Point(Noze.Location.X + 0, Noze.Location.Y + Noze.Height);

            M1 = new Point(Mouz.Location.X + Mouz.Width / 2, Mouz.Location.Y + 0);
            M2 = new Point(Mouz.Location.X + Mouz.Width, Mouz.Location.Y + Mouz.Height / 2);
            M3 = new Point(Mouz.Location.X + Mouz.Width / 2, Mouz.Location.Y + Mouz.Height);
            M4 = new Point(Mouz.Location.X + 0, Mouz.Location.Y + Mouz.Height / 2);
        }

        public void OTNG()
        {
            double Dl1, Dl2, OTNg;

            StreamWriter streamWriter = new StreamWriter(data_file);
            Dl1 = Math.Sqrt(Math.Pow(Gl2.X - Gl1.X, 2) + Math.Pow(Gl2.Y - Gl1.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(Gr3.X - Gr2.X, 2) + Math.Pow(Gr3.Y - Gr2.Y, 2)); //Длина 2
            OTNg = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNg.ToString());

            Dl1 = Math.Sqrt(Math.Pow(Gl3.X - Gl2.X, 2) + Math.Pow(Gl3.Y - Gl2.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(Gr2.X - Gr1.X, 2) + Math.Pow(Gr2.Y - Gr1.Y, 2)); //Длина 2
            OTNg = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNg.ToString());

            Dl1 = Math.Sqrt(Math.Pow(Gl4.X - Gl1.X, 2) + Math.Pow(Gl4.Y - Gl1.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(Gr4.X - Gr3.X, 2) + Math.Pow(Gr4.Y - Gr3.Y, 2)); //Длина 2
            OTNg = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNg.ToString());

            Dl1 = Math.Sqrt(Math.Pow(Gl4.X - Gl3.X, 2) + Math.Pow(Gl4.Y - Gl3.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(Gr4.X - Gr1.X, 2) + Math.Pow(Gr4.Y - Gr1.Y, 2)); //Длина 2
            OTNg = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNg.ToString());
        }

        public void OTNgn()
        {
            double Dl1, Dl2, OTNgn;

            StreamWriter streamWriter = new StreamWriter(data_file);
            Dl1 = Math.Sqrt(Math.Pow(Gl2.X - Gr2.X, 2) + Math.Pow(Gl2.Y - Gr1.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(Gl2.X - N1.X, 2) + Math.Pow(Gl2.Y - N1.Y, 2)); //Длина 2
            OTNgn = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNgn.ToString());

            Dl2 = Math.Sqrt(Math.Pow(Gr2.X - N1.X, 2) + Math.Pow(Gr2.Y - N1.Y, 2)); //Длина 2
            OTNgn = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNgn.ToString());

            Dl1 = Math.Sqrt(Math.Pow(Gl2.X - N1.X, 2) + Math.Pow(Gl2.Y - N1.Y, 2)); //Длина 1
            OTNgn = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNgn.ToString());

        }

        public void OTNn()
        {
            double Dl1, Dl2, OTNn;

            StreamWriter streamWriter = new StreamWriter(data_file);
            Dl1 = Math.Sqrt(Math.Pow(N3.X - N1.X, 2) + Math.Pow(N3.Y - N1.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(N2.X - N3.X, 2) + Math.Pow(N2.Y - N3.Y, 2)); //Длина 2
            OTNn = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNn.ToString());

            Dl2 = Math.Sqrt(Math.Pow(N2.X - N1.X, 2) + Math.Pow(N2.Y - N1.Y, 2)); //Длина 2
            OTNn = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNn.ToString());

            Dl1 = Math.Sqrt(Math.Pow(N2.X - N3.X, 2) + Math.Pow(N2.Y - N3.Y, 2)); //Длина 1
            OTNn = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNn.ToString());

        }

        public void OTNrl()
        {
            double Dl1, Dl2, OTNrl;

            StreamWriter streamWriter = new StreamWriter(data_file);
            Dl1 = Math.Sqrt(Math.Pow(M4.X - DF1.X, 2) + Math.Pow(M4.Y - DF1.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(M2.X - DF2.X, 2) + Math.Pow(M2.Y - DF2.Y, 2)); //Длина 2
            OTNrl = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNrl.ToString());

            Dl2 = Math.Sqrt(Math.Pow(DF2.X - DF1.X, 2) + Math.Pow(DF2.Y - DF1.Y, 2)); //Длина 2
            OTNrl = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNrl.ToString());

            Dl1 = Math.Sqrt(Math.Pow(M2.X - DF2.X, 2) + Math.Pow(M2.Y - DF2.Y, 2)); //Длина 1
            OTNrl = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNrl.ToString());
        }

        public void OTNuf()
        {
            double Dl1, Dl2, Dl3, OTNuf;

            StreamWriter streamWriter = new StreamWriter(data_file);
            Dl1 = Math.Sqrt(Math.Pow(UF.X - Gl4.X, 2) + Math.Pow(UF.Y - Gl4.Y, 2)); //Длина 1
            Dl2 = Math.Sqrt(Math.Pow(UF.X - Gr2.X, 2) + Math.Pow(UF.Y - Gr2.Y, 2)); //Длина 2
            Dl3 = Dl2;
            OTNuf = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNuf.ToString());

            Dl2 = Math.Sqrt(Math.Pow(LF.X - Gl4.X, 2) + Math.Pow(LF.Y - Gl4.Y, 2)); //Длина 2
            OTNuf = Dl2 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNuf.ToString());

            Dl1 = Math.Sqrt(Math.Pow(RF.X - Gr2.X, 2) + Math.Pow(RF.Y - Gr2.Y, 2)); //Длина 1
            OTNuf = Dl3 / Dl1; // Отношение длин
            streamWriter.BaseStream.Seek(data_file.Length, SeekOrigin.End);// конец файла
            streamWriter.Write(OTNuf.ToString());
        }

        private void создатьОбразToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        bool a = true;
        private void стандартнаяКамераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a)
            {
                GetVideo();
                a = false;
                richTextBox1.Text += "Вывод потока..."+"\n";
                return;
            }
            
        }

        private void обратнаяСвязьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void лицоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void сохранитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (imageBox1.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        imageBox1.Image.Save(savedialog.FileName);
                        richTextBox1.Text += "Изображение сохранено!"+"\n";
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            haarCascade = new CascadeClassifier("haarcascade_frontalface_alt.xml");
            haarCascadeee = new CascadeClassifier("haarcascade_profileface.xml");
            haarCascadee = new CascadeClassifier("haarcascade_eye.xml");
            richTextBox1.Text += "Каскады подгружены..." + "\n";
            richTextBox1.Text += "Здравствуйте!" + "\n" + "Нажмите: Подключиться." + "\n";
        }

        private void отключитьКамеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Dispose();
            a = true;
        }
    
        private void создатьОбразToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap ing, ing1;
                ing1 = new Bitmap(face1.Width, face1.Height);
                Graphics g = Graphics.FromImage(ing1);
                ing = image.ToBitmap();
                g.DrawImage(ing, -face1.X, -face1.Y);
                pictureBox1.Image = ing1;
                richTextBox1.Text += "Образ создан!";
            }
            catch { MessageBox.Show("Нет потока!"); }
        }
     
        private void сохранитьОбразToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName);
                        richTextBox1.Text += "Образ сохранен!" + "\n";
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } //Сохранение файла рект;
        }
        
        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap mapPoint = new Bitmap(pictureBox2.Width,pictureBox2.Height);
            Bitmap point = new Bitmap(2, 2);
            Graphics w = Graphics.FromImage(point);
            w.Clear(Color.White);
            Pen pen = new Pen(Color.White, 2);
            Graphics g = Graphics.FromImage(mapPoint);
            g.Clear(Color.Black);
            SearchPoint();

            g.DrawImage(point, UF);
            g.DrawImage(point, LF);
            g.DrawImage(point, RF);
            g.DrawImage(point, DF1);
            g.DrawImage(point, DF2);

            g.DrawImage(point, Gl1);
            g.DrawImage(point, Gl2);
            g.DrawImage(point, Gl3);
            g.DrawImage(point, Gl4);

            g.DrawImage(point, Gr1);
            g.DrawImage(point, Gr2);
            g.DrawImage(point, Gr3);
            g.DrawImage(point, Gr4);

            g.DrawImage(point, N1);
            g.DrawImage(point, N2);
            g.DrawImage(point, N3);

            g.DrawImage(point, M1);
            g.DrawImage(point, M2);
            g.DrawImage(point, M3);
            g.DrawImage(point, M4);

            pictureBox2.Image = mapPoint;

        }

        private void подключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Выберите камеру..."+"\n";
        }

        private void контурныйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
