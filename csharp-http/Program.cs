using System.Threading;
using System.Net.Http;

var http = new HttpClient();
http.GetAsync("http://localhost:8080");

for (int i = 0; i < 25; i++)
{
    http.GetAsync("http://example.org");
}

Thread.Sleep(1000);

http.GetAsync("http://localhost:8080");