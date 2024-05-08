// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

var process = new Process();

process.StartInfo.FileName = "gh";
//process.StartInfo.ArgumentList.Add("""<img alt="ScrumPoker" title="#ScrumPoker" src="./prints/web/home.png" width="400px">""");
var argumentos = new List<string>()
{
    "search repos",
    "--archived=false",
    "--limit=1000",
    "--include-forks=false",
    "--owner=brunoritter123",
    "--json=fullName,defaultBranch"
    //"--json=createdAt,defaultBranch,description,forksCount,fullName,hasDownloads,hasIssues,hasPages,hasProjects,hasWiki,homepage,id,isArchived,isDisabled,isFork,isPrivate,language,license,name,openIssuesCount,owner,pushedAt,size,stargazersCount,updatedAt,url,visibility,watchersCount"
};
process.StartInfo.Arguments = string.Join(" ", argumentos);
process.StartInfo.UseShellExecute = false;
process.StartInfo.RedirectStandardOutput = true;
//process.StartInfo.RedirectStandardError = true;

process.Start();

string output = process.StandardOutput.ReadToEnd();
//string error = process.StandardError.ReadToEnd();
process.WaitForExit();

Console.WriteLine(output);
//Console.WriteLine(error);

//using System.Collections.Specialized;
//using System.Web;

//var client = new HttpClient();
//var uri = new UriBuilder("https://api.github.com/search/issues");
//NameValueCollection query = HttpUtility.ParseQueryString(uri.Query);
//query["q"] = "windows label:bug \\  language:python state:open";
//uri.Query = query.ToString();


//var request = new HttpRequestMessage
//{
//    Method = HttpMethod.Get,
//    RequestUri = uri.Uri,
//    Headers =
//    {
//        { "Accept", "application/vnd.github.text-match+json" },
//    },
//};
//using (var response = await client.SendAsync(request))
//{
//    response.EnsureSuccessStatusCode();
//    var body = await response.Content.ReadAsStringAsync();
//    Console.WriteLine(body);
//}


//using System.Diagnostics;

//var process = new Process();

//process.StartInfo.FileName = "gh";
////process.StartInfo.ArgumentList.Add("""<img alt="ScrumPoker" title="#ScrumPoker" src="./prints/web/home.png" width="400px">""");
//var argumentos = new List<string>()
//{
//    "search code",
//    "ScrumPoker",
//    "--owner=brunoritter123",
//    "--filename=README.md",
//    "--limit=1000",
//    "--json path",
//    "--json repository",
//    "--json sha",
//    "--json textMatches",
//    "--json url"
//};
//process.StartInfo.Arguments = string.Join(" ", argumentos);
//process.StartInfo.UseShellExecute = false;
//process.StartInfo.RedirectStandardOutput = true;
////process.StartInfo.RedirectStandardError = true;

//process.Start();

//string output = process.StandardOutput.ReadToEnd();
////string error = process.StandardError.ReadToEnd();
//process.WaitForExit();

//Console.WriteLine(output);
////Console.WriteLine(error);