// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleContentPage.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using Xamarin.Forms;

    public class SimpleContentPage : ContentPage
    {
        public SimpleContentPage()
        {
            var label = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                Text = "A very simple label."
            };

            var entry = new Entry
            {
                Placeholder = "Type something here"
            };

            var button = new Button
            {
                Text = "Click Me!"
            };

            button.Clicked += (s, e) => { label.Text = string.Concat("The user typed: ", entry.Text); };

            this.Content = new StackLayout
            {
                Padding = 30,
                Spacing = 30,
                Children = { label, entry, button }
            };
        }
    }
}