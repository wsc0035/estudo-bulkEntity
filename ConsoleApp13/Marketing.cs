using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp13
{
    [Table("tbMarketing")]
    public class Marketing
    {
        public int Id { get; set; }
        public string AssetID { get; set; } = string.Empty;
        public int TypeID { get; set; }
        public int OfferID { get; set; }
        public decimal Valor { get; set; }
    }
}
