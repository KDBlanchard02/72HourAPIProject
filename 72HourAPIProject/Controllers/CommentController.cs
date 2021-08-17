using _72HourAPIProject.Data;
using _72HourAPIProject.Models;
using _72HourAPIProject.Services;
using Microsoft.AspNet.Identity;
using SeventyTwoHourAPIProject.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _72HourAPIProject.Controllers
{
    public class CommentController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var commentService = new CommentService(userId);
            return commentService;
        }

        [HttpPost]
        public IHttpActionResult Post(CommentCreate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(model)) return InternalServerError();

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            CommentService commentService = CreateCommentService();
            var comment = commentService.GetCommentByPostId(id);
            return Ok();
        }
    }
}
