using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Member
{
    public partial class FrmCropImage : Form
    {
        //=========================================================
        // VARIABLES
        //=========================================================

        private Image selectedImage;
        private bool isSelecting = false;
        private bool isMovingImage = false;
        private Point selectionStartPoint;
        private Point mouseDownPoint;
        private Point imageStartPoint;
        private Rectangle cropRectangle;
        private Rectangle imageRectangle;
        public Image CroppedImage { get; private set; }
        //=========================================================
        // CONSTRUCTOR
        //=========================================================

        public FrmCropImage(Image image)
        {
            InitializeComponent();
            selectedImage = image;
            //=====================================================
            // FORM SETTINGS
            //=====================================================
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //=====================================================
            // OLD PICTUREBOX NOT USED
            //=====================================================

            if (picCropImage != null)
            {
                picCropImage.Visible = false;
            }

            //=====================================================
            // PANEL SETTINGS
            //=====================================================
            pnlCropArea.BackColor =Color.FromArgb(35,35,35);
            pnlCropArea.Cursor = Cursors.Cross;
            //=====================================================
            // MOUSE EVENTS
            //=====================================================
            pnlCropArea.MouseDown += pnlCropArea_MouseDown;
            pnlCropArea.MouseMove += pnlCropArea_MouseMove;
            pnlCropArea.MouseUp += pnlCropArea_MouseUp;

            //=====================================================
            // PAINT
            //=====================================================
            pnlCropArea.Paint += pnlCropArea_Paint;
            //=====================================================
            // RESIZE
            //=====================================================
            pnlCropArea.Resize += pnlCropArea_Resize;
        }

        //=========================================================
        // FORM LOAD
        //=========================================================
        private void FrmCropImage_Load(object sender,EventArgs e)
        {
            cropRectangle = Rectangle.Empty;
            FitImageInsidePanel();
            pnlCropArea.Invalidate();
        }
        //=========================================================
        // FIT IMAGE INSIDE PANEL
        //=========================================================
        private void FitImageInsidePanel()
        {
            if (selectedImage == null)
            {
                return;
            }
            else if (pnlCropArea.ClientSize.Width <= 0 || pnlCropArea.ClientSize.Height <= 0)
            {
                return;
            }

            float scaleX = (float)pnlCropArea.ClientSize.Width / selectedImage.Width;
            float scaleY = (float)pnlCropArea.ClientSize.Height /selectedImage.Height;
            float scale = Math.Min(scaleX,scaleY);
            //=========================================================
            // IMAGE WILL NOT BECOME LARGER THAN ORIGINAL
            //=========================================================
            if (scale > 1f)
            {
                scale = 1f;
            }
            //=========================================================
            // CALCULATE IMAGE SIZE
            //=========================================================
            int width = (int)(selectedImage.Width * scale);
            int height = (int)(selectedImage.Height *scale);
            //=========================================================
            // CENTER IMAGE
            //=========================================================
            int x = (pnlCropArea.ClientSize.Width - width) / 2;
            int y = (pnlCropArea.ClientSize.Height - height) / 2;
            //=========================================================
            // SET IMAGE RECTANGLE
            //=========================================================
            imageRectangle = new Rectangle(x,y,width,height);
        }
        //=========================================================
        // PAINT
        //=========================================================
        private void pnlCropArea_Paint(object sender,PaintEventArgs e)
        {
            if (selectedImage == null)
                return;

            Graphics g =
                e.Graphics;

            g.SmoothingMode =
                SmoothingMode.AntiAlias;

            g.InterpolationMode =
                InterpolationMode.HighQualityBicubic;

            g.PixelOffsetMode =
                PixelOffsetMode.HighQuality;

            g.CompositingQuality =
                CompositingQuality.HighQuality;

            //=====================================================
            // BACKGROUND
            //=====================================================
            g.Clear(Color.FromArgb(35,35,35));
            //=====================================================
            // DRAW IMAGE
            //=====================================================

            if (imageRectangle.Width > 0 && imageRectangle.Height > 0)
            {
                g.DrawImage(selectedImage,imageRectangle);
            }

            //=====================================================
            // IF CROP AREA EXISTS
            //=====================================================

            if (cropRectangle.Width > 0 && cropRectangle.Height > 0)
            {
                //=================================================
                // DARK OVERLAY
                //=================================================

                using (SolidBrush overlay = new SolidBrush(Color.FromArgb(150,0,0,0)))
                {
                    g.FillRectangle(overlay,pnlCropArea.ClientRectangle);
                }

                //=================================================
                // SHOW IMAGE INSIDE CROP AREA
                //=================================================

                GraphicsState state = g.Save();
                g.SetClip(cropRectangle);
                g.DrawImage(selectedImage,imageRectangle);
                g.Restore(state);
                //=================================================
                // CROP BORDER
                //=================================================
                using (Pen pen = new Pen(Color.White,2))
                {
                    g.DrawRectangle(pen,cropRectangle);
                }
            }
        }
        //=========================================================
        // MOUSE DOWN
        //=========================================================
        private void pnlCropArea_MouseDown(object sender,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            else if (selectedImage == null)
            {
                return;
            }

            //=========================================================
            // IF CROP ALREADY EXISTS
            // CLICK INSIDE = MOVE IMAGE
            //=========================================================

            if (cropRectangle.Width > 0 && cropRectangle.Height > 0 && cropRectangle.Contains(e.Location))
            {
                isMovingImage = true;
                mouseDownPoint = e.Location;
                imageStartPoint = imageRectangle.Location;
                pnlCropArea.Cursor = Cursors.SizeAll;
            }
            else
            {
                //=====================================================
                // START NEW CROP SELECTION
                //=====================================================
                isSelecting = true;
                selectionStartPoint = e.Location;
                cropRectangle = new Rectangle(e.X,e.Y,0,0);
                pnlCropArea.Cursor = Cursors.Cross;
                pnlCropArea.Invalidate();
            }
        }
        //=========================================================
        // MOUSE MOVE
        //=========================================================
        private void pnlCropArea_MouseMove(object sender,MouseEventArgs e)
        {
            //=====================================================
            // SELECT CROP AREA
            //=====================================================

            if (isSelecting)
            {
                int startX = selectionStartPoint.X;
                int startY = selectionStartPoint.Y;
                int currentX = e.X;
                int currentY = e.Y;

                //=================================================
                // RECTANGLE POSITION
                //=================================================

                int x =Math.Min(startX,currentX);
                int y = Math.Min(startY,currentY);
                int width = Math.Abs(currentX - startX);
                int height = Math.Abs(currentY - startY);

                //=================================================
                // KEEP SELECTION INSIDE IMAGE
                //=================================================

                Rectangle imageBounds = imageRectangle;
                if (x < imageBounds.Left)
                {
                    x = imageBounds.Left;
                }
                else if (x + width > imageBounds.Right)
                {
                    width = imageBounds.Right - x;
                }

                if (y < imageBounds.Top)
                {
                    y = imageBounds.Top;
                }
                else if (y + height > imageBounds.Bottom)
                {
                    height = imageBounds.Bottom - y;
                }

                if (width < 0)
                {
                    width = 0;
                }

                if (height < 0)
                {
                    height = 0;
                }

                cropRectangle =new Rectangle(x,y,width,height);
                pnlCropArea.Invalidate();
                return;
            }

            //=====================================================
            // MOVE IMAGE
            //=====================================================

            if (isMovingImage)
            {
                int x = imageStartPoint.X +(e.X -mouseDownPoint.X);
                int y = imageStartPoint.Y + (e.Y -mouseDownPoint.Y);
                imageRectangle.Location =new Point(x,y);
                KeepImageInsideCropRectangle();
                pnlCropArea.Invalidate();
            }
        }
        //=========================================================
        // MOUSE UP
        //=========================================================
        private void pnlCropArea_MouseUp(object sender,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            isSelecting = false;
            isMovingImage = false;
            pnlCropArea.Cursor = Cursors.Hand;
            pnlCropArea.Invalidate();
        }
        //=========================================================
        // KEEP IMAGE INSIDE CROP
        //=========================================================
        private void KeepImageInsideCropRectangle()
        {
            if (cropRectangle.Width <= 0 ||cropRectangle.Height <= 0)
                return;
            int x = imageRectangle.Left;
            int y = imageRectangle.Top;
            //=====================================================
            // IMAGE MUST COVER CROP AREA
            //=====================================================

            if (imageRectangle.Left > cropRectangle.Left)
            {
                x = cropRectangle.Left;
            }
            else if (imageRectangle.Right < cropRectangle.Right)
            {
                x = cropRectangle.Right - imageRectangle.Width;
            }

            if (imageRectangle.Top > cropRectangle.Top)
            {
                y = cropRectangle.Top;
            }
            else if (imageRectangle.Bottom < cropRectangle.Bottom)
            {
                y = cropRectangle.Bottom - imageRectangle.Height;
            }

            imageRectangle.Location = new Point(x, y);
        }
        //=========================================================
        // ROTATE
        //=========================================================
        private void btnRotate_Click(object sender,EventArgs e)
        {
            if (selectedImage == null)
                return;

            selectedImage.RotateFlip(
                RotateFlipType.Rotate90FlipNone
            );

            //=====================================================
            // RESET IMAGE POSITION
            //=====================================================

            FitImageInsidePanel();

            //=====================================================
            // IF CROP EXISTS
            // KEEP IMAGE INSIDE
            //=====================================================

            if (cropRectangle.Width > 0 &&
                cropRectangle.Height > 0)
            {
                KeepImageInsideCropRectangle();
            }

            pnlCropArea.Invalidate();
        }
        //=========================================================
        // SAVE
        //=========================================================
        private void btnSave_Click(object sender,EventArgs e)
        {
            if (cropRectangle.Width <= 0 || cropRectangle.Height <= 0)
            {
                MessageBox.Show("Please select an area first.","Crop Image",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            Bitmap result = GetCropImage();
            if (result == null)
                return;
            CroppedImage = result;
            DialogResult = DialogResult.OK;
            Close();
        }
        //=========================================================
        // GET CROPPED IMAGE
        //=========================================================
        private Bitmap GetCropImage()
        {
            if (selectedImage == null)
            {
                return null;
            }
            else if (cropRectangle.Width <= 0 || cropRectangle.Height <= 0)
            {
                return null;
            }
            int width = cropRectangle.Width;
            int height = cropRectangle.Height;
            Bitmap result = new Bitmap(width,height,PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.SmoothingMode =
                    SmoothingMode.AntiAlias;

                g.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

                g.PixelOffsetMode =
                    PixelOffsetMode.HighQuality;

                g.CompositingQuality =
                    CompositingQuality.HighQuality;

                g.Clear(Color.Transparent);

                //=================================================
                // IMAGE POSITION RELATIVE TO CROP
                //=================================================

                int imageX = imageRectangle.Left - cropRectangle.Left;
                int imageY = imageRectangle.Top -cropRectangle.Top;
                Rectangle destination = new Rectangle(imageX,imageY,imageRectangle.Width,imageRectangle.Height);

                //=================================================
                // DRAW
                //=================================================

                g.DrawImage(selectedImage,destination);
            }

            return result;
        }
        //=========================================================
        // CANCEL
        //=========================================================
        private void btnCancel_Click(object sender,EventArgs e)
        {
            CroppedImage =
                null;

            DialogResult =
                DialogResult.Cancel;

            Close();
        }
        //=========================================================
        // PANEL RESIZE
        //=========================================================
        private void pnlCropArea_Resize(object sender,EventArgs e)
        {
            if (selectedImage == null)
                return;

            if (!isSelecting &&
                !isMovingImage)
            {
                FitImageInsidePanel();

                if (cropRectangle.Width > 0 &&
                    cropRectangle.Height > 0)
                {
                    KeepImageInsideCropRectangle();
                }
            }

            pnlCropArea.Invalidate();
        }
    }
}