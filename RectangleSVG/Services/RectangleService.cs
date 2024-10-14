using Newtonsoft.Json;
using RectangleSVG.Models;
using RectangleSVG.Services;
using System.Threading.Tasks;

public class RectangleService : IRectangleService
{
    private readonly string _filePath = "rectangle.json";  // Assuming you store data in a JSON file.

    // Get rectangle dimensions from JSON
    public async Task<RectangleModel> GetRectangleAsync()
    {
        if (!File.Exists(_filePath))
        {
            return new RectangleModel { Width = 100, Height = 50 }; // Default values if file does not exist
        }

        var json = await File.ReadAllTextAsync(_filePath);
        var rectangle = JsonConvert.DeserializeObject<RectangleModel>(json);

        // Calculate perimeter dynamically
        rectangle!.Perimeter = 2 * (rectangle.Width + rectangle.Height);

        return rectangle;
    }

    // Update rectangle dimensions and perform validation
    public async Task UpdateRectangleAsync(RectangleModel rectangle)
    {
        // Simulate a 10-second delay to mimic long-running validation
        await Task.Delay(10000); 

        // Perform validation before updating
        if (rectangle.Width > rectangle.Height)
        {
            throw new ArgumentException("Validation failed: Width cannot exceed height.");
        }

        // Proceed with updating if validation passes
        var json = JsonConvert.SerializeObject(rectangle);
        await File.WriteAllTextAsync(_filePath, json);
    }
}
