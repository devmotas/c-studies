﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPost.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        { }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes + " Likes - ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Content);

            if (Comments.Count > 0)
            {
                sb.AppendLine("Comments:");
                foreach (var item in Comments)
                {
                    sb.AppendLine(item.Text);
                }
            }
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
