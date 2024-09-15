using Microsoft.AspNetCore.Mvc;
using Portfolio_MVC.Models;

namespace Portfolio_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg", "Snapp"),
				new Project(1, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg", "Snapp"),
				new Project(1, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg", "MONOP"),
				new Project(1, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "project-4.jpg", "NASA"),
			};
			return View("_Projects", projects);
		}
	}
}
