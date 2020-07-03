using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter.Entities
{
	public class Tweet
	{
		private User user;
		private String data;
		private String createdAt;

		public User User
		{
			get { return user; }
			set { user = value; }
		}
		public String Data
		{
			get { return data; }
			set { data = value; }
		}
		public String CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}
	}
}
