using Emgu.CV;
using Emgu.CV.CvEnum;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALIN.src
{
    internal class Img_CV
    {
        public static async Task<Bitmap> CVImageCLAHE(Bitmap bitmap,int limit,Size windowsSize)
        {
            Mat srcmat = bitmap.ToMat();
            Mat dstmat = bitmap.ToMat();    
            Task<Bitmap> t = Task.Run(() =>
            {
                CvInvoke.CvtColor(srcmat,srcmat,ColorConversion.Bgr2Gray);
                CvInvoke.CLAHE(srcmat, limit, windowsSize,dstmat);
                return dstmat.ToBitmap(); 
            });
            return await t;
        }
        public static async Task<Bitmap> CVImageBI(Bitmap bitmap,int Threshold_value)
        {
            Mat srcmat = bitmap.ToMat();
            Mat dstmat = bitmap.ToMat();
            Task<Bitmap> t = Task.Run(() =>
            {
                CvInvoke.CvtColor(srcmat, srcmat, ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(srcmat, dstmat, Threshold_value, 255, ThresholdType.Binary);
                return dstmat.ToBitmap();
            });
            return await t;
        }
        public static async Task<Bitmap> CVImageABI(Bitmap bitmap, int windowsSize)
        {
            Mat srcmat = bitmap.ToMat();
            Mat dstmat = bitmap.ToMat();
            Task<Bitmap> t = Task.Run(() =>
            {
                CvInvoke.CvtColor(srcmat, srcmat, ColorConversion.Bgr2Gray);
                CvInvoke.AdaptiveThreshold(srcmat, dstmat, 255, AdaptiveThresholdType.MeanC, ThresholdType.Binary, windowsSize, 0);
                return dstmat.ToBitmap();   
            });
            return await t;
        }
        public static async Task<Bitmap> CVImageFI(Bitmap bitmap, Size windowsSize,double sigma)
        {
            Mat srcmat = bitmap.ToMat();
            Mat dstmat = bitmap.ToMat();
            Task<Bitmap> t = Task.Run(() =>
            {
                CvInvoke.CvtColor(srcmat, srcmat, ColorConversion.Bgr2Gray);
                CvInvoke.GaussianBlur(srcmat, dstmat, windowsSize, sigma);
                return dstmat.ToBitmap();
            });
            return await t;
        }
    }
}
