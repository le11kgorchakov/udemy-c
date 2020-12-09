using System;

namespace Inheritance
{
    internal class ImagePost : Post
    {
        protected string url { set; get; }

        public ImagePost(string url) : base(userName, title, isPublic)
        {
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.title, this.url, this.userName);
        }
    }
}