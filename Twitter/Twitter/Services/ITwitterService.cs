using System;
using System.Collections.Generic;
using Twitter.Models;

namespace Twitter.Services
{
    public interface ITwitterService
    {
        bool authenticate(String key, String secret);
        List<Tweet> getTweets();
    }
}
