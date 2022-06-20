using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace double_pendulum
{
    public partial class Form1 : Form
    {
        struct Point_pendulum
        {
            public PointF p1, p2;
            public Point_pendulum(float x1, float y1, float x2, float y2)
            {
                p1 = new PointF(x1, y1);
                p2 = new PointF(x2, y2);
            }
        };
        const float g = 9.81f;
        float m1, m2, t, w1, w2, l1 = 10, l2 = 10, phi1 = 20, phi2 = 20, tau = 0.01f, M, eps = 0.001f;
        float[,] k;
        float ScreenW_AnT1 = 50, ScreenH_AnT1 = 50, ScreenW_AnT2 = 10, ScreenH_AnT2 = 40, devY = 2.5f / (float)(2 * Math.PI);
        int pause, temp;        
        List<Point_pendulum> draw_anim_values, draw_graph_values;
        public Form1()
        {
            InitializeComponent();            
        }
        private float w1Prime(float t, float phi1, float phi2, float w1, float w2)
        {
            float cc = (float)Math.Cos(phi1 - phi2), cs = (float)Math.Sin(phi1 - phi2);
            float c1 = (float)Math.Sin(phi1), c2 = (float)Math.Sin(phi2);
            float tl1 = l1 / 100, tl2 = l2 / 100;            
            return -m2 / (m1 + m2 * (float)Math.Pow(cs, 2)) * (cs * (w1 * w1 * cc + tl2 / tl1 * w2 * w2) - g / tl1 * (c2 * cc - M / m2 * c1));
        } 
        private float w2Prime(float t, float phi1, float phi2, float w1, float w2)
        {
            float cc = (float)Math.Cos(phi1 - phi2), cs = (float)Math.Sin(phi1 - phi2);
            float c1 = (float)Math.Sin(phi1), c2 = (float)Math.Sin(phi2);
            float tl1 = l1 / 100, tl2 = l2 / 100;            
            return M / (m1 + m2 * (float)Math.Pow(cs, 2)) * (cs * (m2 / M * cc * w2 * w2 + tl1 / tl2 * w1 * w1) + g / tl2 * (c1 * cc - c2));           
        }
        private float phi1Prime(float t, float phi1, float phi2, float w1, float w2)
        {
            return w1;
        }
        private float phi2Prime(float t, float phi1, float phi2, float w1, float w2)
        {
            return w2;
        }
        private void rkm43()
        {
            k[0, 0] = phi1Prime(t, phi1, phi2, w1, w2);
            k[1, 0] = phi2Prime(t, phi1, phi2, w1, w2);
            k[2, 0] = w1Prime(t, phi1, phi2, w1, w2);
            k[3, 0] = w2Prime(t, phi1, phi2, w1, w2);

            k[0, 1] = phi1Prime(t + tau / 2, phi1 + k[0, 0] * tau / 2, phi2 + k[1, 0] * tau / 2, w1 + k[2, 0] * tau / 2, w2 + k[3, 0] * tau / 2);
            k[1, 1] = phi2Prime(t + tau / 2, phi1 + k[0, 0] * tau / 2, phi2 + k[1, 0] * tau / 2, w1 + k[2, 0] * tau / 2, w2 + k[3, 0] * tau / 2);
            k[2, 1] = w1Prime(t + tau / 2, phi1 + k[0, 0] * tau / 2, phi2 + k[1, 0] * tau / 2, w1 + k[2, 0] * tau / 2, w2 + k[3, 0] * tau / 2);
            k[3, 1] = w2Prime(t + tau / 2, phi1 + k[0, 0] * tau / 2, phi2 + k[1, 0] * tau / 2, w1 + k[2, 0] * tau / 2, w2 + k[3, 0] * tau / 2);

            k[0, 2] = phi1Prime(t + tau / 2, phi1 + k[0, 1] * tau / 2, phi2 + k[1, 1] * tau / 2, w1 + k[2, 1] * tau / 2, w2 + k[3, 1] * tau / 2);
            k[1, 2] = phi2Prime(t + tau / 2, phi1 + k[0, 1] * tau / 2, phi2 + k[1, 1] * tau / 2, w1 + k[2, 1] * tau / 2, w2 + k[3, 1] * tau / 2);
            k[2, 2] = w1Prime(t + tau / 2, phi1 + k[0, 1] * tau / 2, phi2 + k[1, 1] * tau / 2, w1 + k[2, 1] * tau / 2, w2 + k[3, 1] * tau / 2);
            k[3, 2] = w2Prime(t + tau / 2, phi1 + k[0, 1] * tau / 2, phi2 + k[1, 1] * tau / 2, w1 + k[2, 1] * tau / 2, w2 + k[3, 1] * tau / 2);

            k[0, 3] = phi1Prime(t + tau, phi1 + k[0, 2] * tau, phi2 + k[1, 2] * tau, w1 + k[2, 2] * tau, w2 + k[3, 2] * tau);
            k[1, 3] = phi2Prime(t + tau, phi1 + k[0, 2] * tau, phi2 + k[1, 2] * tau, w1 + k[2, 2] * tau, w2 + k[3, 2] * tau);
            k[2, 3] = w1Prime(t + tau, phi1 + k[0, 2] * tau, phi2 + k[1, 2] * tau, w1 + k[2, 2] * tau, w2 + k[3, 2] * tau);
            k[3, 3] = w2Prime(t + tau, phi1 + k[0, 2] * tau, phi2 + k[1, 2] * tau, w1 + k[2, 2] * tau, w2 + k[3, 2] * tau);

            t += tau;
            phi1 += tau / 6 * (k[0, 0] + 2 * k[0, 1] + 2 * k[0, 2] + k[0, 3]);
            phi2 += tau / 6 * (k[1, 0] + 2 * k[1, 1] + 2 * k[1, 2] + k[1, 3]);
            w1 += tau / 6 * (k[2, 0] + 2 * k[2, 1] + 2 * k[2, 2] + k[2, 3]);
            w2 += tau / 6 * (k[3, 0] + 2 * k[3, 1] + 2 * k[3, 2] + k[3, 3]);
        }
        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();            
            draw_anim_values.Clear();
            draw_graph_values.Clear();
            t = 0;
            label_Time.Text = (0).ToString();
            label_phi1.Text = (0).ToString();
            label_phi2.Text = (0).ToString();
            label_w1.Text = (0).ToString();
            label_w2.Text = (0).ToString();
            button_pause.Text = "Пауза";
            pause = 0;
            button_watch.Enabled = true;
            button_pause.Enabled = false;
            AnT1_Load();
            AnT2_Load();
        }
        private void button_pause_Click(object sender, EventArgs e)
        {
            if (pause == 0)
            {
                button_pause.Text = "Продолжить";
                timer.Stop();
                pause = 1;
            }
            else if (pause == 1)
            {
                button_pause.Text = "Пауза";
                timer.Start();
                pause = 0;
            }
        }
        private void AnT1_Load()
        {
            AnT1.InitializeContexts();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT1.Width, AnT1.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            l1 = float.Parse(tB_length1.Text);
            l2 = float.Parse(tB_length2.Text);
            phi1 = ToRad(float.Parse(tB_phi1.Text));
            phi2 = ToRad(float.Parse(tB_phi2.Text));
            if (2 * Math.PI - phi1 <= eps)
            {
                phi1 -= 2 * (float)Math.PI;
                tB_phi1.Text = phi1.ToString();
            }
            if (phi1 + 2 * Math.PI <= eps) 
            {
                phi1 += 2 * (float)Math.PI;
                tB_phi1.Text = phi1.ToString();
            } 
            if (2 * Math.PI - phi2 <= eps) 
            {
                phi2 -= 2 * (float)Math.PI;
                tB_phi2.Text = phi2.ToString();
            } 
            if (phi2 + 2 * Math.PI <= eps) 
            {
                phi2 += 2 * (float)Math.PI;
                tB_phi2.Text = phi2.ToString();
            } 
            ScreenW_AnT1 = 2 * (l1 + l2 + 1);
            ScreenH_AnT1 = 2 * (l1 + l2 + 1);
            Glu.gluOrtho2D(0, ScreenW_AnT1, 0, ScreenH_AnT1);                     
            Gl.glMatrixMode(Gl.GL_MODELVIEW);           
            Draw_Figure();
        }
        private void AnT2_Load()
        {
            AnT2.InitializeContexts();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT2.Width, AnT2.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            ScreenW_AnT2 = 12;           
            ScreenH_AnT2 = 6;
            Glu.gluOrtho2D(-1, ScreenW_AnT2, - ScreenH_AnT2 / 2, ScreenH_AnT2 / 2);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glClearColor(255, 255, 255, 1);            
            Draw_Graph();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            button_pause.Enabled = false;
            draw_anim_values = new List<Point_pendulum>();
            draw_graph_values = new List<Point_pendulum>();
            k = new float[4, 4];
            AnT1_Load();
            AnT2_Load();
        }
        private void Draw_axis(float t0) 
        {
            Gl.glColor3d(255, 255, 255);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2d(t0 - 1, -ScreenH_AnT2 / 2);
            Gl.glVertex2d(t0 - 1, ScreenH_AnT2 / 2);
            Gl.glVertex2d(t0, ScreenH_AnT2 / 2);
            Gl.glVertex2d(t0, -ScreenH_AnT2 / 2);
            Gl.glEnd();
            Gl.glColor3d(0, 0, 0);
            Gl.glBegin(Gl.GL_LINES);
            // ОСИ
            Gl.glVertex2d(t0, -ScreenH_AnT2 / 2);
            Gl.glVertex2d(t0, ScreenH_AnT2 / 2 - 0.125f);
            Gl.glVertex2d(t0, 0);
            Gl.glVertex2d(t0 + ScreenW_AnT2, 0);
            // СТРЕЛКИ
            Gl.glVertex2d(t0 + ScreenW_AnT2, 0);
            Gl.glVertex2d(t0 + ScreenW_AnT2 - 0.25, 0.125);
            Gl.glVertex2d(t0 + ScreenW_AnT2, 0);
            Gl.glVertex2d(t0 + ScreenW_AnT2 - 0.25, -0.125);

            Gl.glVertex2d(t0, ScreenH_AnT2 / 2 - 0.125f);
            Gl.glVertex2d(t0 - 0.125, ScreenH_AnT2 / 2 - 0.375);
            Gl.glVertex2d(t0, ScreenH_AnT2 / 2 - 0.125f);
            Gl.glVertex2d(t0 + 0.125, ScreenH_AnT2 / 2 - 0.375);
            Gl.glEnd();
            // Шкала по phi1,phi2
            temp = 0;
            for (float i = 0; i <= ScreenH_AnT2 / 2 - 0.5f; i += 0.625f)
            {
                Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2d(t0 - 0.1, i);
                Gl.glVertex2d(t0 + 0.1, i);
                Gl.glEnd();
                if (i > 0)
                    PrintText2D(t0 - 0.5f - 0.25f * (count_digit(90 * temp) - 2), i - 0.1f, (90 * temp).ToString());   
                else
                    PrintText2D(t0 - 0.5f - 0.25f * (count_digit(90 * temp) - 0.5f), i - 0.1f, (90 * temp).ToString());
                ++temp;
            }
            temp = 0;
            for (float i = 0.5f - ScreenH_AnT2 / 2; i < 0; i += 0.625f)
            {
                Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2d(t0 - 0.1, i);
                Gl.glVertex2d(t0 + 0.1, i);
                Gl.glEnd();
                PrintText2D(t0 - 0.5f - 0.25f * (count_digit(360 - 90 * temp) - 1), i - 0.1f, (-360 + 90 * temp).ToString());
                ++temp;
            }
            PrintText2D(t0 + 0.25f, ScreenH_AnT2 / 2 - 0.25f, "phi1,phi2");
            PrintText2D(t0 + ScreenW_AnT2 - 0.25f, 0.25f, "t");
        }

        private void Draw_Graph()
        {
            AnT2.MakeCurrent();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glColor3f(0, 0, 0);
            // ТОЧКИ
            Gl.glBegin(Gl.GL_POINTS);
            for (double ax = 0; ax < ScreenW_AnT2; ax += 0.25)
                for (double bx = 0.5f - ScreenH_AnT2 / 2; bx <= ScreenH_AnT2 / 2 - 0.5f; bx += 0.3125f)
                    if(bx != 0)Gl.glVertex2d(ax, bx);
            Gl.glEnd();            
            if (ScreenW_AnT2 - t - 2 < eps) 
                Gl.glTranslated(ScreenW_AnT2 - t - 2, 0, 0);
            draw_graph_values.Add(new Point_pendulum(t, phi1, t, phi2));

            Gl.glBegin(Gl.GL_LINE_STRIP);
            draw_graph_values.ForEach(delegate (Point_pendulum pend)
            {
                Gl.glColor3f(255, 0, 0);
                Gl.glVertex2d(pend.p1.X, devY * pend.p1.Y);
            });
            Gl.glEnd();
            Gl.glBegin(Gl.GL_LINE_STRIP);
            draw_graph_values.ForEach(delegate (Point_pendulum pend)
            {
                Gl.glColor3f(0, 0, 255);
                Gl.glVertex2d(pend.p2.X, devY * pend.p2.Y);
            });
            Gl.glEnd();
            // Точки линий функций
            Gl.glPointSize(5);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(255, 0, 0);
            Gl.glVertex2d(t, devY * phi1);
            Gl.glColor3f(0, 0, 255);
            Gl.glVertex2d(t, devY * phi2);
            Gl.glEnd();
           
            Gl.glDisable(Gl.GL_POINT_SMOOTH);
            Gl.glPointSize(1);
            Gl.glColor3f(0, 0, 0);
            
            if (ScreenW_AnT2 - t - 2 < eps) 
            {
                int cond = 0;
                // Шкала по оси t
                if (t < 2 * (ScreenW_AnT2 - 2))
                    cond = 1;
                else cond = (int)ScreenW_AnT2;
                for (int i = cond; i < t + 2; ++i)
                {
                    Gl.glBegin(Gl.GL_LINES);
                    Gl.glVertex2d(i, - 0.1);
                    Gl.glVertex2d(i, 0.1);
                    Gl.glEnd();
                    PrintText2D(i - 0.05f - 0.07f * (count_digit(i) - 1),- 0.4f, i.ToString());
                }
                Draw_axis(t - ScreenW_AnT2 + 2);
            }
            else
            {
                // Шкала по оси t            
                for (int i = 1; i < ScreenW_AnT2; ++i)
                {
                    Gl.glBegin(Gl.GL_LINES);
                    Gl.glVertex2d(i, -0.1);
                    Gl.glVertex2d(i, 0.1);
                    Gl.glEnd();
                    PrintText2D(i - 0.05f - 0.07f * (count_digit(i) - 1), -0.4f, i.ToString());
                }
                Draw_axis(0);
            }                
            draw_graph_values.RemoveAll(remove_time);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT2.Invalidate();
        }
        private int count_digit(int number)
        {
            int digit = 0;
            while(number != 0)
            {
                number /= 10;
                ++digit;
            }
            return digit;
        }
        private bool remove_time(Point_pendulum pend)
        {
            if (pend.p1.X + ScreenW_AnT2 - 2 < t)
                return true;
            else return false;
        }
        private void PrintText2D(float x, float y, string text)
        {
            Gl.glRasterPos2f(x, y);

            foreach (char char_for_draw in text)
            {
                Gl.glScaled(0.5, 0.5, 0);
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_HELVETICA_10, char_for_draw);
                Gl.glScaled(2, 2, 0);
            }
        }
        private void Draw_Figure()
        {
            AnT1.MakeCurrent();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();

            Gl.glColor3f(0, 0, 0);
            Gl.glTranslated(ScreenW_AnT1 / 2, ScreenH_AnT1 / 2, 0);

            float x0 = 0, y0 = 0;
            float x1 = l1 * (float)Math.Sin(phi1), y1 = -l1 * (float)Math.Cos(phi1);
            float x2 = l1 * (float)Math.Sin(phi1), y2 = -l1 * (float)Math.Cos(phi1);
            float x3 = l2 * (float)Math.Sin(phi2), y3 = -l2 * (float)Math.Cos(phi2);

            Gl.glPointSize(5);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2d(0, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(x0, y0);
            Gl.glVertex2d(x1, y1);

            Gl.glVertex2d(x2, y2);
            Gl.glVertex2d(x2 + x3, y2 + y3);
            Gl.glEnd();

            Gl.glPointSize(10);
            Gl.glBegin(Gl.GL_POINTS);            
            Gl.glColor3f(255, 0, 0);
            Gl.glVertex2d(x1 , y1);
            Gl.glColor3f(0, 0, 255);
            Gl.glVertex2d(x2 + x3, y2 + y3);
            Gl.glEnd();
            Gl.glPointSize(1);
            Gl.glColor3f(0, 0, 0);

            draw_anim_values.Add(new Point_pendulum(x1, y1, x2 + x3, y2 + y3));
            Gl.glBegin(Gl.GL_LINE_STRIP);
            draw_anim_values.ForEach(delegate(Point_pendulum pend){
                Gl.glColor3f(255, 0, 0);
                Gl.glVertex2d(pend.p1.X, pend.p1.Y);
            });
            Gl.glEnd();
            Gl.glBegin(Gl.GL_LINE_STRIP);
            draw_anim_values.ForEach(delegate (Point_pendulum pend) {
                Gl.glColor3f(0, 0, 255);
                Gl.glVertex2d(pend.p2.X, pend.p2.Y);
            });
            Gl.glEnd();
           
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT1.Invalidate();
        }
        private float ToRad(float phi)
        {
            phi = phi * (float)(Math.PI / 180);
            return phi;
        }
        private float ToGr(float phi)
        {
            phi = phi * (float)(180 / Math.PI);
            return phi;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            rkm43();
            Draw_Graph();
            Draw_Figure();
            if  (2 * Math.PI - phi1 <= eps) phi1 -= 2 * (float)Math.PI;
            if (phi1 + 2 * Math.PI <= eps) phi1 += 2 * (float)Math.PI;
            if (2 * Math.PI - phi2 <= eps) phi2 -= 2 * (float)Math.PI;
            if (phi2 + 2 * Math.PI <= eps) phi2 += 2 * (float)Math.PI;
            label_Time.Text = Math.Round(t, 3).ToString();
            label_phi1.Text = Math.Round(ToGr(phi1)).ToString();
            label_phi2.Text = Math.Round(ToGr(phi2)).ToString();
            label_w1.Text = Math.Round(w1, 2).ToString();
            label_w2.Text = Math.Round(w2, 2).ToString();
        }
        private void button_apply_Click(object sender, EventArgs e)
        {            
            pause = 0;
            draw_anim_values.Clear();
            draw_graph_values.Clear();           
            button_pause.Text = "Пауза";
            button_pause.Enabled = true;

            w1 = ToRad(float.Parse(tB_w1.Text));
            w2 = ToRad(float.Parse(tB_w2.Text));
            m1 = float.Parse(tB_weight1.Text);
            m2 = float.Parse(tB_weight2.Text);
            tau = float.Parse(tB_tau.Text);
            M = m1 + m2;

            t = 0;
            button_watch.Enabled = false;            

            AnT1_Load();
            AnT2_Load();

            timer.Start();
        }
        private void button_watch_Click(object sender, EventArgs e)
        {
            draw_anim_values.Clear();
            AnT1_Load();
            AnT2_Load();
        }
    }
}