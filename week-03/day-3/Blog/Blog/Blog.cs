using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{
    class Blog
    {
        List<BlogPost> blogPosts = new List<BlogPost>();

        public void Delete(int givenIndex)
        {
            for (int i = givenIndex; i < blogPosts.Count; i++)
            {
                blogPosts.RemoveAt(givenIndex);
            }
        }
        public void PrintOutTheBlog()
        {
            foreach (var item in blogPosts)
            {
                Console.WriteLine($"{item.authorName}, {item.title}, {item.text}, {item.publicationDate}");
            }
        }
        public void Update(int updatePart, BlogPost partToUpdate)
        {
            blogPosts[updatePart] = partToUpdate;
        }
    }
}
