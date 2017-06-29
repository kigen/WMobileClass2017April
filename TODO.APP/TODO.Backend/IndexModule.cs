using System.Linq;
using Nancy.ModelBinding;
using TODO.Backend.Models;

namespace TODO.Backend
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {

            MyDatabase db = new MyDatabase();
            Get["/"] = parameters =>
            {
                var tasks = db.MyTasks.ToList();
                return Response.AsJson(tasks);
            };

            Post["/"] = parameters =>
            {
                var task = this.Bind<MyTask>();
                db.MyTasks.Add(task);
                db.SaveChanges();
                return Response.AsJson(task);
            };
        }
    }
}