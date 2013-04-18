namespace HighlightTextMVVM.Converter
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Media;

    [ValueConversion(typeof(string[]), typeof(TextBlock))]
    public class HighlightConverter : IMultiValueConverter
    {
        private static char[] SpaceToken = { ' ' };
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Stopwatch sw = Stopwatch.StartNew();
            
            TextBlock tb = new TextBlock() { TextWrapping = TextWrapping.Wrap };
            try
            {
                if (values != null)
                {
                    if (values.Length == 2)
                    {
                        string text = values[0] as string;
                        string keywords = values[1] as string;

                        if (!String.IsNullOrEmpty(text))
                        {
                            if (!String.IsNullOrEmpty(keywords))
                            {
                                IEnumerable<string> keywordList = keywords.Split(SpaceToken, StringSplitOptions.RemoveEmptyEntries).Select(k => k.Trim()).Distinct().Select(k => Regex.Escape(k));
                                string regExKeywords = "(" + String.Join("|", keywordList) + ")"; // part match

                                Regex regex = new Regex(regExKeywords, RegexOptions.IgnoreCase | RegexOptions.Compiled);

                                string[] substrings = regex.Split(text);


                                if (substrings.Length > 0)
                                {
                                    foreach (var item in substrings)
                                    {
                                        if (regex.Match(item).Success)
                                            tb.Inlines.Add(new Run(item) { Background = Brushes.Yellow });
                                        else
                                            tb.Inlines.Add(new Run(item));
                                    }
                                    return tb;
                                }
                            }

                            tb.Text = text;
                            return tb;
                        }
                    }
                }
            }
            finally
            {
                sw.Stop();

                Debug.WriteLine("{0}", sw.Elapsed);
            }

            return tb;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
