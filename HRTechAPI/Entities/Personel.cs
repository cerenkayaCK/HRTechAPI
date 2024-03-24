
namespace HRTechAPI.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string FotografYolu { get; set; } = null!;

 
        public string Ad { get; set; } = null!;

        public string? Ad2 { get; set; }

        public string Soyad { get; set; } = null!;

        public string? Soyad2 { get; set; }

 
        public DateTime DogumTarihi { get; set; }
    
        public string TcNo { get; set; } = null!;

        public DateTime IseGirisTarihi { get; set; }

        public DateTime? IstenCikisTarihi { get; set; }
        public bool Aktiflik {  get; set; }
        public int MeslekId { get; set; }        
        public Meslek Meslek { get; set; } = null!;
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; } = null!;
        public int SirketId { get; set; }
        public Sirket Sirket { get; set; } = null!;


        public string Email { get; set; } = null!;
        public Adres Adres { get; set; } = null!;

        public int AdresId { get; set; }


        public string Telefon { get; set; } = null!;


        public decimal Maas { get; set; }
    }
}
