using System;

namespace Inheritance
{
    internal class Post
    {
        private static int currentId;

        protected string userName { get; set; }
        protected int id { get; set; }
        protected string title { get; set; }
        protected bool isPublic { get; set; }

        public Post(string userName, string title, bool isPublic)
        {
            this.userName = userName;
            this.title = title;
            this.id = GetNextId();
            this.isPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentId;
        }

        public void Update(string title, bool isPublic)
        {
            this.title = title;
            this.isPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} ", this.id, this.title, this.userName);
        }
    }
}