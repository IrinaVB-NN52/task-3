using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Задача_3
{
    internal class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        static MyCommands()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Cntr+T"));
            Exit = new RoutedUICommand ("Выход","Exit",typeof (MyCommands),input );
        }
    }
}
