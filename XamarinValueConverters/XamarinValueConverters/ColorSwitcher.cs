﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinValueConverters
{
    public class ColorSwitcher : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string red = "C32616";
            string green = "3EC316";

            switch (value.ToString())
            {
                case "1":
                    return "#" + parameter + red;
                case "2":
                    return "#" + parameter + green;
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
