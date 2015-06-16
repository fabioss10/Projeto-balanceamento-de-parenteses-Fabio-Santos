using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fabio_Santos.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult CheckString()
        {
            String str = Request["str"];
            return Content("<b>" + balanceamentoParenteses(str) + "</b>");
        }

        [NonAction]
        private bool balanceamentoParenteses(String str)
        {
            bool c = false;
            int i = 0;
            int contAbre = 0;
            int contFecha = 0;
            bool procuraFecha = false;
            foreach (char value in str)
            {
                if (value.Equals('('))
                {
                    String palavra = str.Substring(i + 1, str.Length-(i+1));
                    procuraFecha = true;
                    c = balanceamentoParenteses(palavra);
                    //break;
                    contAbre++;
                    
                }
                else if (value.Equals(')')&&procuraFecha==true)
                {
                    contFecha++;
                    procuraFecha = false;
                    //return true;
                }
                i++;

            }



            if (contAbre == contFecha)
            {
                return true;
            }
            else {
                return false;
            }
            
        }
    }
}
