using System;
using System.Collections.Generic;
using System.Text;
using Twitter.Entities;

namespace Twitter.Services
{
    public interface ITwitterService
    {
        Boolean Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
