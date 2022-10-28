//Griffin Parker
//Say Hello - Endpoint
//October 28, 2022
//This program takes two numbers from the user through the URL, adds them together and displays it in the endpoint 
//Peer Review - Kenneth Fujimura - Everything works as intended. The programs adds and subtracts whole integers the way it's supposed to. I really liked how everything was set up to take in ints and arguments so that there's no need to do a string-to-int conversion. Good job Griffin!
//https://localhost:xxxx/Add2Numbers/Add2Numbers/{number1}/{number2}

using Microsoft.AspNetCore.Mvc;

namespace ParkerGSayAdd2NumbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Add2NumbersController : ControllerBase
{
    [HttpGet]
    [Route("Add2Numbers/{number1}/{number2}")]
    public int Add2Numbers(int number1, int number2)
    {
        return number1 + number2;
    } 
}
