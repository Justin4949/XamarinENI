using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twitter.Entities;

namespace Twitter.Services
{
    public class TwitterService : ITwitterService {
        public List<Tweet> Tweets {
            get {
                User user = new User() { Login = "justin", Password = "justin" };

                return new List<Tweet>() {
                    new Tweet(){User = user, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = "03/07/2020"},
                    new Tweet(){User = user, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = "03/07/2020"},
                    new Tweet(){User = user, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = "03/07/2020"},
                    new Tweet(){User = user, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = "03/07/2020"},
                    new Tweet(){User = user, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = "03/07/2020"}
                };
            }
        }
        public Boolean Authenticate(User user) {
            return Tweets.Select(x => x.User).Any(x => x.Login == user.Login && x.Password == user.Password);
        }
    }
}
