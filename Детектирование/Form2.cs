using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Детектирование
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress from = new MailAddress(textBox1.Text, textBox3.Text);

                MailAddress to = new MailAddress("kostya12277@yandex.ru");

                MailMessage m = new MailMessage(from, to);

                m.Subject = textBox3.Text;

                m.Body = richTextBox1.Text;

                m.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);

                smtp.Credentials = new NetworkCredential(textBox1.Text, textBox2.Text);
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Спасибо ваше сообщение отправлено");
            }
            catch { MessageBox.Show("Неверный тип данных!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }
    }
}
