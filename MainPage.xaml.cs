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

            int mz_totalLetters = input.Count(char.IsLetter);
            int mz_totalNumbers = input.Count(char.IsDigit);
            int mz_totalVowels = input.Count(c => "aeiouAEIOU".Contains(c));
            int mz_totalUppercase = input.Count(char.IsUpper);
            int mz_totalLowercase = input.Count(char.IsLower);
            int mz_totalCharacters = input.Length;

            LetterCountLabel.Text = $"mz_Total de letras: {mz_totalLetters}\n";
            ResultLabel.Text = $"mz_Total de números: {mz_totalNumbers}\n" +
                               $"mz_Total de mayúsculas: {mz_totalUppercase}\n" +
                               $"mz_Total de minúsculas: {mz_totalLowercase}\n" +
                               $"mz_Total de vocales: {mz_totalVowels}\n";
                
            CharacterCountLabel.Text = $"mz_Total de caracteres: {mz_totalCharacters}\n";
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            InputEntry.Text = string.Empty;
            CharacterCountLabel.Text = string.Empty;
            LetterCountLabel.Text = string.Empty;
            ResultLabel.Text = string.Empty;
        }

        private async void mz_OnOpcion1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opcion1Page());
        }

        private async void OnOpcion2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opcion2Page());
        }

        private async void OnCustomPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomPage());
        }
    }
}
