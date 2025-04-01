using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteTakingAppAPI.Data;
using NoteTakingAppAPI.Model;

namespace NoteTakingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly APİDatabaseContent _context;

        public NoteController( APİDatabaseContent context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult NoteList() 
        {
            var noteList = _context.Notes.ToList();
            if (noteList.Count == 0)
            {
                return Ok("Şuanda aktif not bulunamadı.");
            }
            return Ok(noteList);
        }

        [HttpPost("CreateNote")]
        public IActionResult CreateNote([FromBody]Note note) 
        {
           var createNote = _context.Notes.Add(note);
            if (createNote == null)
            {
                return Ok("Hata! Ekleme İşleminde bir sorun oldu.");
            }
            _context.SaveChanges();
            return Ok("Not başarıyla eklendi.");
        }

        [HttpPut("UpdateNote")]
        public IActionResult UpdateNote([FromBody] Note note) 
        {
            var updateNote =  _context.Notes.SingleOrDefault(x => x.Id == note.Id);
            if (updateNote == null)
            {
                return Ok("HATA ! Güncellenecek Not bulunamadı.");
            }

            updateNote.Title = note.Title;
            updateNote.Content = note.Content;
            _context.SaveChanges();
            return Ok("Güncelleme İşlemi Başarıyla Gerçekleştirildi.");
        }

        [HttpDelete("DeleteNote")]
        public IActionResult DeleteNote( int Id) 
        {
            var selectedDeleteNote = _context.Notes.SingleOrDefault(x => x.Id == Id);
            if (selectedDeleteNote == null)
            {
                return Ok("HATA ! Silinecek Not bulunamadı.");
            }
            _context.Notes.Remove(selectedDeleteNote);
            _context.SaveChanges();
            return Ok("Silme İşlemi Başarıyla Gerçekleştirildi.");
        }

        [HttpGet("GetNote")]
        public IActionResult SelectedNote(int Id) 
        {
            var selectedNote = _context.Notes.SingleOrDefault(x => x.Id == Id);
            if (selectedNote == null)
            {
                return Ok("Girilen Id'e ait Not Bulunamadı.");
            }
            return Ok(selectedNote);
        }
    }
}
