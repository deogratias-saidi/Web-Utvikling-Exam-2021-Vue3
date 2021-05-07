using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FindAMusicianAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FindAMusicianAPI.Controller{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("allowAll")]

    public class RequestsController :ControllerBase {
        public readonly FindAMusicianDbContext _context;

        public RequestsController(FindAMusicianDbContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Request>> GetAllRequest(){
             return await _context.Requests.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequestById(int id){
            var request = await _context.Requests.FirstOrDefaultAsync(request => request.Id == id);

            if (request == null)
            {
                return NotFound();
            }
            return request;
        }

        [HttpPut("{id}")]
        public async Task<Request> ChangeRequestById(int id, Request request){
            var _request = await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);
            if(_request != null){
                _request.UserName = request.UserName;
                _request.PhoneNumber = request.PhoneNumber;
                _request.EmailAddress = request.EmailAddress;
                _request.Address = request.Address;
                _request.PostalArea = request.PostalArea;
                _request.Budget = request.Budget;
                _request.RequestDetails = request.RequestDetails;
                _context.SaveChanges();

            }
            return request;
        }

        [HttpPost]
        public async Task<ActionResult<Request>> AddRequest(Request request){

            var now = DateTime.Now; // For å få dato og tid som maskinen brukere
            var _request = new Request(){
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                EmailAddress = request.EmailAddress,
                Address = request.Address,
                DateCreated = now, //bruker variablen now her.
                PostNumber = request.PostNumber,
                PostalArea = request.PostalArea,
                Budget = request.Budget,
                RequestDetails = request.RequestDetails
            };
            _context.Requests.Add(_request);
            await _context.SaveChangesAsync();
            return request;
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id){

           var request = await _context.Requests.FindAsync(id);
           
            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}