using System;
using System.IO;
using System.Net.Http;

namespace Download_FIle_From_URL
{
    class Program
    {
        //ToDo fix this program.
        async static void DownloadFile(HttpClient client, string url, string outputPath)
        {
            try
            {
                if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
                {
                    throw new InvalidOperationException("URI is invalid.");
                }
                if (!File.Exists(outputPath))
                {
                    throw new FileNotFoundException("Destination file not found.");
                }
                string responseBody = await client.GetStringAsync(url);
                Console.WriteLine(responseBody);
                byte[] fileBytes = await client.GetByteArrayAsync(uri);

                //File.WriteAllBytes(outputPath, fileBytes);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL:");
            var url = Console.ReadLine();
            var outputPath = @"C:\Users\gergi\Source\Repos\g3rg1\CSharp-Principles-Problems\Download FIle From URL\Download folder\DownloadedPage.html";
            var client = new HttpClient();
            DownloadFile(client, url, outputPath);
            var text = File.ReadAllText(outputPath);
            Console.WriteLine(text);
        }
    }
}
