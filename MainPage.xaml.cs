using System;
using Microsoft.Maui.Controls;

namespace MauiappMeucombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // Correto: este método é gerado automaticamente pelo XAML
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg;

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol é mais vantajoso.\n\n" +
                          "Isso acontece porque, apesar de o etanol render menos que a gasolina, " +
                          "quando o preço dele é até 70% do valor da gasolina, o custo-benefício compensa.";
                }
                else
                {
                    msg = "A gasolina é mais vantajosa.\n\n" +
                          "Nesse caso, o preço do etanol está alto em relação à gasolina, " +
                          "então o rendimento maior da gasolina acaba sendo mais econômico.";
                }

                DisplayAlert("Resultado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Fechar");
            }
        }
    }
}

            