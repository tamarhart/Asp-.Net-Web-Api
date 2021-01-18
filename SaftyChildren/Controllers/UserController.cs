﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Dto;

namespace SaftyChildren.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        //    [Route("register")]
        //    public IHttpActionResult Register([FromBody]UsrDto user)
        //    {
        //        bool b = Bl.UserBl.Regiater(user);
        //        if (b == true)
        //            return Ok();
        //        return BadRequest();
        //    }
        [HttpPost]
        [Route("AddUser")]
        public IHttpActionResult AddUser(UsrDto us)
        {
            bool b = Bl.UserBl.AddUser(us);
            if (b)
                return Ok();
            return BadRequest();

        }
        [HttpGet]
        [Route("Getallpropertyd/{id}")]
        public IHttpActionResult Getallpropertyd(string id)
        {
            return Ok(Bl.UserBl.Getallpropertyd(id));
        }
        [HttpPost]
        [Route("UpdateUser")]
        public IHttpActionResult UpdateUser([FromBody] UsrDto us)
        {
            bool b = Bl.UserBl.UpdateUser(us);
            if (b)
                return Ok();
            return BadRequest();
        }

    }
}
