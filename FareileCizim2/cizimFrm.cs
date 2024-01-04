using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareileCizim2
{
    public partial class cizimFrm : Form
    {
        int x1,y1,x2,y2,t,s=0;
        Color fc;
        Pen p = new Pen(Color.Red, 3);
        Pen pForm;
        SolidBrush sb;
        private void cizimFrm_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            t = 1;
        }

        private void silgiBtn_Click(object sender, EventArgs e)
        {
            if(s== 0)
            {
                s = 1;
                silgiBtn.BackColor = Color.Blue;
            }
            else
            {
                s = 0;
                silgiBtn.BackColor = this.BackColor;
            }
        }

        private void cizimFrm_MouseUp(object sender, MouseEventArgs e)
        {
            t = 0;
            if (s == 0)
            {
                g.DrawLine(p, x1, y1, x2, y2);
            }
        }

        Graphics g;
        private void cizimFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (s == 0)
            {
                if (t == 1)
                {
                    x2 = e.X;
                    y2 = e.Y;
                    g.DrawLine(p, x1, y1, x2, y2);
                    g.DrawLine(pForm, x1, y1, x2, y2);
                }
            }
            else
            {
                x2 = e.X;
                y2 = e.Y;
                g.FillEllipse(sb, x2-5, y2-5, 10, 10);                
            }
        }

        public cizimFrm()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            fc = this.BackColor;
            pForm=new Pen(fc,3);
            sb = new SolidBrush(fc);
        }     
    }
}
