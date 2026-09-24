namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class HouseHeadStatusDesc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseHeadStatusId { get; set; }
        public HouseHeadStatus houseHeadStatus { get; set; }
        
    }
}
