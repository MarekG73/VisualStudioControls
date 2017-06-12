using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewControls
{
    /// <summary>
    /// Kontrolka do wprowadzania numeru IP.
    /// Zawiera sprawdzenie poprawności:
    /// -ogranicza wartość do 255,
    /// -uniemożliwia wprowadzanie innych znaków niż cyfry
    /// </summary>
    public partial class NumericBoxIP: UserControl
    {
        #region Zmienne

        private int[] _ipNumbers;
        private TextBox[] _TextFields;

        #endregion

        #region Konstruktory
        /// <summary>
        /// Podstawowy konstruktor - ustawia adres 0.0.0.0
        /// </summary>
        public NumericBoxIP()
        {
            InitializeComponent();

            _ipNumbers = new int[4];
            _TextFields = new TextBox[4] { ipBoxFieldA, ipBoxFieldB, ipBoxFieldC, ipBoxFieldD };

            for (int ipOct = 0; ipOct < 4; ipOct++)
            {
                _TextFields[ipOct].Text = "0";
                _ipNumbers[ipOct] = 0;
            }
        }
        /// <summary>
        /// Konstruktor ustawiający adres na 127.0.0.0 
        /// </summary>
        /// <param name="p_isLocalhost">Wartość <i>true</i> ustawia <i>localhost</i></param>
        public NumericBoxIP(bool p_isLocalhost)
        {
            InitializeComponent();

            _ipNumbers = new int[4];
            _TextFields = new TextBox[4] { ipBoxFieldA, ipBoxFieldB, ipBoxFieldC, ipBoxFieldD };

            if (p_isLocalhost == true)
            {
                _TextFields[0].Text = "127";
                _ipNumbers[0] = 127;
                for (int ipOct = 1; ipOct < 4; ipOct++)
                {
                    _TextFields[ipOct].Text = "0";
                    _ipNumbers[ipOct] = 0;
                }
            }
            else
            {
                for (int ipOct = 0; ipOct < 4; ipOct++)
                {
                    _TextFields[ipOct].Text = "0";
                    _ipNumbers[ipOct] = 0;
                }
            }
        }
        /// <summary>
        /// Konstruktor umożliwiający nadanie początkowych wartości
        /// </summary>
        /// <param name="p_a">Pierwszy oktet - max. 255</param>
        /// <param name="p_b">Drugi  oktet - max. 255</param>
        /// <param name="p_c">Trzeci  oktet - max. 255</param>
        /// <param name="p_d">Czwarty  oktet - max. 255</param>
        public NumericBoxIP(int p_a, int p_b, int p_c, int p_d)
        {
            InitializeComponent();

            _ipNumbers = new int[4] { p_a > 255 ? 255:p_a, p_b > 255 ? 255 : p_b, p_c > 255 ? 255 : p_c, p_d > 255 ? 255 : p_d };
            _TextFields = new TextBox[4] { ipBoxFieldA, ipBoxFieldB, ipBoxFieldC, ipBoxFieldD };

            for (int ipOct = 0; ipOct < 4; ipOct++)
            {
                _TextFields[ipOct].Text = _ipNumbers[ipOct].ToString();
            } 
        }
        #endregion

        #region Funkcje zwracające
        /// <summary>
        /// Funkcja zwraca tablicę z numerem IP
        /// </summary>
        /// <returns>int[4]</returns>
        public int[] GetNumericIP()
        {
            _ipNumbers[0] = int.Parse(ipBoxFieldA.Text);
            _ipNumbers[1] = int.Parse(ipBoxFieldB.Text);
            _ipNumbers[2] = int.Parse(ipBoxFieldC.Text);
            _ipNumbers[3] = int.Parse(ipBoxFieldD.Text);

            return _ipNumbers;
        }
        /// <summary>
        /// Funkcja zwraca łańcuch tekstowy z numerem IP
        /// </summary>
        /// <returns>string</returns>
        public string GetTextIP()
        {
            string ipText = "";
            for (int ipOct = 0; ipOct < 4; ipOct++)
            {
                ipText += _TextFields[ipOct].Text + ".";
            }
            return ipText.Remove(ipText.Length - 1);
        }
        /// <summary>
        /// Funkcja zwraca numer IP jako osobne oktety w formie tekstowej
        /// </summary>
        /// <returns>IEnumerable<string></returns>
        public IEnumerable<string> GetFragmentedTextIP()
        {
            for (int ipOct = 0; ipOct < 4; ipOct++)
            {
                yield return _TextFields[ipOct].Text;
            }
            yield break;
        }
        #endregion

        #region Funkcje wewnętrzne
        //Sprawdzanie wpisywanych znaków
        private char CheckCharValue(string p_value)
        {
            int result = 0;

            if (int.TryParse(p_value, out result))
            {
                return char.Parse(p_value);
            }
            return ' ';
        }
        //Sprawdzanie wpisanej liczby (max. 255)
        private string CheckTotalValue(string p_totalValue)
        {
            int result = 0;
            if (int.TryParse(p_totalValue, out result) && result < 256)
            {
                return p_totalValue;
            }
            return "";
        }
        #endregion

        #region Zdarzenia
        private void ipBoxField_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sprawdzenie naciśniętego klawisza - możliwe tylko cyfry i sterujące
            TextBox usedBox = sender as TextBox;
            if (usedBox.Text.Length < 4 && e.KeyChar != 8)
            {
                e.KeyChar = CheckCharValue(e.KeyChar.ToString());
            }
            else 
            {
                if (usedBox.Text.Length > 0)
                {
                    usedBox.Text.Remove(usedBox.Text.Length - 1);
                }       
            }
        }
        private void ipBoxField_TextChanged(object sender, EventArgs e)
        {
            TextBox usedBox = sender as TextBox;
            usedBox.Text = CheckTotalValue(usedBox.Text);
        }
        #endregion
    }
}