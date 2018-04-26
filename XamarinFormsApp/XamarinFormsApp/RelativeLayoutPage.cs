// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RelativeLayoutPage.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using Xamarin.Forms;

    public class RelativeLayoutPage : ContentPage
    {
        public RelativeLayoutPage()
        {
            var layout = new RelativeLayout();

            var label1 = new Label
            {
                Text = "This is a line of text."
            };

            var label2 = new Label
            {
                Text = "This is another line of text."
            };

            var label3 = new Label
            {
                Text = "This is some more text."
            };

            layout.Children.Add(label1, Constraint.Constant(0), Constraint.RelativeToParent(parent => parent.Height / 2));
            layout.Children.Add(label2, Constraint.RelativeToView(label1, (parent, other) => other.X + other.Width), Constraint.RelativeToView(label1, (parent, other) => other.Y - other.Height));
            layout.Children.Add(label3, Constraint.RelativeToView(label2, (parent, other) => other.X - other.Width - label3.Width), Constraint.RelativeToView(label1, (parent, other) => other.Y));

            label3.SizeChanged += (s, e) => { layout.ForceLayout(); };

            this.Content = layout;
        }
    }
}