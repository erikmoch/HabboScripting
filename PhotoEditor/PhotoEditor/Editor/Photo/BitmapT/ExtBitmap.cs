using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace PhotoEditor.Editor.BitmapTools
{
    public static class ExtBitmap
    {
        private const int bytesPerPixel = 4;

        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bitmap = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage((Image)bitmap))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bitmap.Width, bitmap.Height), new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }
            return bitmap;
        }

        public static Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colorMatrix)
        {
            Bitmap argbCopy = ExtBitmap.GetArgbCopy(sourceImage);
            Bitmap bitmap = new Bitmap(argbCopy.Width, argbCopy.Height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage((Image)bitmap))
            {
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorMatrix(colorMatrix);
                graphics.DrawImage((Image)argbCopy, new Rectangle(0, 0, argbCopy.Width, argbCopy.Height), 0, 0, argbCopy.Width, argbCopy.Height, GraphicsUnit.Pixel, imageAttr);
            }
            argbCopy.Dispose();
            return bitmap;
        }

        public static Bitmap CropImage(Bitmap source, Rectangle section)
        {
            Bitmap bitmap = new Bitmap(section.Width, section.Height);
            Graphics.FromImage((Image)bitmap).DrawImage((Image)source, 0, 0, section, GraphicsUnit.Pixel);
            return bitmap;
        }

        public static Bitmap CopyWithTransparency(this Image sourceImage, byte alphaComponent = 100)
        {
            Bitmap argbCopy = ExtBitmap.GetArgbCopy(sourceImage);
            BitmapData bitmapdata = argbCopy.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr scan0 = bitmapdata.Scan0;
            byte[] numArray = new byte[bitmapdata.Stride * argbCopy.Height];
            Marshal.Copy(scan0, numArray, 0, numArray.Length);
            int index = 3;
            while (index < numArray.Length)
            {
                numArray[index] = alphaComponent;
                index += 4;
            }
            Marshal.Copy(numArray, 0, scan0, numArray.Length);
            argbCopy.UnlockBits(bitmapdata);
            return argbCopy;
        }

        public static Image TransparentByColorDarkness(Image _image, double _tolerance = 0.0)
        {
            Bitmap bitmap = (Bitmap)_image.Clone();
            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    float brightness = pixel.GetBrightness();
                    if ((double)brightness + _tolerance <= 1.0 && (double)brightness + _tolerance >= 0.0)
                        brightness += (float)_tolerance;
                    Color color = Color.FromArgb((int)((double)byte.MaxValue * (double)brightness), pixel);
                    bitmap.SetPixel(x, y, color);
                }
            }
            return (Image)bitmap.Clone();
        }

        public static Bitmap InsertEmptyPixels(Bitmap bmap, int resizex, int resizey)
        {
            Bitmap bitmap = new Bitmap(bmap.Width + bmap.Width * resizex, bmap.Height + bmap.Height * resizey);
            for (int x = 0; x < bmap.Width; ++x)
            {
                for (int y = 0; y < bmap.Height; ++y)
                {
                    Color pixel = bmap.GetPixel(x, y);
                    bitmap.SetPixel(x * (resizex + 1), y * (resizey + 1), pixel);
                }
            }
            return bitmap;
        }

        public static unsafe void ApplySepia(ref Bitmap bmp, int depth)
        {
            BitmapData bitmapdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte* pointer = (byte*)bitmapdata.Scan0.ToPointer();
            int num1 = (int)pointer + bitmapdata.Stride * bitmapdata.Height;
            while ((int)pointer != num1)
            {
                *pointer = (byte)(0.299 * (double)pointer[2] + (double)pointer[1] * 0.587 + (double)*pointer * 0.114);
                int num2 = (int)pointer[2] + depth * 2;
                if (num2 > (int)byte.MaxValue)
                    num2 = (int)byte.MaxValue;
                pointer[2] = (byte)num2;
                int num3 = (int)pointer[1] + depth;
                if (num3 > (int)byte.MaxValue)
                    num3 = (int)byte.MaxValue;
                pointer[1] = (byte)num3;
                pointer += 3;
            }
            bmp.UnlockBits(bitmapdata);
        }

        public static void SepiaBitmap(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bitmapdata = bmp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            IntPtr scan0 = bitmapdata.Scan0;
            int length = bitmapdata.Width * bmp.Height * 4;
            byte[] numArray = new byte[length];
            Marshal.Copy(scan0, numArray, 0, length);
            int index = 0;
            while (index < numArray.Length)
            {
                int num1 = (int)numArray[index + 2];
                int num2 = (int)numArray[index + 1];
                int num3 = (int)numArray[index];
                numArray[index + 2] = (byte)Math.Min(0.393 * (double)num1 + 0.769 * (double)num2 + 0.189 * (double)num3, (double)byte.MaxValue);
                numArray[index + 1] = (byte)Math.Min(0.349 * (double)num1 + 0.686 * (double)num2 + 0.168 * (double)num3, (double)byte.MaxValue);
                numArray[index] = (byte)Math.Min(0.272 * (double)num1 + 0.534 * (double)num2 + 0.131 * (double)num3, (double)byte.MaxValue);
                index += 4;
            }
            Marshal.Copy(numArray, 0, scan0, length);
            bmp.UnlockBits(bitmapdata);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap bitmap = new Bitmap(width, height);
            bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (Graphics graphics = Graphics.FromImage((Image)bitmap))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (ImageAttributes imageAttr = new ImageAttributes())
                {
                    imageAttr.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttr);
                }
            }
            return bitmap;
        }

        public static bool IsPointInPolygon(Point[] poly, Point pnt)
        {
            int length = poly.Length;
            bool flag = false;
            int index1 = 0;
            int index2 = length - 1;
            for (; index1 < length; index2 = index1++)
            {
                if (poly[index1].Y > pnt.Y != poly[index2].Y > pnt.Y && pnt.X < (poly[index2].X - poly[index1].X) * (pnt.Y - poly[index1].Y) / (poly[index2].Y - poly[index1].Y) + poly[index1].X)
                    flag = !flag;
            }
            return flag;
        }

        private static Bitmap changePolyColor(Point[] poly, Bitmap inputBitmap, Color replaceColor)
        {
            int y = 0;
            while (true)
            {
                int num1 = y;
                Size size = inputBitmap.Size;
                int height = size.Height;
                if (num1 < height)
                {
                    int x = 0;
                    while (true)
                    {
                        int num2 = x;
                        size = inputBitmap.Size;
                        int width = size.Width;
                        if (num2 < width)
                        {
                            if (ExtBitmap.IsPointInPolygon(poly, new Point(x, y)))
                                inputBitmap.SetPixel(x, y, replaceColor);
                            ++x;
                        }
                        else
                            break;
                    }
                    ++y;
                }
                else
                    break;
            }
            return inputBitmap;
        }

        public static Image ReplaceColor(Image _image, Color _colorOld, Color _colorNew, int _tolerance)
        {
            Bitmap bitmap = (Bitmap)_image.Clone();
            int num1 = Math.Max((int)_colorOld.R - _tolerance, 0);
            int num2 = Math.Min((int)_colorOld.R + _tolerance, (int)byte.MaxValue);
            int num3 = Math.Max((int)_colorOld.G - _tolerance, 0);
            int num4 = Math.Min((int)_colorOld.G + _tolerance, (int)byte.MaxValue);
            int num5 = Math.Max((int)_colorOld.B - _tolerance, 0);
            int num6 = Math.Min((int)_colorOld.B + _tolerance, (int)byte.MaxValue);
            for (int x = 0; x < bitmap.Width; ++x)
            {
                for (int y = 0; y < bitmap.Height; ++y)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if ((int)pixel.R >= num1 && (int)pixel.R <= num2 && ((int)pixel.G >= num3 && (int)pixel.G <= num4) && ((int)pixel.B >= num5 && (int)pixel.B <= num6))
                    {
                        if (_colorNew == Color.Transparent)
                            bitmap.SetPixel(x, y, Color.FromArgb(0, (int)_colorNew.R, (int)_colorNew.G, (int)_colorNew.B));
                        else
                            bitmap.SetPixel(x, y, Color.FromArgb((int)pixel.A, (int)_colorNew.R, (int)_colorNew.G, (int)_colorNew.B));
                    }
                }
            }
            return (Image)bitmap.Clone();
        }

        public static Bitmap DrawWithTransparency(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
            {
        new float[5]{ 1f, 0.0f, 0.0f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 1f, 0.0f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 1f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 0.3f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 0.0f, 1f }
            });
            return ExtBitmap.ApplyColorMatrix(sourceImage, colorMatrix);
        }

        public static Image ChangeImageOpacity(Image originalImage, double opacity)
        {
            if ((originalImage.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed)
                return originalImage;
            Bitmap bitmap = (Bitmap)originalImage.Clone();
            PixelFormat format = PixelFormat.Format32bppArgb;
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.ReadWrite, format);
            IntPtr scan0 = bitmapdata.Scan0;
            int length = bitmap.Width * bitmap.Height * 4;
            byte[] numArray = new byte[length];
            Marshal.Copy(scan0, numArray, 0, length);
            int num1 = 0;
            while (num1 < numArray.Length)
            {
                if (numArray[num1 + 4 - 1] != (byte)0)
                {
                    int num2 = 0 + 1 + 1 + 1;
                    numArray[num1 + num2] = (byte)((double)numArray[num1 + num2] * opacity);
                }
                num1 += 4;
            }
            Marshal.Copy(numArray, 0, scan0, length);
            bitmap.UnlockBits(bitmapdata);
            return (Image)bitmap;
        }

        public static Bitmap CopyAsNegative(this Image sourceImage)
        {
            Bitmap argbCopy = ExtBitmap.GetArgbCopy(sourceImage);
            BitmapData bitmapdata = argbCopy.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr scan0 = bitmapdata.Scan0;
            byte[] numArray = new byte[bitmapdata.Stride * argbCopy.Height];
            Marshal.Copy(scan0, numArray, 0, numArray.Length);
            int startIndex = 0;
            while (startIndex < numArray.Length)
            {
                byte[] bytes = BitConverter.GetBytes(~BitConverter.ToInt32(numArray, startIndex));
                numArray[startIndex] = bytes[0];
                numArray[startIndex + 1] = bytes[1];
                numArray[startIndex + 2] = bytes[2];
                startIndex += 4;
            }
            Marshal.Copy(numArray, 0, scan0, numArray.Length);
            argbCopy.UnlockBits(bitmapdata);
            return argbCopy;
        }

        public static Bitmap DrawAsNegative(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
            {
        new float[5]{ -1f, 0.0f, 0.0f, 0.0f, 0.0f },
        new float[5]{ 0.0f, -1f, 0.0f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 0.0f, -1f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 1f, 0.0f },
        new float[5]{ 1f, 1f, 1f, 1f, 1f }
            });
            return ExtBitmap.ApplyColorMatrix(sourceImage, colorMatrix);
        }

        public static Bitmap CopyAsGrayscale(this Image sourceImage)
        {
            Bitmap argbCopy = ExtBitmap.GetArgbCopy(sourceImage);
            BitmapData bitmapdata = argbCopy.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr scan0 = bitmapdata.Scan0;
            byte[] numArray = new byte[bitmapdata.Stride * argbCopy.Height];
            Marshal.Copy(scan0, numArray, 0, numArray.Length);
            int index = 0;
            while (index < numArray.Length)
            {
                float num = (float)numArray[index] * 0.11f + (float)numArray[index + 1] * 0.59f + (float)numArray[index + 2] * 0.3f;
                numArray[index] = (byte)num;
                numArray[index + 1] = numArray[index];
                numArray[index + 2] = numArray[index];
                numArray[index + 3] = byte.MaxValue;
                index += 4;
            }
            Marshal.Copy(numArray, 0, scan0, numArray.Length);
            argbCopy.UnlockBits(bitmapdata);
            return argbCopy;
        }

        public static Bitmap DrawAsGrayscale(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
            {
        new float[5]{ 0.3f, 0.3f, 0.3f, 0.0f, 0.0f },
        new float[5]{ 0.59f, 0.59f, 0.59f, 0.0f, 0.0f },
        new float[5]{ 0.11f, 0.11f, 0.11f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 1f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 0.0f, 1f }
            });
            return ExtBitmap.ApplyColorMatrix(sourceImage, colorMatrix);
        }

        public static Bitmap CopyAsSepiaTone(this Image sourceImage)
        {
            Bitmap argbCopy = ExtBitmap.GetArgbCopy(sourceImage);
            BitmapData bitmapdata = argbCopy.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr scan0 = bitmapdata.Scan0;
            byte[] numArray = new byte[bitmapdata.Stride * argbCopy.Height];
            Marshal.Copy(scan0, numArray, 0, numArray.Length);
            byte maxValue = byte.MaxValue;
            int index = 0;
            while (index < numArray.Length)
            {
                float num1 = (float)((double)numArray[index] * 0.188999995589256 + (double)numArray[index + 1] * 0.768999993801117 + (double)numArray[index + 2] * 0.39300000667572);
                float num2 = (float)((double)numArray[index] * 0.167999997735024 + (double)numArray[index + 1] * 0.685999989509583 + (double)numArray[index + 2] * 0.349000006914139);
                float num3 = (float)((double)numArray[index] * 0.130999997258186 + (double)numArray[index + 1] * 0.533999979496002 + (double)numArray[index + 2] * 0.272000014781952);
                numArray[index + 2] = (double)num1 > (double)maxValue ? maxValue : (byte)num1;
                numArray[index + 1] = (double)num2 > (double)maxValue ? maxValue : (byte)num2;
                numArray[index] = (double)num3 > (double)maxValue ? maxValue : (byte)num3;
                index += 4;
            }
            Marshal.Copy(numArray, 0, scan0, numArray.Length);
            argbCopy.UnlockBits(bitmapdata);
            return argbCopy;
        }

        public static Bitmap DrawAsSepiaTone(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
            {
        new float[5]{ 0.393f, 0.349f, 0.272f, 0.0f, 0.0f },
        new float[5]{ 0.769f, 0.686f, 0.534f, 0.0f, 0.0f },
        new float[5]{ 0.189f, 0.168f, 0.131f, 0.0f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 1f, 0.0f },
        new float[5]{ 0.0f, 0.0f, 0.0f, 0.0f, 1f }
            });
            return ExtBitmap.ApplyColorMatrix(sourceImage, colorMatrix);
        }

        public static void ChangeColour(this Bitmap bmp, byte inColourR, byte inColourG, byte inColourB, byte outColourR, byte outColourG, byte outColourB)
        {
            PixelFormat format = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bitmapdata = bmp.LockBits(rect, ImageLockMode.ReadWrite, format);
            IntPtr scan0 = bitmapdata.Scan0;
            int length = bitmapdata.Stride * bmp.Height;
            byte[] numArray = new byte[length];
            Marshal.Copy(scan0, numArray, 0, length);
            int index = 0;
            while (index < numArray.Length)
            {
                if ((int)numArray[index] == (int)inColourR && (int)numArray[index + 1] == (int)inColourG && (int)numArray[index + 2] == (int)inColourB)
                {
                    numArray[index] = outColourR;
                    numArray[index + 1] = outColourG;
                    numArray[index + 2] = outColourB;
                }
                index += 3;
            }
            Marshal.Copy(numArray, 0, scan0, length);
            bmp.UnlockBits(bitmapdata);
        }

        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float num = (float)((sourceBitmap.Width > sourceBitmap.Height ? sourceBitmap.Width : sourceBitmap.Height) / canvasWidthLenght);
            Bitmap bitmap = sourceBitmap.Width > sourceBitmap.Height ? new Bitmap(canvasWidthLenght, (int)((double)sourceBitmap.Height / (double)num)) : new Bitmap((int)((double)sourceBitmap.Width / (double)num), canvasWidthLenght);
            using (Graphics graphics = Graphics.FromImage((Image)bitmap))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage((Image)sourceBitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }
            return bitmap;
        }

        public static Bitmap Contrast(this Bitmap sourceBitmap, int threshold)
        {
            BitmapData bitmapdata1 = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] numArray = new byte[bitmapdata1.Stride * bitmapdata1.Height];
            Marshal.Copy(bitmapdata1.Scan0, numArray, 0, numArray.Length);
            sourceBitmap.UnlockBits(bitmapdata1);
            double num1 = Math.Pow((100.0 + (double)threshold) / 100.0, 2.0);
            int index = 0;
            while (index + 4 < numArray.Length)
            {
                double num2 = (((double)numArray[index] / (double)byte.MaxValue - 0.5) * num1 + 0.5) * (double)byte.MaxValue;
                double num3 = (((double)numArray[index + 1] / (double)byte.MaxValue - 0.5) * num1 + 0.5) * (double)byte.MaxValue;
                double num4 = (((double)numArray[index + 2] / (double)byte.MaxValue - 0.5) * num1 + 0.5) * (double)byte.MaxValue;
                if (num2 > (double)byte.MaxValue)
                    num2 = (double)byte.MaxValue;
                else if (num2 < 0.0)
                    num2 = 0.0;
                if (num3 > (double)byte.MaxValue)
                    num3 = (double)byte.MaxValue;
                else if (num3 < 0.0)
                    num3 = 0.0;
                if (num4 > (double)byte.MaxValue)
                    num4 = (double)byte.MaxValue;
                else if (num4 < 0.0)
                    num4 = 0.0;
                numArray[index] = (byte)num2;
                numArray[index + 1] = (byte)num3;
                numArray[index + 2] = (byte)num4;
                index += 4;
            }
            Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            BitmapData bitmapdata2 = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(numArray, 0, bitmapdata2.Scan0, numArray.Length);
            bitmap.UnlockBits(bitmapdata2);
            return bitmap;
        }

        private static Bitmap GetArgbCopy(Bitmap sourceImage, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage((Image)bitmap))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage((Image)sourceImage, new Rectangle(0, 0, bitmap.Width, bitmap.Height), new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }
            return bitmap;
        }

        public static Bitmap LoadArgbBitmap(this string filePath, Size? imageDimensions = null)
        {
            StreamReader streamReader = new StreamReader(filePath);
            Bitmap sourceImage = (Bitmap)Image.FromStream(streamReader.BaseStream);
            streamReader.Close();
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            if (imageDimensions.HasValue)
            {
                width = imageDimensions.Value.Width;
                height = imageDimensions.Value.Height;
            }
            if (sourceImage.PixelFormat != PixelFormat.Format32bppArgb || sourceImage.Width != width || sourceImage.Height != height)
                sourceImage = ExtBitmap.GetArgbCopy(sourceImage, width, height);
            return sourceImage;
        }

        private static byte CalculateColorComponentBlendValue(float source, float overlay, ColorComponentBlendType blendType)
        {
            float num = 0.0f;
            switch (blendType)
            {
                case ColorComponentBlendType.Add:
                    num = source + overlay;
                    break;
                case ColorComponentBlendType.Subtract:
                    num = source - overlay;
                    break;
                case ColorComponentBlendType.Average:
                    num = (float)(((double)source + (double)overlay) / 2.0);
                    break;
                case ColorComponentBlendType.DescendingOrder:
                    num = (double)source < (double)overlay ? overlay : source;
                    break;
                case ColorComponentBlendType.AscendingOrder:
                    num = (double)source > (double)overlay ? overlay : source;
                    break;
            }
            return (double)num <= (double)byte.MaxValue ? ((double)num >= 0.0 ? (byte)num : (byte)0) : byte.MaxValue;
        }

        public static Bitmap ColorBalance(this Bitmap sourceBitmap, byte blueLevel, byte greenLevel, byte redLevel)
        {
            BitmapData bitmapdata1 = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] numArray = new byte[bitmapdata1.Stride * bitmapdata1.Height];
            Marshal.Copy(bitmapdata1.Scan0, numArray, 0, numArray.Length);
            sourceBitmap.UnlockBits(bitmapdata1);
            float num1 = (float)blueLevel;
            float num2 = (float)greenLevel;
            float num3 = (float)redLevel;
            if (numArray.Length == 4)
            {
                float num4 = num1 / (float)byte.MaxValue * (float)numArray[0];
                float num5 = num2 / (float)byte.MaxValue * (float)numArray[1];
                float num6 = num3 / (float)byte.MaxValue * (float)numArray[2];
                if ((double)num4 > (double)byte.MaxValue)
                    num4 = (float)byte.MaxValue;
                else if ((double)num4 < 0.0)
                    num4 = 0.0f;
                if ((double)num5 > (double)byte.MaxValue)
                    num5 = (float)byte.MaxValue;
                else if ((double)num5 < 0.0)
                    num5 = 0.0f;
                if ((double)num6 > (double)byte.MaxValue)
                    num6 = (float)byte.MaxValue;
                else if ((double)num6 < 0.0)
                    num6 = 0.0f;
                numArray[0] = (byte)num4;
                numArray[1] = (byte)num5;
                numArray[2] = (byte)num6;
            }
            else
            {
                int index = 0;
                while (index + 4 < numArray.Length)
                {
                    float num4 = num1 / (float)byte.MaxValue * (float)numArray[index];
                    float num5 = num2 / (float)byte.MaxValue * (float)numArray[index + 1];
                    float num6 = num3 / (float)byte.MaxValue * (float)numArray[index + 2];
                    if ((double)num4 > (double)byte.MaxValue)
                        num4 = (float)byte.MaxValue;
                    else if ((double)num4 < 0.0)
                        num4 = 0.0f;
                    if ((double)num5 > (double)byte.MaxValue)
                        num5 = (float)byte.MaxValue;
                    else if ((double)num5 < 0.0)
                        num5 = 0.0f;
                    if ((double)num6 > (double)byte.MaxValue)
                        num6 = (float)byte.MaxValue;
                    else if ((double)num6 < 0.0)
                        num6 = 0.0f;
                    numArray[index] = (byte)num4;
                    numArray[index + 1] = (byte)num5;
                    numArray[index + 2] = (byte)num6;
                    index += 4;
                }
            }
            Bitmap bitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            BitmapData bitmapdata2 = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(numArray, 0, bitmapdata2.Scan0, numArray.Length);
            bitmap.UnlockBits(bitmapdata2);
            return bitmap;
        }
    }
}
