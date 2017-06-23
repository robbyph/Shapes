using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private List<APShape> shapes = new List<APShape>();
        enum Shapes { LINE, OVAL, BOX, NONE }
        private Shapes currentShape = Shapes.LINE;
        private bool trails = false;
        private bool drag = false;
        int x, y;
        Random randomGen = new Random();
        bool randColor = false;
        Color randomColor;
        int brushWidth = 4;
        Color userColor = Color.Black;
        ColorDialog cd = new ColorDialog();
        bool floodFillActive = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
             switch (e.KeyChar) //Determines what to do based on the key entered
            {
                case 'l': currentShape = Shapes.LINE; trackBar1.Value = 1; break;
                case 'o': currentShape = Shapes.OVAL; trackBar1.Value = 2; break;
                case 'r': currentShape = Shapes.BOX; trackBar1.Value = 3; break;
                case 't': if (trails == false) { trails = true; } else { trails = false; }; break;
                case 'c': if (!drag) { shapes.Clear(); Refresh(); }  break;
                case 'a': if (randColor == false) { randColor = true; } else { randColor = false; } break;
                case 'u': cd.ShowDialog(); userColor = cd.Color; randColor = false;  break;
                case 'z': if (shapes.Count >= 1 && !drag) { shapes.Remove(shapes.Last()); Refresh(); }; break;
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (floodFillActive)
            {

            }
            else
            {
                drag = true;
                Point startingPoint = e.Location;

                x = startingPoint.X; //Creates the starting point
                y = startingPoint.Y;

                if (randColor) //Generates a random color if randColor
                {
                    KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                    KnownColor randomColorName = names[randomGen.Next(names.Length)];
                    randomColor = Color.FromKnownColor(randomColorName);
                }

                if (trails == false)
                {
                    switch (currentShape) //Chooses which shape to create based on the current shape. Also chooses weather to paint it with random colors or a usercolor
                    {
                        case Shapes.LINE:
                            if (randColor) shapes.Add(new APLine(x, y, x, y, randomColor, brushWidth)); else { shapes.Add(new APLine(x, y, x, y, userColor, brushWidth)); };
                            break;
                        case Shapes.OVAL:
                            if (randColor) shapes.Add(new APOval(x, y, x, y, randomColor, brushWidth)); else { shapes.Add(new APOval(x, y, x, y, userColor, brushWidth)); };
                            break;
                        case Shapes.BOX:
                            if (randColor) shapes.Add(new APBox(x, y, x, y, randomColor, brushWidth)); else { shapes.Add(new APBox(x, y, x, y, userColor, brushWidth)); };
                            break;
                        default:
                            break;
                    }

                }
                else //If trails is true
                {
                    switch (currentShape)
                    {
                        case Shapes.LINE:
                            if (randColor) shapes.Add(new APLine(x, y, x, y, randomColor, brushWidth)); else { shapes.Add(new APLine(x, y, x, y, userColor, brushWidth)); };
                            break;
                        case Shapes.OVAL:
                            if (randColor) shapes.Add(new APOval(x, y, x, y, randomColor, brushWidth)); else { shapes.Add(new APOval(x, y, x, y, userColor, brushWidth)); };
                            break;
                        case Shapes.BOX:
                            if (randColor) shapes.Add(new APBox(x, y, x, y, randomColor, brushWidth)); else { shapes.Add(new APBox(x, y, x, y, userColor, brushWidth)); };
                            break;
                        default:
                            break;

                    }


                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            Refresh();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

            Point endingPoint = e.Location;

            int ex = endingPoint.X;
            int ey = endingPoint.Y;
            Shapes shape = currentShape;

            if (drag)
            {
                if (!trails)
                {
                    shapes.Last().setX2(ex);
                    shapes.Last().setY2(ey);
                }
                else
                {
                    shapes.Last().setX2(ex);
                    shapes.Last().setY2(ey);
                    if (randColor)
                    {
                        KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                        KnownColor randomColorName = names[randomGen.Next(names.Length)];
                        randomColor = Color.FromKnownColor(randomColorName);
                    }
                    
                    switch (shape)
                    {
                        case Shapes.LINE:
                            if (randColor) shapes.Add(new APLine(x, y, ex, ey, randomColor, brushWidth)); else { shapes.Add(new APLine(x, y, ex, ey, userColor, brushWidth)); };
                            break;
                        case Shapes.OVAL:
                            if (randColor) shapes.Add(new APOval(x, y, ex, ey, randomColor, brushWidth)); else { shapes.Add(new APOval(x, y, ex, ey, userColor, brushWidth)); };
                            break;
                        case Shapes.BOX:
                            if (randColor) shapes.Add(new APBox(x, y, ex, ey, randomColor, brushWidth)); else { shapes.Add(new APBox(x, y, ex, ey, userColor, brushWidth)); };
                            break;
                        default:
                            break;
                    }

                    
                }

                Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (randColor) { randColor = false; } else { randColor = true; }
        }

        private void picboxSize_Paint_1(object sender, PaintEventArgs e)
        {
                e.Graphics.DrawLine(new Pen(Color.Black, brushWidth), new PointF(0, picboxSize.Height / 2), new PointF(Width, picboxSize.Height / 2));
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();  
            userColor = cd.Color;
            randColor = false;
        }

        private void numupdownSize_ValueChanged(object sender, EventArgs e)
        {
            brushWidth = (int)numupdownSize.Value;
            btnChooseColor.Focus();
            picboxSize.Refresh();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 1: currentShape = Shapes.LINE;  break;
                case 2: currentShape = Shapes.OVAL; break;
                case 3: currentShape = Shapes.BOX; break;
                case 4: currentShape = Shapes.NONE; break;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (shapes.Count >= 1 && !drag) { shapes.Remove(shapes.Last()); Refresh(); };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!drag) { shapes.Clear(); Refresh(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (trails == false) { trails = true; } else { trails = false; };
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (floodFillActive == false) { floodFillActive = true; } else { floodFillActive = false; };
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            foreach (var item in shapes)
            {
                item.draw(e.Graphics);
            }

        }
    }
}
