using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ContactoBackEnd.Models;

namespace ContactoBackEnd.Controllers
{
    [RoutePrefix("sectorApi")]
    public class SectorApiController : ApiController
    {
        private EmpresaDB db = new EmpresaDB();

        // GET: api/SectorApi
        public IQueryable<Sector> GetSector()
        {
            return db.Sector;
        }

        
        // GET: api/SectorApi/5
        [ResponseType(typeof(Sector))]
        public async Task<IHttpActionResult> GetSector(int id)
        {
            Sector sector = await db.Sector.FindAsync(id);
            if (sector == null)
            {
                return NotFound();
            }

            return Ok(sector);
        }

        // PUT: api/SectorApi/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutSector(int id, Sector sector)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != sector.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(sector).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SectorExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/SectorApi

        [Route("sectorApi/post")]
        [ResponseType(typeof(Sector))]
        public async Task<IHttpActionResult> PostSector(Sector sector)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sector.Add(sector);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SectorExists(sector.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sector.Id }, sector);
        }

        // DELETE: api/SectorApi/5
        //[ResponseType(typeof(Sector))]
        //public async Task<IHttpActionResult> DeleteSector(int id)
        //{
        //    Sector sector = await db.Sector.FindAsync(id);
        //    if (sector == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Sector.Remove(sector);
        //    await db.SaveChangesAsync();

        //    return Ok(sector);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SectorExists(int id)
        {
            return db.Sector.Count(e => e.Id == id) > 0;
        }
    }
}