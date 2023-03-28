﻿using Microsoft.AspNet.Identity;
using PhanThanhNhan_2080600532.DTOs;
using PhanThanhNhan_2080600532.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhanThanhNhan_2080600532.Controllers
{
    public class FollowingsController : ApiController
    {       
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");

            var folowing =new Following
            {   
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId,
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}