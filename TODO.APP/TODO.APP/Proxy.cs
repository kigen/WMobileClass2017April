using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PortableRest;

namespace TODO.APP
{
   public class Proxy
    {

       public static async Task<MyTask> PostTask(MyTask task)
       {
           RestClient client  = new RestClient();
           client.BaseUrl = "http://tudoo.azurewebsites.net";
           RestRequest request = new RestRequest("/",HttpMethod.Post);
           request.AddParameter(task);
           return await client.ExecuteAsync<MyTask>(request);
      }


       public static async Task<List<MyTask>> FetchTasks()
       {
           RestClient client = new RestClient();
           client.BaseUrl = "http://tudoo.azurewebsites.net";
           RestRequest request = new RestRequest("/", HttpMethod.Get);
           return await client.ExecuteAsync<List<MyTask>>(request);
       }
    }
}
