// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Course.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinFormsApp
{
    using System.Collections.Generic;

    public class Course
    {
        public static IEnumerable<Course> All { get; } = new[]
        {
            new Course { Title = ".NET Development for Android", Author = "Jim Wilson" },
            new Course { Title = ".NET Development for iOS", Author = "Jim Wilson" },
            new Course { Title = ".NET Development for Windows", Author = "Jim Wilson" },
            new Course { Title = "Basket Weaving", Author = "Jane Doe" }
        };

        public string Author { get; set; }

        public string Title { get; set; }
    }
}