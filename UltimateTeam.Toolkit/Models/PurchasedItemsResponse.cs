using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class PurchasedItemsResponse
    {
        public List<int> awardSetIds { get; set; }
        public List<DuplicateItem> DuplicateItemIdList { get; set; }

        public List<ItemData> ItemData { get; set; }
        public string entitlementQuantities { get; set; }
        public List<long> itemIdList;
        public List<ItemData> itemList { get; set; }
        public int numberItems { get; set; }
        public int purchasedPackId { get; set; }
    }
}
