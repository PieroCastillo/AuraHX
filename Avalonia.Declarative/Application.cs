using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Themes.Default;

namespace Avalonia.Declarative
{
    public class Application : Avalonia.Application
    {
        public Application(Styles CustomStyles, Window MainWindow, AppTheme ThemeDefault = AppTheme.Light)
        {  
            switch(ThemeDefault)
            {
                case AppTheme.Light: 
                    this.Styles.Add(new Style() { });
                    break;
            }
        }
    }

    public enum AppTheme
    {
        Dark,Light
    }
}
