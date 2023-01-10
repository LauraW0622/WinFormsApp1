namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int oldX, oldY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, oldX, oldY, e.X, e.Y); 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, oldX, oldY, e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X; 
            oldY = e.Y;
        }
    }
}