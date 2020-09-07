using EPiServer.ServiceLocation;
using EPiServer.Shell.Security;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Alloy.Controllers
{
    public class DebugController : Controller
    {
        public ActionResult ThrowError()
        {
            throw new ApplicationException("This is a test exception");
        }

        // This allows us to set-up an initial admin user.  On initial site launch,
        // visit /debug/createuser to create an admin account with the credentials below.
        [HttpGet]
        public ActionResult CreateUser()
        {
            string username = "johnp"; string password = "Aaaaa1!"; string email = "john+test3@blendinteractive.com";

            if (!Request.IsLocal)
                return HttpNotFound();
            var userProvider = ServiceLocator.Current.GetInstance<UIUserProvider>();
            userProvider.CreateUser(username, password, email, null, null, true, out UIUserCreateStatus status, out IEnumerable<string> errors);
            if (status != UIUserCreateStatus.Success)
                throw new InvalidOperationException(string.Join("\r\n", errors));
            var roleProvider = ServiceLocator.Current.GetInstance<UIRoleProvider>();
            roleProvider.CreateRole("WebAdmins");
            roleProvider.AddUserToRoles("admin", new string[] { "WebAdmins" });
            return Content("OK");
        }
    }
}