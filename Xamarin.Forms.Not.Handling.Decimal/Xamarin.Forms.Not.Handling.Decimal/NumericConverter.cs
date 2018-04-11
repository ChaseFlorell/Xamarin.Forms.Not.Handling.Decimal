using System;
using System.Globalization;

namespace Xamarin.Forms.Not.Handling.Decimal
{
    public class NumericConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Activator.CreateInstance(targetType);
            return double.TryParse(value.ToString(), NumberStyles.Any, culture, out var result) ? result.ToString(culture) : value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Activator.CreateInstance(targetType); // default instance of targetType if null
            var str = value.ToString();

            if (targetType == typeof(decimal) && decimal.TryParse(str, NumberStyles.Any, culture, out var dcml)) return dcml;
            if (targetType == typeof(double) && double.TryParse(str, NumberStyles.Any, culture, out var dbl)) return dbl;
            if (targetType == typeof(long) && long.TryParse(str, NumberStyles.Any, culture, out var lng)) return lng;
            if (targetType == typeof(ulong) && ulong.TryParse(str, NumberStyles.Any, culture, out var ulng)) return ulng;
            if (targetType == typeof(float) && float.TryParse(str, NumberStyles.Any, culture, out var flt)) return flt;
            if (targetType == typeof(short) && short.TryParse(str, NumberStyles.Any, culture, out var shrt)) return shrt;
            if (targetType == typeof(ushort) && ushort.TryParse(str, NumberStyles.Any, culture, out var ushrt)) return ushrt;

            return value;
        }
    }
}