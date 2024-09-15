using Microsoft.AspNetCore.Mvc;
using Portfolio_MVC.Models;

namespace Portfolio_MVC.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var articles = new List<Article>
			{
				new Article(1, "5 پترنی که در ASP.Net Core باید از آن اطلاع داشته باشید!","در زبان برنامه نویسی سی شارپ پترن های زیادی وجود دارد اما شما باید از این پنج تا اطلاع داشته باشید","blog-post-thumb-1.jpg"),
				new Article(1, "2 پترنی که در React باید از آن اطلاع داشته باشید!","در زبان برنامه نویسی جاوااسکریپت پترن های زیادی وجود دارد اما شما باید از این پنج تا اطلاع داشته باشید","blog-post-thumb-2.jpg"),

			};

			return View("_Articles", articles);
		}

	}
}
