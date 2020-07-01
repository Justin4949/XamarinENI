using System;
using System.Collections.Generic;
using System.Text;
using Twitter.Models;

namespace Twitter.Services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string username, string password)
        {
            if (username.Equals("justin") && password.Equals("justin"))
            {
                return true;
            }
            return false;
        }
        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet() { creationDate = "Thu Apr 06 15:28:43 +0000 2017", identifier = "850007368138018817", userIdentifier = "6253282", userName = "Twitter API", userPseudo = "twitterapi" });
            tweets.Add(new Tweet() { creationDate = "Thu Apr 06 15:38:43 +0000 2017", identifier = "850007368138018818", userIdentifier = "6253282", userName = "Twitter API", userPseudo = "twitterapi" });
            tweets.Add(new Tweet() { creationDate = "Thu Apr 06 15:48:43 +0000 2017", identifier = "850007368138018819", userIdentifier = "6253282", userName = "Twitter API", userPseudo = "twitterapi" });
            tweets.Add(new Tweet() { creationDate = "Thu Apr 06 15:58:43 +0000 2017", identifier = "850007368138018820", userIdentifier = "6253282", userName = "Twitter API", userPseudo = "twitterapi" });
            return tweets;
        }
    }
}
