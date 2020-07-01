using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter.Models
{
    public class Tweet
    {
        public String identifier { get; set; }
        public String creationDate { get; set; }
        public String userName { get; set; }
        public String userIdentifier { get; set; }
        public String userPseudo { get; set; }
    }
}
