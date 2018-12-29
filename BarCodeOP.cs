using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using ZXing;
using ZXing.Common;

namespace ImageCode
{
    public class BarCodeOP
    {
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">编码的内容字符串</param>
        /// <param name="filePath">生成的图片保存路径</param>
        /// <param name="height">生成图片的高度</param>
        /// <param name="width">生成图片的宽度</param>
        public static void Encode(string content, string filePath, int height, int? width = null)
        {
            EncodingOptions options = null;
            ZXing.BarcodeWriter writer = null;
            options = new EncodingOptions
            {
                Height = height,
                PureBarcode = true
            };
            if (width != null)
            {
                options.Width = (int)width;
            }
            writer = new ZXing.BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = options;
            Bitmap bitmap = writer.Write(content);
            bitmap.Save(filePath, ImageFormat.Png);
        }

    }
}
