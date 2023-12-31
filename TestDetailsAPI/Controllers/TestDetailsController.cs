﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestDetailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDetailsController : ControllerBase
    {
        private readonly ITestDetailsRepostory _tDobj;
        public TestDetailsController()
        {
            _tDobj = new TestDetailsRepostory();
        }
          
        // GET: api/<TestDetailsController>
        [HttpGet]
        public IEnumerable<TestDetail> Get()
        {
            return _tDobj.ReadSP();
        }

        // GET api/<TestDetailsController>/5
        [HttpGet("{id}")]
       /* public TestDetail Get(int id)
        {
            return "value";
        }*/

        // POST api/<TestDetailsController>
        [HttpPost]
        public void Post([FromBody] TestDetail value)
        {
            _tDobj.InsertSP(value);
        }

        // PUT api/<TestDetailsController>/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] TestDetail value)
        {
             _tDobj.UpdateSP(id,value);
        }

        // DELETE api/<TestDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _tDobj.DeleteSP(id);
        }
    }
}
