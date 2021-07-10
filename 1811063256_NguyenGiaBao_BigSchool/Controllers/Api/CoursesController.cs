﻿using _1811063256_NguyenGiaBao_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _1811063256_NguyenGiaBao_BigSchool.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpDelete]
        // GET: Courses
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);
            if (course.IsCanceled)
                return NotFound();
            course.IsCanceled = true;
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}