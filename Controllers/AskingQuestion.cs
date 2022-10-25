//Isaiah Keith Ferguson
//10/25/2022
//Asking Question
//We will get 2 inputs and turn them into a sentence.
//Reviewed by: Madeline Gowan
//Program works as intended. I like the addition of a second question. The response to the gym question is funny, and it works well for any answer.

using Microsoft.AspNetCore.Mvc;

namespace FergusonIAskingQuestionsEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionController : ControllerBase
{
    [HttpGet]
    [Route("Question/{name}/{gym}")]

    public string SayHello(string name, string gym)
    {
        return $"Hi, what is your name? \n{name} \nHello, {name} nice to meet you \nDid you go to the Gym today? \n{gym}\nWow I can tell.";
    }
}