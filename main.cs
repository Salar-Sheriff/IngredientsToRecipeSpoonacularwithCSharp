using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Threading.Tasks;

namespace GettingRecipesByIngredientSpoonacularAPI
{
    class MainClass
    {
        public async static Task Main(string[] args)
        {

            //http://zetcode.com/csharp/httpclient/

            //https://api.spoonacular.com/recipes/findByIngredients?ingredients=milk,+eggs,+sugar&number=10000&apiKey=1961c69d5a7f4e23aaa6781533acaa98


            //Create New HTTP CLIENT
            HttpClient client = new HttpClient();



            //This is the first part of the get recipe by ingredients URL
            string urlPart1 = "https://api.spoonacular.com/recipes/findByIngredients?ingredients=";


            //This List stores the recipes you have
            List<string> ingredients = new List<string> { "chocolate", "sugar", "milk"};

            string urlPart2 = ingredients[0];

            for (int i = 1; i < ingredients.Count; i++)
            {
                urlPart2 += ",+" + ingredients[i];


               
            }


            string urlPart3 = "&number=10000&apiKey=1961c69d5a7f4e23aaa6781533acaa98";



            string completeUrl = urlPart1 + urlPart2 + urlPart3;

            //Get Headers
            //var result = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, completeUrl));


            var result = await client.GetAsync(completeUrl);

            Console.WriteLine(await result.Content.ReadAsStringAsync());

        }


        

    }
}
