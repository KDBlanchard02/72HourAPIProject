using _72HourAPIProject.Data;
using _72HourAPIProject.Models;
using SeventyTwoHourAPIProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourAPIProject.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    AuthorId = _userId,
                    Text = model.Text,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ReplyListItem> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Replies
                        .Where(e => e.AuthorId == _userId)
                        .Select(
                         e =>
                                new ReplyListItem
                                { 
                                    ReplyId = e.ReplyId,
                                    Text = e.Text,
                                    //CreatedUtc = e.CreatedUtc
                                }
                         );
                return query.ToArray();
            }
        }
    }
}
