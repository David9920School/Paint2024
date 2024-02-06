namespace Paint2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picture = new PictureBox();
            buttonBorrador = new Button();
            buttonPincel = new Button();
            TamanioPincel = new TrackBar();
            picBoxNegro = new PictureBox();
            picBoxColors = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            colorDialog1 = new ColorDialog();
            btnCirculo = new Button();
            btnTriangulo = new Button();
            btnCuadrado = new Button();
            textBoxPorcen = new TextBox();
            btnCargarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TamanioPincel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNegro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColors).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.BackColor = Color.White;
            picture.Location = new Point(208, 38);
            picture.Name = "picture";
            picture.Size = new Size(1054, 677);
            picture.TabIndex = 0;
            picture.TabStop = false;
            picture.Click += picture_Click;
            picture.MouseDown += picture_MouseDown;
            picture.MouseMove += picture_MouseMove;
            picture.MouseUp += picture_MouseUp;
            // 
            // buttonBorrador
            // 
            buttonBorrador.Location = new Point(12, 12);
            buttonBorrador.Name = "buttonBorrador";
            buttonBorrador.Size = new Size(100, 33);
            buttonBorrador.TabIndex = 1;
            buttonBorrador.Text = "Borrador";
            buttonBorrador.UseVisualStyleBackColor = true;
            buttonBorrador.Click += buttonBorrador_Click;
            // 
            // buttonPincel
            // 
            buttonPincel.Location = new Point(12, 61);
            buttonPincel.Name = "buttonPincel";
            buttonPincel.Size = new Size(100, 34);
            buttonPincel.TabIndex = 2;
            buttonPincel.Text = "Pincel";
            buttonPincel.UseVisualStyleBackColor = true;
            buttonPincel.Click += buttonPincel_Click;
            // 
            // TamanioPincel
            // 
            TamanioPincel.Location = new Point(26, 99);
            TamanioPincel.Maximum = 30;
            TamanioPincel.Name = "TamanioPincel";
            TamanioPincel.Orientation = Orientation.Vertical;
            TamanioPincel.Size = new Size(69, 191);
            TamanioPincel.TabIndex = 3;
            TamanioPincel.Value = 3;
            TamanioPincel.ValueChanged += TamanioPincel_ValueChanged;
            // 
            // picBoxNegro
            // 
            picBoxNegro.BackColor = SystemColors.ControlText;
            picBoxNegro.Location = new Point(26, 368);
            picBoxNegro.Name = "picBoxNegro";
            picBoxNegro.Size = new Size(25, 28);
            picBoxNegro.TabIndex = 4;
            picBoxNegro.TabStop = false;
            picBoxNegro.Click += picBoxNegro_Click;
            // 
            // picBoxColors
            // 
            picBoxColors.BackColor = Color.Red;
            picBoxColors.Location = new Point(57, 368);
            picBoxColors.Name = "picBoxColors";
            picBoxColors.Size = new Size(25, 28);
            picBoxColors.TabIndex = 5;
            picBoxColors.TabStop = false;
            picBoxColors.Click += picBoxColors_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 416);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 6;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 474);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 7;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 534);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // txtR
            // 
            txtR.Location = new Point(57, 416);
            txtR.Name = "txtR";
            txtR.Size = new Size(68, 31);
            txtR.TabIndex = 9;
            txtR.Text = "0";
            // 
            // txtG
            // 
            txtG.Location = new Point(57, 474);
            txtG.Name = "txtG";
            txtG.Size = new Size(68, 31);
            txtG.TabIndex = 10;
            txtG.Text = "0";
            // 
            // txtB
            // 
            txtB.Location = new Point(57, 528);
            txtB.Name = "txtB";
            txtB.Size = new Size(68, 31);
            txtB.TabIndex = 11;
            txtB.Text = "0";
            // 
            // btnCirculo
            // 
            btnCirculo.BackColor = SystemColors.ButtonHighlight;
            btnCirculo.Image = (Image)resources.GetObject("btnCirculo.Image");
            btnCirculo.Location = new Point(124, 110);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(51, 56);
            btnCirculo.TabIndex = 12;
            btnCirculo.TextAlign = ContentAlignment.BottomCenter;
            btnCirculo.UseVisualStyleBackColor = false;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnTriangulo
            // 
            btnTriangulo.BackColor = SystemColors.ButtonHighlight;
            btnTriangulo.Image = (Image)resources.GetObject("btnTriangulo.Image");
            btnTriangulo.Location = new Point(124, 172);
            btnTriangulo.Name = "btnTriangulo";
            btnTriangulo.Size = new Size(51, 56);
            btnTriangulo.TabIndex = 13;
            btnTriangulo.UseVisualStyleBackColor = false;
            btnTriangulo.Click += btnTriangulo_Click;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = SystemColors.ButtonHighlight;
            btnCuadrado.Image = (Image)resources.GetObject("btnCuadrado.Image");
            btnCuadrado.Location = new Point(124, 234);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(51, 56);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.UseVisualStyleBackColor = false;
            btnCuadrado.Click += btnCuadrado_Click;
            // 
            // textBoxPorcen
            // 
            textBoxPorcen.Location = new Point(12, 296);
            textBoxPorcen.Name = "textBoxPorcen";
            textBoxPorcen.Size = new Size(62, 31);
            textBoxPorcen.TabIndex = 16;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(26, 612);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(120, 71);
            btnCargarImagen.TabIndex = 17;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 760);
            Controls.Add(btnCargarImagen);
            Controls.Add(textBoxPorcen);
            Controls.Add(btnCuadrado);
            Controls.Add(btnTriangulo);
            Controls.Add(btnCirculo);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picBoxColors);
            Controls.Add(picBoxNegro);
            Controls.Add(TamanioPincel);
            Controls.Add(buttonPincel);
            Controls.Add(buttonBorrador);
            Controls.Add(picture);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)TamanioPincel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxNegro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private Button buttonBorrador;
        private Button buttonPincel;
        private TrackBar TamanioPincel;
        private PictureBox picBoxNegro;
        private PictureBox picBoxColors;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private ColorDialog colorDialog1;
        private Button btnCirculo;
        private Button btnTriangulo;
        private Button btnCuadrado;
        private TextBox textBoxPorcen;
        private Button btnCargarImagen;
    }
}
