using System;
using System.Drawing;
using System.Windows.Forms;

namespace seventh_lab;

public partial class Form1 : Form
{
    private Graphics graph;
    private Pen pen;
    private const double deltaX = 0.1;

    public Form1()
    {
        InitializeComponent();
        this.Resize += new EventHandler(Form1_Resize);
        this.Paint += new PaintEventHandler(Form1_Paint);
        pen = new Pen(Color.Blue, 2);
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
        Invalidate();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        graph = e.Graphics;
        DrawGraph();
    }

    private void DrawGraph()
    {
        double xStart = 0.1;
        double xEnd = 0.9;

        int formWidth = this.ClientSize.Width;
        int formHeight = this.ClientSize.Height;

        float scaleX = formWidth / (float)(xEnd - xStart);
        float scaleY = formHeight / 2.0f;

        double x = xStart;
        double y = Function(x);
        float prevX = (float)((x - xStart) * scaleX);
        float prevY = formHeight / 2 - (float)(y * scaleY);

        for (x = xStart + deltaX; x <= xEnd; x += deltaX)
        {
            y = Function(x);

            float currentX = (float)((x - xStart) * scaleX);
            float currentY = formHeight / 2 - (float)(y * scaleY);

            graph.DrawLine(pen, prevX, prevY, currentX, currentY);

            prevX = currentX;
            prevY = currentY;
        }
    }

    private double Function(double x)
    {
        return Math.Acos(x) / (2 * x + 1);
    }
}