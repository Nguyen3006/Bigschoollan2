﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab456.Models;

namespace Lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}