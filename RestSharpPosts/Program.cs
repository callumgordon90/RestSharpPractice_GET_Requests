﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace RestSharpPosts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This is the endpoint, saved in an object called 'url'.
            string url = "https://jsonplaceholder.typicode.com/posts";

            //The client is the entity which launches the request to the external API. Here the object 'client' is an instance of the
            //class 'RestClient', and takes the destination enpoint (url) as a parameter to the method.
            var client = new RestClient (url);

            //The object 'request' is an instance of the 'RestRequest' class.
            var request = new RestRequest ();

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
