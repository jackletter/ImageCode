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
