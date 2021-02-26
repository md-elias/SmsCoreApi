using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmsCoreApi.DAL.Interfaces;
using SmsCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsCoreApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IRepository<Subject> _repo;

        public SubjectController(IRepository<Subject> repository)
        {
            _repo = repository;
        }

        [HttpGet]
        [Route("GetSubjects")]
        public async Task<IActionResult> Get()
        {
            var subject = await _repo.Get();
            return Ok(subject);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var subject = await _repo.Get(id);
            if (subject == null)
            {
                return Content("Can not find the subject");
            }
            return Ok(subject);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Subject model)
        {
            await _repo.Post(model);
            return Ok(model);
        }

        [HttpPut, Route("UpdateSubject/{id}")]
        public async Task<IActionResult> Put(int id, Subject model)
        {
            await _repo.Put(id, model);
            return Ok(model);
        }

        [HttpDelete, Route("DeleteSubject/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _repo.Delete(id);
            if (data != null)
            {
                return RedirectToRoute("GetSubjects");
            }
            return Content("The Subject you want to delete is not exist.");
        }
    }
}