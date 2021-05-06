using System.Windows.Controls;
using System.Windows.Input;

namespace DemoHelper
{
    class DemoHelper
    {
        private static void TextLimit(TextBox textBox, int Maxlength)
        {
            textBox.MaxLength = Maxlength;
            return;
        }
        private static void TextLimit(TextBlock textBlock, int Maxlength)
        {
            textBlock.Text = textBlock.Text.Substring(0, Maxlength);
            return;
        }
        private static void TextLimit(Label label, int Maxlength)
        {
            label.Content = label.Content.ToString().Substring(0, Maxlength);
            return;
        }
        private static string TextLimit(string stringer, int Maxlength)
        {
            stringer = stringer.Substring(0, Maxlength);
            return stringer;
        }

        private static void OnlyPhone(TextBox textBox, TextCompositionEventArgs e)
        {
            string AcceptSymbol = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                AcceptSymbol += i.ToString();
            }

            AcceptSymbol += "+-()";

            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }

        private static void NumberPlus(TextBox textBox, TextCompositionEventArgs e, string listplus = "")
        {
            string AcceptSymbol = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                AcceptSymbol += i.ToString();
            }
            AcceptSymbol += listplus;
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void TextAcceptSymbol(TextBox textBox, TextCompositionEventArgs e, string listplus)
        {
            string AcceptSymbol = string.Empty;
            AcceptSymbol += listplus;
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void EmailTextBox(TextBox textBox, TextCompositionEventArgs e, string listplus = "")
        {
            string AcceptSymbol = string.Empty;
            for (int i = 65; i < 91; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 97; i < 123; i++)
            {
                AcceptSymbol += (char)i;
            }

            for (int i = 0; i < 10; i++)
            {
                AcceptSymbol += i.ToString();
            }
            AcceptSymbol += "@._";
            AcceptSymbol += listplus;
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }

        private static void UnionLanguage(TextBox textBox, TextCompositionEventArgs e)
        {
            string AcceptSymbol = string.Empty;
            for (int i = 65; i < 91; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 97; i < 123; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 1040; i < 1104; i++)
            {
                AcceptSymbol += (char)i;
            }
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void UnionLanguagePlus(TextBox textBox, TextCompositionEventArgs e, string listplus)
        {
            string AcceptSymbol = string.Empty;
            for (int i = 65; i < 91; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 97; i < 123; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 1040; i < 1104; i++)
            {
                AcceptSymbol += (char)i;
            }
            AcceptSymbol += listplus;
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void RuLanguage(TextBox textBox, TextCompositionEventArgs e)
        {
            string AcceptSymbol = string.Empty;
            for (int i = 1040; i < 1104; i++)
            {
                AcceptSymbol += (char)i;
            }
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void RuLanguagePlus(TextBox textBox, TextCompositionEventArgs e, string listplus)
        {
            string AcceptSymbol = string.Empty;
            for (int i = 1040; i < 1104; i++)
            {
                AcceptSymbol += (char)i;
            }
            AcceptSymbol += listplus;
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void EnLanguage(TextBox textBox, TextCompositionEventArgs e)
        {
            string AcceptSymbol = string.Empty;
            for (int i = 65; i < 91; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 97; i < 123; i++)
            {
                AcceptSymbol += (char)i;
            }
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
        private static void EnLanguagePlus(TextBox textBox, TextCompositionEventArgs e, string listplus)
        {
            string AcceptSymbol = string.Empty;
            for (int i = 65; i < 91; i++)
            {
                AcceptSymbol += (char)i;
            }
            for (int i = 97; i < 123; i++)
            {
                AcceptSymbol += (char)i;
            }
            AcceptSymbol += listplus;
            e.Handled = AcceptSymbol.IndexOf(e.Text) < 0;
        }
    }
}
