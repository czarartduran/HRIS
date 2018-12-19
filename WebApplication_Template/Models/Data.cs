/*
Author: Czar Art Z. Duran
Email: czarartduran@ymail.com
Contact: +63 917 328 2308
Description: default class to be used in ajax calls
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Template.Models
{
    public class Data
    {
        public string sample { get; set; }

        #region MyRegion
        public string username { get; set; }

        public string password { get; set; }
        #endregion

    }
}