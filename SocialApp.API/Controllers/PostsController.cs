using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialApp.API.Data;
using SocialApp.API.Models;

namespace SocialApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly DbContext _context;
        private readonly IPostsManagementRepository _repo;
        private readonly IMapper _mapper;

        public PostsController(DbContext context,IPostsManagementRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _repo = repo;
        }
        
    }
}