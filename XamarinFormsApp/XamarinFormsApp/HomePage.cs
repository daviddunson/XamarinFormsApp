// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomePage.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using Xamarin.Forms;

    public class HomePage : ContentPage
    {
        public HomePage()
        {
            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical
            };

            var colorPickerButton = new Button
            {
                Text = "Color Picker"
            };

            colorPickerButton.Clicked += (s, e) => this.Navigation.PushAsync(new ColorPickerPage());
            layout.Children.Add(colorPickerButton);

            var listViewButton = new Button
            {
                Text = "List View"
            };

            listViewButton.Clicked += (s, e) => this.Navigation.PushAsync(new ListViewPage());
            layout.Children.Add(listViewButton);

            var simpleContentButton = new Button
            {
                Text = "Simple Content"
            };

            simpleContentButton.Clicked += (s, e) => this.Navigation.PushAsync(new SimpleContentPage());
            layout.Children.Add(simpleContentButton);

            var absoluteLayoutButton = new Button
            {
                Text = "Absolute Layout"
            };

            absoluteLayoutButton.Clicked += (s, e) => this.Navigation.PushAsync(new AbsoluteLayoutPage());
            layout.Children.Add(absoluteLayoutButton);

            var relativeLayoutButton = new Button
            {
                Text = "Relative Layout"
            };

            relativeLayoutButton.Clicked += (s, e) => this.Navigation.PushAsync(new RelativeLayoutPage());
            layout.Children.Add(relativeLayoutButton);

            var stackLayoutButton = new Button
            {
                Text = "Stack Layout"
            };

            stackLayoutButton.Clicked += (s, e) => this.Navigation.PushAsync(new StackLayoutPage());
            layout.Children.Add(stackLayoutButton);

            var masterDetailButton = new Button
            {
                Text = "Master Detail"
            };

            masterDetailButton.Clicked += (s, e) => this.Navigation.PushAsync(new CourseMasterDetailPage());
            layout.Children.Add(masterDetailButton);

            var tabButton = new Button
            {
                Text = "Tabbed"
            };

            tabButton.Clicked += (s, e) =>
            {
                var tabbedPage = new TabbedPage
                {
                    Title = "Tabbed"
                };

                foreach (var course in Course.All)
                {
                    var coursePage = new CoursePage();
                    coursePage.BindingContext = course;
                    tabbedPage.Children.Add(coursePage);
                }

                this.Navigation.PushAsync(tabbedPage);
            };

            layout.Children.Add(tabButton);

            var carouselButton = new Button
            {
                Text = "Carousel"
            };

            carouselButton.Clicked += (s, e) =>
            {
                var carouselPage = new CarouselPage
                {
                    Title = "Carousel"
                };

                foreach (var course in Course.All)
                {
                    var coursePage = new CoursePage();
                    coursePage.BindingContext = course;
                    carouselPage.Children.Add(coursePage);
                }

                this.Navigation.PushAsync(carouselPage);
            };

            layout.Children.Add(carouselButton);

            this.Content = new ScrollView { Content = layout };
        }
    }
}