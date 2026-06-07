using SQLite;

namespace appProvaA1Caneta.Model
{
    [Table("Caneta")]
    public class Caneta
    {
        [PrimaryKey, AutoIncrement]
        public int canID { get; set; }

        public string canFabricante { get; set; }

        public string canCor { get; set; }
    }
}