using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace cube
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Color randomizeColor()
        {
            var rand = new Random();

            var r = rand.Next(0, 256);
            Thread.Sleep(1);

            var g = rand.Next(0, 256);
            Thread.Sleep(1);

            var b = rand.Next(0, 256);
            Thread.Sleep(1);

            return Color.FromArgb(r, g, b);
        }
        protected override void OnLoad(EventArgs e)
        {
            int nCubes = 3; 
            double blockSize = 20; 
            double gapSize = 5; 

            for (int x = 0; x < nCubes; x++)
            {
                for (int y = 0; y < nCubes; y++)
                {
                    for (int z = 0; z < nCubes; z++)
                    {
                        Mesh m = Mesh.CreateBox(blockSize, blockSize, blockSize);
                        
                        double xPos = x * (blockSize + gapSize);
                        double yPos = y * (blockSize + gapSize);
                        double zPos = z * (blockSize + gapSize);
                        m.Translate(xPos, yPos, zPos);

                        Color randomColor = randomizeColor();

                        design1.Entities.Add(m, randomColor);
                    }
                }
            }

            design1.SetView(viewType.Trimetric);

            base.OnLoad(e);
        }

    }
}
