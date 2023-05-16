using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public class DemoPostToPublishcs
    {
        public static int WhatWasEarlier(DateTime? i_OriginalPost, DateTime? i_DemoPost)
        {
            return DateTime.Compare(i_OriginalPost.Value, i_DemoPost.Value);
        }
    }
}
