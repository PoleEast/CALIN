using Emgu.CV.Dnn;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using Xunit;
using Yolov8Net;


namespace CALIN.src
{
    internal class Img_Processing
    {
        private static string model = "..\\..\\..\\Assets\\best.onnx";

        /// <summary>
        /// 均質化
        /// </summary>
        /// <param name="files"></param>
        public static async Task<Bitmap> ImageEH(Bitmap bitmap)
        {
            // 開始執行緒
            Task<Bitmap> t = Task.Run(() =>
            {
                int[] histogram = getGrayHistogram(bitmap);
                bitmap = EqualizeImage(bitmap, histogram);
                return bitmap;
            });
      
            return await t;
        }
        private static int[] getGrayHistogram(Bitmap image)
        {
            int[] histogram = new int[256]; // 建立直方圖

            // 計算像素值的直方圖
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);
                    int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11); // 轉換成灰度值
                    histogram[grayValue]++;
                }
            }
            return histogram;
        }
        private static Bitmap EqualizeImage(Bitmap image, int[] histogram)
        {
            // 計算累積分佈函數
            int totalPixels = image.Width * image.Height;
            int cumulative = 0;
            int[] mapping = new int[256];

            for (int i = 0; i < 256; i++)
            {
                cumulative += histogram[i];
                mapping[i] = (int)(((float)cumulative / totalPixels) * 255);
            }

            // 對每個像素進行均質化
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11); // 轉換成灰度值
                    int newGrayValue = mapping[grayValue];
                    Color newPixel = Color.FromArgb(newGrayValue, newGrayValue, newGrayValue);
                    image.SetPixel(x, y, newPixel);
                }
            }
            return image;
        }
        public static async Task<Bitmap> ImageBI(Bitmap bitmap,int threshold)
        {
            // 開始執行緒
            Task<Bitmap> t = Task.Run(() =>
            {
                bitmap = BinarizeImage(bitmap, threshold);
                return bitmap;
            });

            return await t;
        }
        private static Bitmap BinarizeImage(Bitmap inputImage, int threshold)
        {
            Bitmap binaryImage = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int grayscaleValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    Color binaryColor = grayscaleValue > threshold ? Color.White : Color.Black;

                    binaryImage.SetPixel(x, y, binaryColor);
                }
            }
            return binaryImage;
        }
        public static SixLabors.ImageSharp.Image ConvertToImageSharp(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, SeekOrigin.Begin);

                return SixLabors.ImageSharp.Image.Load(stream);
            }
        }

        public static Bitmap ConvertToBitmap(SixLabors.ImageSharp.Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, new JpegEncoder());
                stream.Seek(0, SeekOrigin.Begin);

                Image imgSystemDrawing = Image.FromStream(stream);
                return new Bitmap(imgSystemDrawing);
            }
        }

        public static Bitmap YOLOPridect(Bitmap img, SixLabors.Fonts.Font font)
        {
            IPredictor yolo = YoloV8Predictor.Create(model, new string[] { "dust" });
            var image = ConvertToImageSharp(img);
            var predictions = yolo.Predict(image);
            Assert.NotNull(predictions);
            DrawBoxes(yolo.ModelInputHeight, yolo.ModelInputWidth, image, predictions, font);
            return ConvertToBitmap(image);
        }

        public static void DrawBoxes(int modelInputHeight, int modelInputWidth, SixLabors.ImageSharp.Image image, Prediction[] predictions, SixLabors.Fonts.Font font)
        {

            foreach (var pred in predictions)
            {
                var originalImageHeight = image.Height;
                var originalImageWidth = image.Width;

                var x = (int)Math.Max(pred.Rectangle.X, 0);
                var y = (int)Math.Max(pred.Rectangle.Y, 0);
                var width = (int)Math.Min(originalImageWidth - x, pred.Rectangle.Width);
                var height = (int)Math.Min(originalImageHeight - y, pred.Rectangle.Height);

                //Note that the output is already scaled to the original image height and width.

                // Bounding Box Text
                string text = $"{pred.Label.Name} [{pred.Score}]";
                var size = TextMeasurer.MeasureAdvance(text, new TextOptions(font));

                image.Mutate(d => d.Draw(SixLabors.ImageSharp.Drawing.Processing.Pens.Solid(SixLabors.ImageSharp.Color.Yellow, 2),
                    new SixLabors.ImageSharp.Rectangle(x, y, width, height)));


                //image.Mutate(d => d.DrawText(
                //    new TextOptions(font)
                //    {
                //        Origin = new System.Drawing.Point(x, (int)(y - size.Height - 1))
                //    },
                //    text, SixLabors.ImageSharp.Color.Yellow)); ;
            }
        }
    }
}