using ODataAPI.Console;
using ODataAPI.Console.Models;

using ODataHelper helper = new();

string job = "J4GN-00002";

JobOrderModel jo = helper.GetJobOrderByJob(job);

Console.WriteLine($"Job:{jo.value[0].Job}");
Console.WriteLine($"Job:{jo.value[0].Item}");