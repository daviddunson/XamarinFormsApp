// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseCell.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using Xamarin.Forms;

    public class CourseCell : ViewCell
    {
        public CourseCell()
        {
            var titleLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                Margin = new Thickness(10, 0),
                VerticalTextAlignment = TextAlignment.Center
            };

            var authorLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(10, 0)
            };

            titleLabel.SetBinding(Label.TextProperty, new Binding(nameof(Course.Title)));
            authorLabel.SetBinding(Label.TextProperty, new Binding(nameof(Course.Author)));

            this.View = new StackLayout
            {
                Children = { titleLabel, authorLabel },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}