﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterOhana.Models
{
    public class Tweet
    {
        public String Text { get; set; }
        public String UserName { get; set; }
        public String ScreenName { get; set; }
        public DateTime CreatedAt { get; set; }
        public String UserProfileImage { get; set; }
        public long Id { get; set; }
    }
}