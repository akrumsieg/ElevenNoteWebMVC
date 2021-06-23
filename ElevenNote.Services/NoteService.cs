using ElevenNote.Data;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Services
{
    public class NoteService
    {
        private readonly Guid _userId;
        private ApplicationDbContext _ctx = new ApplicationDbContext();

        public NoteService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateNote(NoteCreate model)
        {
            var entity = new Note()
            {
                OwnerId = _userId,
                Title = model.Title,
                Content = model.Content,
                CreatedUtc = DateTimeOffset.Now
            };
            _ctx.Notes.Add(entity);
            return _ctx.SaveChanges() == 1;
        }

        public IEnumerable<NoteListItem> GetNotes()
        {
            var query = _ctx.Notes.Where(e => e.OwnerId == _userId)
                                  .Select(e => new NoteListItem
                                  {
                                      NoteId = e.NoteId,
                                      Title = e.Title,
                                      CreatedUtc = e.CreatedUtc
                                  });
            return query.ToArray();
        }
    }
}
