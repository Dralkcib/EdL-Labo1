using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Lano5.Converter
{
    public class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            //No value provided
            if(value == null)
            {
                return null;
            }
            //No format provided
            if(parameter == null)
            {
                return value;
            }

            if (value.GetType() == typeof(DateTime))
            {
                DateTime date = (DateTime)value;
                return date.GetDateTimeFormats('D');
            }
            
            return String.Format((String)parameter, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}
