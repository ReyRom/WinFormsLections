using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_34_45
{
    public class Settings
    {
        public static Settings Instance { get; } = new Settings();

        private Color _color;
        public Color Color
        {
            get => _color; 
            set
            {
                _color = value;
                ColorChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ColorChanged;
    }
}
