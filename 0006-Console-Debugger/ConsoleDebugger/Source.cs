using System;
using System.Windows.Forms;


namespace ConsoleDebugger
{
    public partial class Source : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Source()
        {
            InitializeComponent();

            /* Run Console */
            AllocConsole();
        }

        private void DrawHelloWorldButton_Click(object sender, EventArgs e)
        {
            string[] colors = { "Red", "Yellow", "Green", "Blue", "White", "Cyan", "Magenta", "Gray" };

            for (int i = 0; i < 8; i++)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[i]);
                Console.WriteLine("HelloWorld");
            }
            Console.ResetColor();
        }
    }
}
