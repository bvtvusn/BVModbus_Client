using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.GUI
{
    internal static class ColorPalette
    {
        public static Color Background { get; } = Color.FromArgb(2, 2, 2, 2);
        public static Color Header { get; } = Color.FromArgb(44, 54, 79);
        public static Color Detail { get; } = Color.FromArgb(27, 188, 155);
        public static Color Action { get; } = Color.FromArgb(255, 177, 0);
    }
}
