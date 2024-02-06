using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paint2024
{
    public partial class Form1 : Form
    {
        Graphics papel;

        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;
        int index;
        int X, Y, sX, sY, cX, cY;
        Point[] puntosTriangulo = new Point[]
{
                new Point(100, 200), // Vértice inferior
                new Point(150, 100), // Derecho
                new Point(200, 200)  // izquierdo
};
        public Form1()
        {
            InitializeComponent();
            picture.Image = new Bitmap(picture.Height, picture.Width);
            papel = picture.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;



        }

        private void buttonBorrador_Click(object sender, EventArgs e)
        {
            borrar = true;
            pintar = false;

        }

        private void buttonPincel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            x = e.X; y = e.Y;
            picture.Cursor = Cursors.Cross;
            cX = e.X;
            cY = e.Y;

        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
            sX = X - cX;
            sY = Y - cY;

            if (index == 3)
            {
                papel.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                papel.DrawRectangle(pen, cX, cY, sX, sY);

            }
            if (index == 5)
            {
                papel.DrawPolygon(pen, puntosTriangulo);
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (moviendo && borrar)
            {
                cambiarPincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            X = e.X; Y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), TamanioPincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void picBoxNegro_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void picBoxColors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void TamanioPincel_ValueChanged(object sender, EventArgs e)
        {
            int value = TamanioPincel.Value;
            double percentage = (double)value / (TamanioPincel.Maximum - TamanioPincel.Minimum) * 100;


            textBoxPorcen.Text = $"{percentage:F2}%";
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            // Utilice OpenFileDialog para poder elegir la imagen desde la pc
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(openFileDialog.FileName);
            }  
        }
    }
} 
