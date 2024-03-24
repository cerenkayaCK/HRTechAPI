using System.ComponentModel.DataAnnotations;

namespace HRTechAPI.Entities
{
    public class Adres
    {
        public int Id { get; set; }
        public string Il { get; set; } = null!;
        public string Ilce { get; set; } = null!;
        public string Mahalle { get; set; } = null!;
        public string Sokak { get; set;} = null!;
        public int KapiNo { get; set; }
        public int DaireNo { get; set; }
    }
}
