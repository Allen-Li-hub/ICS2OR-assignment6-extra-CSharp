// Created by: Allen Li
// Created on: Dec 2022
//
// This program displays, "Random Cat Image Generator, API"

using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://api.thecatapi.com/v1/images/search"
        );
        // Console.WriteLine(response);
        var jsonAsDictionary = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        // Console.WriteLine(jsonAsDictionary);
        Console.WriteLine("");
        JsonNode forecastNode = JsonNode.Parse(response)!;
        Console.WriteLine(response);
        Console.WriteLine("\nThis is the random code of cat image, please take a look");
        Console.WriteLine("\n\nDone");
    }
}