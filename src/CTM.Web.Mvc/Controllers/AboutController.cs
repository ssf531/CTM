using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CTM.Controllers;

namespace CTM.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : CTMControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
