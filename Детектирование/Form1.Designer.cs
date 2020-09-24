namespace Детектирование
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартнаяКамераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьКамеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контурныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лицоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глазаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эмоцияУлыбкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номернойЗнакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телоВерхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телоНизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телоПолноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратнаяСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.создатьОбразToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОбразToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.обучениеToolStripMenuItem,
            this.обратнаяСвязьToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.сохранитьИзображениеToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gToolStripMenuItem.Text = "Показать признаки ";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // сохранитьИзображениеToolStripMenuItem
            // 
            this.сохранитьИзображениеToolStripMenuItem.Name = "сохранитьИзображениеToolStripMenuItem";
            this.сохранитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.сохранитьИзображениеToolStripMenuItem.Text = "Сохранить изображение";
            this.сохранитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзображениеToolStripMenuItem_Click);
            // 
            // подключитьToolStripMenuItem
            // 
            this.подключитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартнаяКамераToolStripMenuItem,
            this.отключитьКамеруToolStripMenuItem});
            this.подключитьToolStripMenuItem.Name = "подключитьToolStripMenuItem";
            this.подключитьToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.подключитьToolStripMenuItem.Text = "Подключить";
            this.подключитьToolStripMenuItem.Click += new System.EventHandler(this.подключитьToolStripMenuItem_Click);
            // 
            // стандартнаяКамераToolStripMenuItem
            // 
            this.стандартнаяКамераToolStripMenuItem.Name = "стандартнаяКамераToolStripMenuItem";
            this.стандартнаяКамераToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.стандартнаяКамераToolStripMenuItem.Text = "Стандартная камера";
            this.стандартнаяКамераToolStripMenuItem.Click += new System.EventHandler(this.стандартнаяКамераToolStripMenuItem_Click);
            // 
            // отключитьКамеруToolStripMenuItem
            // 
            this.отключитьКамеруToolStripMenuItem.Name = "отключитьКамеруToolStripMenuItem";
            this.отключитьКамеруToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.отключитьКамеруToolStripMenuItem.Text = "Отключить камеру";
            this.отключитьКамеруToolStripMenuItem.Click += new System.EventHandler(this.отключитьКамеруToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандарныйToolStripMenuItem,
            this.контурныйToolStripMenuItem,
            this.негативToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Visible = false;
            // 
            // стандарныйToolStripMenuItem
            // 
            this.стандарныйToolStripMenuItem.Name = "стандарныйToolStripMenuItem";
            this.стандарныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.стандарныйToolStripMenuItem.Text = "Стандарный";
            // 
            // контурныйToolStripMenuItem
            // 
            this.контурныйToolStripMenuItem.CheckOnClick = true;
            this.контурныйToolStripMenuItem.Name = "контурныйToolStripMenuItem";
            this.контурныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.контурныйToolStripMenuItem.Text = "Контурный";
            this.контурныйToolStripMenuItem.Click += new System.EventHandler(this.контурныйToolStripMenuItem_Click);
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            this.негативToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.негативToolStripMenuItem.Text = "Негатив";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лицоToolStripMenuItem,
            this.глазаToolStripMenuItem,
            this.эмоцияУлыбкаToolStripMenuItem,
            this.номернойЗнакToolStripMenuItem,
            this.телоВерхToolStripMenuItem,
            this.телоНизToolStripMenuItem,
            this.телоПолноеToolStripMenuItem});
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.найтиToolStripMenuItem.Text = "Найти";
            // 
            // лицоToolStripMenuItem
            // 
            this.лицоToolStripMenuItem.CheckOnClick = true;
            this.лицоToolStripMenuItem.Name = "лицоToolStripMenuItem";
            this.лицоToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.лицоToolStripMenuItem.Text = "Лицо";
            this.лицоToolStripMenuItem.Click += new System.EventHandler(this.лицоToolStripMenuItem_Click);
            // 
            // глазаToolStripMenuItem
            // 
            this.глазаToolStripMenuItem.CheckOnClick = true;
            this.глазаToolStripMenuItem.Name = "глазаToolStripMenuItem";
            this.глазаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.глазаToolStripMenuItem.Text = "Глаза";
            // 
            // эмоцияУлыбкаToolStripMenuItem
            // 
            this.эмоцияУлыбкаToolStripMenuItem.CheckOnClick = true;
            this.эмоцияУлыбкаToolStripMenuItem.Name = "эмоцияУлыбкаToolStripMenuItem";
            this.эмоцияУлыбкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.эмоцияУлыбкаToolStripMenuItem.Text = "Губы";
            // 
            // номернойЗнакToolStripMenuItem
            // 
            this.номернойЗнакToolStripMenuItem.CheckOnClick = true;
            this.номернойЗнакToolStripMenuItem.Name = "номернойЗнакToolStripMenuItem";
            this.номернойЗнакToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.номернойЗнакToolStripMenuItem.Text = "Нос";
            // 
            // телоВерхToolStripMenuItem
            // 
            this.телоВерхToolStripMenuItem.CheckOnClick = true;
            this.телоВерхToolStripMenuItem.Name = "телоВерхToolStripMenuItem";
            this.телоВерхToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.телоВерхToolStripMenuItem.Text = "Тело (Верх)";
            // 
            // телоНизToolStripMenuItem
            // 
            this.телоНизToolStripMenuItem.CheckOnClick = true;
            this.телоНизToolStripMenuItem.Name = "телоНизToolStripMenuItem";
            this.телоНизToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.телоНизToolStripMenuItem.Text = "Тело(Низ)";
            // 
            // телоПолноеToolStripMenuItem
            // 
            this.телоПолноеToolStripMenuItem.CheckOnClick = true;
            this.телоПолноеToolStripMenuItem.Name = "телоПолноеToolStripMenuItem";
            this.телоПолноеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.телоПолноеToolStripMenuItem.Text = "Тело(Полное)";
            // 
            // обучениеToolStripMenuItem
            // 
            this.обучениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОбразToolStripMenuItem,
            this.удалитьОбразToolStripMenuItem});
            this.обучениеToolStripMenuItem.Name = "обучениеToolStripMenuItem";
            this.обучениеToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.обучениеToolStripMenuItem.Text = "Обучение";
            // 
            // обратнаяСвязьToolStripMenuItem
            // 
            this.обратнаяСвязьToolStripMenuItem.Name = "обратнаяСвязьToolStripMenuItem";
            this.обратнаяСвязьToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.обратнаяСвязьToolStripMenuItem.Text = "Обратная связь";
            this.обратнаяСвязьToolStripMenuItem.Click += new System.EventHandler(this.обратнаяСвязьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(530, 0, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Location = new System.Drawing.Point(758, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 441);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Silver;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageBox1.Enabled = false;
            this.imageBox1.InitialImage = null;
            this.imageBox1.Location = new System.Drawing.Point(0, 24);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(508, 441);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(514, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(514, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // создатьОбразToolStripMenuItem
            // 
            this.создатьОбразToolStripMenuItem.Name = "создатьОбразToolStripMenuItem";
            this.создатьОбразToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.создатьОбразToolStripMenuItem.Text = "Создать образ";
            this.создатьОбразToolStripMenuItem.Click += new System.EventHandler(this.создатьОбразToolStripMenuItem_Click_1);
            // 
            // удалитьОбразToolStripMenuItem
            // 
            this.удалитьОбразToolStripMenuItem.Name = "удалитьОбразToolStripMenuItem";
            this.удалитьОбразToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.удалитьОбразToolStripMenuItem.Text = "Удалить образ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(940, 465);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль пользователя ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандарныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контурныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лицоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem глазаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратнаяСвязьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem подключитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартнаяКамераToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.ToolStripMenuItem телоВерхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телоНизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телоПолноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номернойЗнакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эмоцияУлыбкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьКамеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem создатьОбразToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьОбразToolStripMenuItem;
    }
}

