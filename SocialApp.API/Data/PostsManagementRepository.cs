using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public class PostsManagementRepository : IPostsManagementRepository
    {
        private readonly DataContext _context;
        public PostsManagementRepository(DataContext context)
        {
            _context = context;

        }
        
    }
}