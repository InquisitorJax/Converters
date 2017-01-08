using System;
using System.IO;
using Xamarin.Forms;

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
            byte[] bytes = value as byte[];
            if (bytes != null)
            {
                try
                {
                    ImageSource retImageSource = ImageSource.FromStream(() => new MemoryStream(bytes));
                    return retImageSource;
                }
                catch
                {
                    return ResolveDefaultImage(parameter);
                }
            }

            return ResolveDefaultImage(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private object ResolveDefaultImage(object parameter)
        {
            string defaultImage = parameter as string;
            if (defaultImage != null)
            {
                try
                {
                    ImageSource retImageSource = ImageSource.FromFile(defaultImage);
                    return retImageSource;
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        #endregion IValueConverter implementation
    }
}