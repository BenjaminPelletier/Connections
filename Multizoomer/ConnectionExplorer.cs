using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multizoomer
{
    public partial class ConnectionExplorer : Form
    {
        private Bitmap[] _Layers = new Bitmap[] { new Bitmap("layer1.png"), new Bitmap("layer2.png"), new Bitmap("layer3.png") };

        public ConnectionExplorer()
        {
            InitializeComponent();
            imageExplorer1.PaintImage += ImageExplorer1_Paint;
        }

        private void ConnectionExplorer_Load(object sender, EventArgs e)
        {
            imageExplorer1.Image = _Layers[0];
        }

        private void ImageExplorer1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Connection Explorer: Zoom " + imageExplorer1.CurrentZoom;
            if (imageExplorer1.CurrentZoom > 1.5f)
            {
                if (imageExplorer1.CurrentZoom > 4.0f)
                {
                    imageExplorer1.ReplaceImage(_Layers[2]);
                }
                else
                {
                    imageExplorer1.ReplaceImage(_Layers[1]);
                }
            }
            else
            {
                imageExplorer1.ReplaceImage(_Layers[0]);
            }
        }
    }
}
