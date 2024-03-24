using System.ComponentModel.DataAnnotations;

namespace HRTechAPI.Entities
{
    public class Meslek
    {
        public int Id { get; set; }

        public string Ad { get; set; } = null!;
    }
}
