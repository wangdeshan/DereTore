﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace StarlightDirector.UI.Converters
{
    public class BooleanToValuesConverter : IValueConverter
    {
        public object TrueValue { get; set; }
        public object FalseValue { get; set; }
        public object NullValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var b = value as bool?;
            return b.HasValue ? (b.Value ? TrueValue : FalseValue) : NullValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
