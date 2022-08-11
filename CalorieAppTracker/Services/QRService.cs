using QRCoder;
using System;

namespace CalorieAppTracker.Services
{
    public class QRService
    {
        private readonly QRCodeGenerator _generator;

        public QRService(QRCodeGenerator generator)
        {
            _generator = generator;
        }

        public string GetQRCodeAsBase64(string textToEncode)
        {
            QRCodeData qrCodeData = _generator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);

            return Convert.ToBase64String(qrCode.GetGraphic(4));
        }
    }
}
