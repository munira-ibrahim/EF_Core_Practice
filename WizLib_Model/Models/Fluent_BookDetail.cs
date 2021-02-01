﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WizLib_Model.Models
{
    public class Fluent_BookDetail
    {
        public int BookDetail_Id { get; set; }
        public int NumberOfChepters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }

        public Fluent_Book Fluent_Book { get; set; }

    }
}