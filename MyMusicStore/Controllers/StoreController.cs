using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "hello from store";
        }

        public string Browse()
        {
            return " Browse the strore";
        }

        public string Details()
        {
            return " Details are here";
        }
    }
}
