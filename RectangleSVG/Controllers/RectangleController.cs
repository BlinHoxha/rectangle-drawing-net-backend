using Microsoft.AspNetCore.Mvc;
using RectangleSVG.Models;
using RectangleSVG.Services;

[ApiController]
[Route("api/[controller]")]
public class RectangleController : ControllerBase
{
    private readonly IRectangleService _rectangleService;

    public RectangleController(IRectangleService rectangleService)
    {
        _rectangleService = rectangleService;
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetRectangle()
    {
        var rectangle = await _rectangleService.GetRectangleAsync();
        return Ok(rectangle);
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateRectangle([FromBody] RectangleModel rectangle)
    {
        try
        {
            await _rectangleService.UpdateRectangleAsync(rectangle);
            return Ok("Rectangle updated successfully.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred: " + ex.Message);
        }
    }

}
