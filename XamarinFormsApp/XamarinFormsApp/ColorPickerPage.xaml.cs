// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColorPickerPage.xaml.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using Xamarin.Forms;

    public partial class ColorPickerPage
    {
        public ColorPickerPage()
        {
            this.InitializeComponent();
        }

        private void ColorSliderChanged(object sender, ValueChangedEventArgs e)
        {
            var red = this.RedSlider.Value;
            var green = this.GreenSlider.Value;
            var blue = this.BlueSlider.Value;

            this.ColorBox.Color = Color.FromRgb(red, green, blue);
        }
    }
}