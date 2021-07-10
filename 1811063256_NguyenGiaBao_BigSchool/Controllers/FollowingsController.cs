using _1811063256_NguyenGiaBao_BigSchool.DTOs;
using _1811063256_NguyenGiaBao_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace _1811063256_NguyenGiaBao_BigSchool.Controllers
{
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FollowerId == followingDto.FolloweeId))
                return BadRequest("The Following already exists!");
            var folowing = new Following
            {
                FolloweeId = userId,
                FollowerId = followingDto.FolloweeId
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}