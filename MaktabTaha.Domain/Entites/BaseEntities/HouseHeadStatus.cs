namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class HouseHeadStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<HouseHeadStatusDesc> houseHeadStatusDescs { get; set; }
    }
}