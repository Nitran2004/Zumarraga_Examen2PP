using System;
using Microsoft.Maui.Controls;

namespace Zumarraga_Examen2P
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            string input = InputEntry.Text;

            int totalLetters = input.Count(char.IsLetter);
            int totalNumbers = input.Count(char.IsDigit);
            int totalVowels = input.Count(c => "aeiouAEIOU".Contains(c));
            int totalUppercase = input.Count(char.IsUpper);
            int totalLowercase = input.Count(char.IsLower);
            int totalCharacters = input.Length;

            LetterCountLabel.Text = $"Total de letras: {totalLetters}\n";
            ResultLabel.Text = $"Total de números: {totalNumbers}\n" +
                               $"Total de mayúsculas: {totalUppercase}\n" +
                               $"Total de minúsculas: {totalLowercase}\n" +
                               $"Total de vocales: {totalVowels}\n";
                
            CharacterCountLabel.Text = $"Total de caracteres: {totalCharacters}\n";
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            InputEntry.Text = string.Empty;
            CharacterCountLabel.Text = string.Empty;
            LetterCountLabel.Text = string.Empty;
            ResultLabel.Text = string.Empty;
        }
    }
}
