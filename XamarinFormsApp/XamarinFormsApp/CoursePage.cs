// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoursePage.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using Xamarin.Forms;

    public class CoursePage : ContentPage
    {
        public CoursePage()
        {
            this.Padding = new Thickness(10);
            this.SetBinding(TitleProperty, nameof(Course.Title));

            var titleLabel = new Label { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            titleLabel.SetBinding(Label.TextProperty, nameof(Course.Title));

            var authorLabel = new Label { FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
            authorLabel.SetBinding(Label.TextProperty, nameof(Course.Author));

            this.Content = new StackLayout
            {
                Children =
                {
                    titleLabel,
                    authorLabel
                }
            };
        }
    }
}