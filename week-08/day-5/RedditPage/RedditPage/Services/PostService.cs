﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditPage.Models;
using RedditPage.Repositories;

namespace RedditPage.Services
{
    public class PostService : IService
    {
        private PostRepository postRepo;
        private UserRepository userRepo;
        public PostService(PostRepository postRepo, UserRepository userRepo)
        {
            this.postRepo = postRepo;
            this.userRepo = userRepo;
        }

        public void CreatPost(Post post)
        {
            postRepo.Create(post);
        }

        public void DecreaseVote(int id)
        {
            var chosenElement = postRepo.Read().FirstOrDefault(p => p.Id == id);
            chosenElement.Votes--;
            postRepo.Update(chosenElement);
        }

        public void IncreaseVote(int id)
        {
            var chosenElement = postRepo.Read().FirstOrDefault(p => p.Id == id);
            chosenElement.Votes++;
            postRepo.Update(chosenElement);
        }

        public void DeletePost(int id)
        {
            postRepo.Delete(id);
        }

        public List<Post> ReadPosts()
        {
            return postRepo.Read();
        }

        public List<Post> SearchPost(string title)
        {
            return postRepo.Search(title);
        }

        public void UpdatePost(Post post)
        {
            postRepo.Update(post);
        }

        public void UpdateUser(User user)
        {
            userRepo.Update(user);
        }

        public List<User> SearchUser(string userName)
        {
            return userRepo.Search(userName);
        }

        public List<User> ReadUsers()
        {
            return userRepo.Read();
        }

        public void DeleteUser(int id)
        {
            userRepo.Delete(id);
        }

        public void CreateUser(User user)
        {
            userRepo.Create(user);
        }
    }
}
