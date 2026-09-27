using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class HouseHeadStatusDesc : BaseEntity<int>
    {
        public string Title { get; set; }
        public int HouseHeadStatusId { get; set; }
        public HouseHeadStatus houseHeadStatus { get; set; }
        
    }
}
