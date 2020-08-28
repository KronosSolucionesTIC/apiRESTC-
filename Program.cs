using System;
using System.Net;
using Newtonsoft.Json;

namespace ejemploconsume
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "http://localhost/apiRESTPHP/restApiPHP/api/handler.php";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
            //Console.WriteLine(json);
            foreach(var i in m){
                Console.WriteLine(i.nombre);
                Console.Read();
            }
        }
    }
}
