using System;
using System.Net;
using System.Diagnostics;
/* 04. Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores 
 * it the current directory. Find in Google how to download 
 * files in C#. Be sure to catch all exceptions and to free 
 * any used resources in the finally block.*/


namespace _04.Downloader
{
    class Downloader
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);      

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(
                        "http://www.devbg.org/img/Logo-BASD.jpg", desktop + "\\logo.jpg");
                    Process.Start(desktop + "\\logo.jpg");
                }

                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid.");
                }

                catch (NotSupportedException)
                {
                    Console.Error.WriteLine(
                        "The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}
