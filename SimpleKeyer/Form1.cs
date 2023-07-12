using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace SimpleKeyer
{
    public partial class KeyerWindow : Form
    {
        public KeyerWindow()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private Bitmap srcImgBitmap;
        private Color selectedColor;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogPickImage.ShowDialog() == DialogResult.OK) 
            {
                srcImgBitmap = new Bitmap(openFileDialogPickImage.FileName);

                updatePanelImagesSize();

                pictureBoxImageIn.Image = srcImgBitmap;
                pictureBoxImageIn.Cursor = Cursors.Cross;
            }
        }

        private void pictureBoxImageIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (srcImgBitmap == null) return;

            SetSelectedColor(srcImgBitmap.GetPixel(ToImageCoord(e.X), ToImageCoord(e.Y)));
        }

        private void SetSelectedColor(Color pickedColor)
        {
            selectedColor = pickedColor;

            textBoxRedValue.Text = selectedColor.R.ToString();
            textBoxGreenValue.Text = selectedColor.G.ToString();
            textBoxBlueValue.Text = selectedColor.B.ToString();
            panelSelecdedColorView.BackColor = selectedColor;

            pictureBoxImageOut.Image = MakeTransparentImage(pictureBoxImageIn.Image, selectedColor);
            buttonSave.Enabled = true;
        }

        private Image MakeTransparentImage(Image sourceImage, Color excludedColor)
        {
            Bitmap imageExcludColor = new Bitmap(sourceImage);
            Color currentColor;
            
            int rDiff;
            int gDiff;
            int bDiff;
            int commonDiff;

            int transperent;

            progressBarCutingImage.Visible = true;

            for (int y = 0;  y < sourceImage.Height; y++)
            {
                progressBarCutingImage.Value = (int) (y * 100 / (float)sourceImage.Height);

                for (int x = 0; x < sourceImage.Width; x++)
                {
                    currentColor = imageExcludColor.GetPixel(x, y);

                    rDiff = currentColor.R - excludedColor.R;
                    gDiff = currentColor.G - excludedColor.G;
                    bDiff = currentColor.B - excludedColor.B;
                    commonDiff = Math.Abs(rDiff + gDiff + bDiff);

                    if (Math.Abs(gDiff) < 60)
                    {
                        transperent = (int)((float)(commonDiff * commonDiff / 300) + Math.Abs(gDiff));

                        imageExcludColor.SetPixel(x, y,
                            Color.FromArgb(Math.Min(transperent, 255), currentColor.R, currentColor.G, currentColor.B)
                        );
                    }
                }
            }

            progressBarCutingImage.Visible = false;

            return imageExcludColor;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogSaveImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageOut.Image.Save(saveFileDialogSaveImage.FileName);
            }
        }

        private void panelImages_Resize(object sender, EventArgs e)
        {
            updatePanelImagesSize();
        }

        int borderBetweenImages = 9;
        int imageOutPadding = 5;
        private void updatePanelImagesSize()
        {
            int imageWidth = (panelImages.Width - borderBetweenImages) / 2;

            pictureBoxImageIn.Width = imageWidth;
            pictureBoxImageOut.Width = imageWidth;
            pictureBoxImageOut.Location = new Point(imageWidth + 9, 0);

            if (srcImgBitmap != null)
            {
                panelImages.Height = (int)(((float)pictureBoxImageIn.Width / (float)srcImgBitmap.Width) * (float)srcImgBitmap.Height);
            }

            progressBarCutingImage.Width = imageWidth - imageOutPadding * 2;
            progressBarCutingImage.Location = new Point(
                pictureBoxImageOut.Location.X + imageOutPadding,
                pictureBoxImageOut.Location.Y + imageOutPadding
                );
        }

        private int ToImageCoord(int originCoord)
        {
            return (int) ((float) originCoord * ((float)srcImgBitmap.Width / (float)pictureBoxImageIn.Width));
        }
    }
}
