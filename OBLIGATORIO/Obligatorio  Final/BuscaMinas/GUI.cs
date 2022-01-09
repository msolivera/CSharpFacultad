using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class GUI : Form
    {
        private PointF[] GetPointArray(List<IPoint> points)
        {
            List<PointF> pointList = new List<PointF>();
            foreach (IPoint p in points)
            {
                pointList.Add(new PointF(p.X, p.Y));
            }
            return pointList.ToArray();
        }
        /// <summary>
        /// Método para obtener una imagen a partir de un conjunto de figuras
        /// </summary>
        /// <param name="shapes">Conjunto de figuras a dibujar</param>
        /// <param name="size">Tamaño relativo de la figura. Utilizado para determinar la escala de la figura</param>
        /// <returns></returns>
        private Bitmap GetShapeBitmap(IShape[] shapes, int size)
        {
            Bitmap bmp = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(bmp);
            foreach (IShape shape in shapes)
            { 
                if (shape.Points().Count > 0)
                { 
                    GraphicsPath p = new GraphicsPath(GetPointArray(shape.Points()), GetPointType(shape.Points()));
                    p.CloseAllFigures();
                    g.FillPath(new SolidBrush(shape.ShapeColor), p);
                }
            }
            g.Dispose();
            return bmp;
        }
        private byte[] GetPointType(List<IPoint> points)
        {
            List<byte> pointList = new List<byte>();
            foreach (IPoint p in points)
            {
                pointList.Add(1);
            }
            return pointList.ToArray();
        }
        IBoard board;
        IRules rules;
        List<Button> buttonAll = new List<Button>();
        /// <summary>
        /// Consturctor del GUI. Este form servirá para mostrar en pantalla el trablero
        /// </summary>
        /// <param name="board">Tablero con los botones para el juego</param>
        /// <param name="rules">Reglas que determinan que sucede cuando un usuario hace click sobre un botón</param>
        public GUI(IBoard board = null, IRules rules = null)
        {
            this.board = board;
            this.rules = rules;
            int size = board.ButtonSize();
            int buttonX = board.Width();
            int buttonY = board.Height();
            //Se dibuja el tablero en pantalla agregando botones segun indica el tamños en el IBoard
            for (int y = 0; y < buttonY; y++)
            { 
                for (int x = 0; x < buttonX; x++)
                {
                    Button bAux = new System.Windows.Forms.Button();
                    this.SuspendLayout();

                    bAux.Image = this.GetShapeBitmap(board.GetButton(x, y).ButtonShape, 100);
                    bAux.BackgroundImageLayout = ImageLayout.Stretch;
                    bAux.Location = new System.Drawing.Point(12+size*x, 30+12+size*y);
                    bAux.Name = "button"+y+x;
                    bAux.Size = new System.Drawing.Size(size, size);
                    bAux.TabIndex = 0;
                    bAux.Tag = new ButtonReference(x,y,board.GetButton(x,y));
                    bAux.Text = "";
                    bAux.UseVisualStyleBackColor = true;
                    bAux.FlatStyle = FlatStyle.Popup;
                    //Se indica que método llamar cuando se hace click sobre un botón
                    bAux.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Click);
                    this.Controls.Add(bAux);
                    this.buttonAll.Add(bAux);
                }
            }
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(buttonX* size + 24, buttonY * size + 24+30);
        }
        /// <summary>
        /// Clase privada utilizada para guardar la referencia de posicion de un boton en el tablero
        /// </summary>
        private class ButtonReference
        {
            public int x;
            public int y;
            public IButton b;
            public ButtonReference(int x, int y, IButton b)
            {
                this.x = x;
                this.y = y;
                this.b = b;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Método que se llama al hacer click sobre un botón del tablero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            ButtonReference r = (ButtonReference)((Control)sender).Tag;
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                rules.ButtonPressedRight(r.x, r.y, this.board, this.seconds);
            }
            else
            { 
                this.rules.ButtonPressed(r.x, r.y, this.board, this.seconds);
            }
            foreach (Button b1 in this.buttonAll)
            {
                ButtonReference refe = (ButtonReference)b1.Tag;
                b1.BackgroundImage = this.GetShapeBitmap(this.board.GetButton(refe.x, refe.y).ButtonShape, 100);
                if (this.board.GetButton(refe.x, refe.y).Pressed)
                {
                    b1.FlatStyle = FlatStyle.Popup;
                }
            }
        }
        int seconds = 0;
        /// <summary>
        /// Método que se invoca cada 1 segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.seconds++;
            string tiempo = "";
            int minutos = seconds / 60;
            int segundos = seconds % 60;
            tiempo = minutos + ":" + segundos.ToString("00");
            this.textBox1.Text = tiempo;
        }
    }
}
