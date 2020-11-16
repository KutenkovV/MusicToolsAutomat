using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTools
{
    public partial class Form1 : Form
    {
        List<MusicTools> Tools = new List<MusicTools>();

        public Form1()
        {
            InitializeComponent();

            // показываем наши пустые значения
            Showinfo();
        }

        // Кнопка "обновить" собственно сперва чистит лист, а потом рандомно заполняет методом generate рандомными объектами сам лист
        private void btnReffil_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1; //Обновляем картинку на стндртую если захотели обновить список
            txtout.Clear(); //чистим боксвывода если в нем что то осталось

            this.Tools.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.Tools.Add(Stringed.Generate()); //Заполняем метод случайными объектами с разными значениями
                        break;
                    case 1:
                        this.Tools.Add(Keydoard.Generate());
                        break;
                    case 2:
                        this.Tools.Add(Drum.Generate());
                        break;
                }
            }

            Showinfo(); //показываем наши пустые значения
            ToolShow(); //Обновляем списочек
        }

        // Метод перебирает список и если дочерний объект МузыкаИнструменты есть реально его дочерний объект, то этот объект +1
        private void Showinfo()
        {
            // заведем счетчики под каждый инструмент
            int StringedCount = 0;
            int KeyboardCount = 0;
            int DrumCount = 0;

            foreach (var MusicTools in this.Tools)
            {
                if (MusicTools is Stringed)
                {
                    StringedCount += 1;
                }
                else if (MusicTools is Keydoard)
                {
                    KeyboardCount += 1;
                }
                else if (MusicTools is Drum)
                {
                    DrumCount += 1;
                }
            }

            //вывод на форму наших значений списка
            txtinfo.Text = "Струнные\tКлавишные\tБарабанные";
            txtinfo.Text += "\n";
            txtinfo.Text += String.Format("{0}\t\t{1}\t\t{2}", StringedCount, KeyboardCount, DrumCount);
        }

        // Метод выводит элементы списка в окно "ассортимент автомата"
        private void ToolShow()
        {
            richTextBox1.Text = "";
            for (var i = 0; i < this.Tools.Count; ++i)
            {
                var musicTools = this.Tools[i];
                if (musicTools is Stringed)
                {
                    richTextBox1.Text = richTextBox1.Text + ("\nСтрунные инструменты");
                }
                if (musicTools is Keydoard)
                {
                    richTextBox1.Text = richTextBox1.Text + ("\nКлавишные инструменты");
                }
                if (musicTools is Drum)
                {
                    richTextBox1.Text = richTextBox1.Text + ("\nБарабаные инструменты"); ;
                }
            }
        }

        // кнопка взять случайный товар
        private void btnGet_Click(object sender, EventArgs e)
        {
            //если в списке ничего нету, то выводим ниже
            if (this.Tools.Count == 0)
            {
                txtout.Text = "В автомате пусто!";
                pictureBox1.Image = Properties.Resources._1;

                return;
            }

            var toolobj = this.Tools[0]; //Дослновно - "объкект toolobj есть первый объект списка Тулс
            this.Tools.RemoveAt(0); // очень важная строчка на самом деле - удаляет первый элемент в списке при клике кнопки

            txtout.Text = toolobj.GetInfo();
            if (toolobj is Stringed)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            if (toolobj is Keydoard)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            if (toolobj is Drum)
            {
                pictureBox1.Image = Properties.Resources._3;
            }

            //выводим наши строки об инструментах
            txtout.Text = toolobj.GetInfo();

            Showinfo(); // Обновляем
            ToolShow(); // Обновляем 
        }

        //кнопка открытия второй формы
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 task = new Form2();
            task.Show();
        }
    }
}
