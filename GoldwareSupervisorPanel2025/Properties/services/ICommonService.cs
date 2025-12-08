using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GoldwareSupervisorPanel2025.Properties.services
{
    public interface ICommonService
    {
        public Image TintIcon(Image original, Color color);

        public bool CheckInternetPing();

    }


    public class CommonService : ICommonService
    {
        #region TintIcon
        public Image TintIcon(Image original, Color color)
        {
            Bitmap tinted = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(tinted))
            using (ImageAttributes attrs = new ImageAttributes())
            {
                ColorMatrix matrix = new ColorMatrix(new float[][]
                {
            new float[] {0, 0, 0, 0, 0},
            new float[] {0, 0, 0, 0, 0},
            new float[] {0, 0, 0, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {color.R / 255f, color.G / 255f, color.B / 255f, 0, 1}
                });

                attrs.SetColorMatrix(matrix);

                g.DrawImage(
                    original,
                    new Rectangle(0, 0, original.Width, original.Height),
                    0, 0, original.Width, original.Height,
                    GraphicsUnit.Pixel,
                    attrs
                );
            }

            return tinted;
        }
        #endregion

        #region CheckInternetPing
        public bool CheckInternetPing()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("8.8.8.8", 3000); // 3 second timeout
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
