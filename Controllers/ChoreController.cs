namespace Chore_Score.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoreController : ControllerBase
{
    private readonly ChoreService _choreService;

    public ChoreController(ChoreService choreService)
    {
        _choreService = choreService;
    }

    [HttpGet("test")]
    public ActionResult<string> TestApi()
    {
        try
        {
            return Ok("API is running");
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpGet]
    public ActionResult<List<Chore>> getChores()
    {
        try
        {
            List<Chore> chores = _choreService.GetChores();
            return Ok(chores);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore data)
    {
        try
        {
            Chore chore = _choreService.CreateChore(data);
            return Ok(chore);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

}

