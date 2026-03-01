using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _originalText = string.Empty;
        private string _currentText = string.Empty;

        public void SetText(string text)
        {
            _originalText = text;
            _currentText = text;
        }

        public string GetCurrentText()
        {
            return _currentText;
        }

        public void ConvertToUppercase()
        {
            _currentText = _currentText.ToUpper();
        }

        public void ConvertToLowercase()
        {
            _currentText = _currentText.ToLower();
        }

        public int CountCharacters()
        {
            return _currentText.Length;
        }

        public bool CheckIfContains(string word)
        {
            return _currentText.Contains(word);
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            _currentText = _currentText.Replace(oldWord, newWord);
        }

        public void ExtractSubstring(int startIndex, int length)
        {
            if (startIndex >= 0 && startIndex + length <= _currentText.Length)
            {
                _currentText = _currentText.Substring(startIndex, length);
            }
            else
            {
                Console.WriteLine("\n[Error] Invalid start index or length for the current text.");
            }
        }

        public void TrimSpaces()
        {
            _currentText = _currentText.Trim();
        }

        public void ResetToOriginal()
        {
            _currentText = _originalText;
        }
    }
}
