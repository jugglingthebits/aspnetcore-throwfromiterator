using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/some")]
    public class AController : ControllerBase
    {
        [HttpGet]
        public IEnumerable Get()
        {
            return ThrowFromIterator();
        }

        public IEnumerable ThrowFromIterator()
        {
            throw new ArgumentException();
            yield break;
        }
    }
}
