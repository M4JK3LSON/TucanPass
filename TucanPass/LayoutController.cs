using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace TucanPass
{
    public class LayoutController
    {
        public static SolidColorBrush tucanOrangeColor = new SolidColorBrush(Color.FromArgb(255, 255, 127, 43));
        public static SolidColorBrush tucanBlackColor = new SolidColorBrush(Color.FromArgb(255, 61, 57, 54));

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                int ounter = VisualTreeHelper.GetChildrenCount(depObj);
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null & child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChildren in FindVisualChildren<T>(child))
                    {
                        yield return childOfChildren;
                    }
                }



            }
        }
    }
}
