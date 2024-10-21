//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Earth.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get()=>
            Ok("Hello,Mario the princes is in another castle.");
    }
}
