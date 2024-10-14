using System.ComponentModel.DataAnnotations;

namespace RectangleSVG.Models
{
    public class Result
    {
        public bool IsValid { get; set; }
        public string? Message { get; set; }
    }
}
