// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseMasterDetailPage.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using System.Linq;
    using Xamarin.Forms;

    public class CourseMasterDetailPage : MasterDetailPage
    {
        public CourseMasterDetailPage()
        {
            this.Title = "Master Detail";

            var listView = new ListView();
            listView.ItemsSource = Course.All;
            listView.ItemSelected += (s, e) =>
            {
                if (e.SelectedItem != null)
                {
                    this.Detail.BindingContext = e.SelectedItem;
                }
            };

            this.Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            this.Detail = new CoursePage();
            this.Detail.BindingContext = Course.All.First();
        }
    }
}