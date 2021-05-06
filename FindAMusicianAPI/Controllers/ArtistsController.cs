using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FindAMusicianAPI.Controller{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("allowAll")]

    public class ArtistsController :ControllerBase {
        public readonly FindAMusicianDbContext _context;
        private readonly IWebHostEnvironment _hosting;

        public ArtistsController(FindAMusicianDbContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
            
        }

        [HttpGet]
        public async Task<IEnumerable<Artist>> GetAllArtist(){
             return await _context.Artists.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtistById(int id){
            var artist = await _context.Artists.FirstOrDefaultAsync(a => a.Id == id);

            if (artist == null)
            {
                return NotFound();
            }
            return artist;
        }

        [HttpPut("{id}")]
        public async Task<Artist> ChangeArtistById(int id, Artist artist){
            var _artist = await _context.Artists.FirstOrDefaultAsync(a => a.Id == id);
            if(_artist != null){
                _artist.ArtistName = artist.ArtistName;
                _artist.Contact = artist.Contact;
                _artist.Price = artist.Price;
                _artist.Genre = artist.Genre;
                _artist.Image = artist.Image;
                _artist.Description = artist.Description;
                _context.SaveChanges();

            }
            return artist;
        }

        [HttpPost]
        public async Task<ActionResult<Artist>> AddArtist(Artist artist){

            var _artist = new Artist(){
                ArtistName = artist.ArtistName,
                Contact = artist.Contact,
                Price = artist.Price,
                Genre = artist.Genre,
                Image = artist.Image,
                Description = artist.Description,
                
            };
            _context.Artists.Add(_artist);
            await _context.SaveChangesAsync();
            return artist;
            
        }

        [HttpPost]
        [Route("[action]")]
        public void UploadImage(IFormFile file){
            string webRootPath = _hosting.WebRootPath;
            string absolutePath = Path.Combine($"{webRootPath}/images/{file.FileName}");
            using(var fileStream = new FileStream(absolutePath, FileMode.Create)){
                file.CopyTo(fileStream);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id){

           var _artist = await _context.Artists.FindAsync(id);
           
            _context.Artists.Remove(_artist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}