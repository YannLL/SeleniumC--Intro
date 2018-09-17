using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        //Chrome driver not working on this machine
        //IWebDriver driver = new ChromeDriver();

        /* 
         
        //=== BASICS ===
        
        //IWebDriver driver = new FirefoxDriver();
        //driver.Navigate().GoToUrl("https://www.abasiguitars.com");

        //Sleep - waits for specified milliseconds before moving on to next step
        Thread.Sleep(5000);

        //Quit test - close browser
        driver.Quit();

        */

        // === FIND ELEMENT BY NAME ===
        /*
        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement bar = driver.FindElement(By.Name("myName"));

        if (bar.Displayed)
        {
            Console.WriteLine("Element visible and spotted!");
            
            //BONUS - WITH COLOUR FORMATTED TEXT
            GreenMessage("Element visible and spotted!");
        }
        else
        {
            Console.WriteLine("Element not found:(");
            
            //BONUS - WITH COLOUR FORMATTED TEXT
            RedMessage("Element visible and spotted!");
        }

        Thread.Sleep(1500);
        driver.Quit();
    */

        /*
         // ==== SELECT ELEMENT BY ID

            string url = "http://testing.todorvachev.com/selectors/id/";
            string id = "testImage";

            IWebDriver fox = new FirefoxDriver();

            fox.Navigate().GoToUrl(url);

            IWebElement something = fox.FindElement(By.Id(id));

            if (something.Displayed)
            {
                GreenMessage("Element exists!");
            }
            else
            {
                RedMessage("Element not found :(");
            }

            fox.Quit();
            */



        // === SELECT ELEMENT BY CLASS NAME

        IWebDriver driver = new FirefoxDriver();

        string classname = "testClass";
        string url = "http://testing.todorvachev.com/selectors/class-name/";
        driver.Navigate().GoToUrl(url);

        IWebElement paragraph = driver.FindElement(By.ClassName(classname));

        if (paragraph.Displayed)
        {
            GreenMessage("Element found by class name!");
        }
        else
        {
            RedMessage("Element NOT found by class name :(");
        }

        driver.Quit();
    }

    //=== CMD LINE MESSAGE STYLING
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}