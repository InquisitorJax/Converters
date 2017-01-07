using System;
using Xamarin.Forms;
using System.IO;

namespace FormsCommunityToolkit.Converters
{
    [ValueConversion(typeof(byte[]), typeof(ImageSource))]
    public class ByteArrayToImageSourceConverter : IValueConverter
    {
        public static ByteArrayToImageSourceConverter Instance { get; } = new ByteArrayToImageSourceConverter();

        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        #region IValueConverter implementation

        /// <summary>
        /// Bind a byte[] of an image to the ImageSource property of an Image
        /// </summary>
        /// <param name="value">the image byte array</param>
        /// <param name="targetType">target</param>
        /// <param name="parameter">parameter</param>
        /// <param name="culture">culutre</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                byte[] bytes = (byte[])value;
                ImageSource retImageSource = ImageSource.FromStream(() => new MemoryStream(bytes));
                return retImageSource;
            }

            if (parameter != null)
            {
                string fillerIcon = (string)parameter;
                ImageSource retImageSource = ImageSource.FromFile(fillerIcon);
                return retImageSource;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion IValueConverter implementation
    }
}