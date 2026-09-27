using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class HouseHeadStatus : BaseEntity<int>
    {
        public string Title { get; set; }
        public List<HouseHeadStatusDesc> houseHeadStatusDescs { get; set; }
    }
}