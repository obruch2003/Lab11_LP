using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Глобальные переменные
        private int x1, y1, x2, y2;
        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            
            // Рисуем точку
            Graphics g = e.Graphics;
            SolidBrush g1 = new SolidBrush(Color.White);
            g.FillEllipse(g1, x1, y1, 4, 4);
            g.FillEllipse(g1, x1+100, y1, 4, 4);
            g.FillEllipse(g1, x1+200, y1, 4, 4);
            g.FillEllipse(g1, x1+300, y1, 4, 4);
            g.FillEllipse(g1, x1+400, y1, 4, 4);
            g.FillEllipse(g1, x1+500, y1, 4, 4);
            g.FillEllipse(g1, x2+150, y2+30, 4, 4);
            g.FillEllipse(g1, x2+250, y2+30, 4, 4);
            g.FillEllipse(g1, x2+350, y2+30, 4, 4);
            g.FillEllipse(g1, x2+450, y2+30, 4, 4);
            g.FillEllipse(g1, x2+50, y2+30, 4, 4);
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
                       
        }
        // Действия при очередном «тике» таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Новые координаты точки

            if (x1 < 300)
            {               
                x1 = x1 + 10;
                y1 = y1 + 15;
                x2 = x2 + 10;
                y2 = y2 + 15;
            }
            else
            {
                x1 = 0;
                y1 = 0;
                x2 = 0;
                y2 = 0;
            }
            Invalidate();
            // Принудительный вызов события Paint
        }
    }
}
