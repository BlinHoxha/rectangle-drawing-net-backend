using RectangleSVG.Models;
using System.ComponentModel.DataAnnotations;

namespace RectangleSVG.Services
{
    public interface IRectangleService
    {
        Task<RectangleModel> GetRectangleAsync();
        Task UpdateRectangleAsync(RectangleModel rectangle);
    }
}
