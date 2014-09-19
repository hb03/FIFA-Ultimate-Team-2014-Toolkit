using System.Collections.Generic;

namespace UltimateTeam.Toolkit.Models
{
    public class CardPackResponse
    {
        public string id { get; set; }
        public List<Purchase> purchase { get; set; }
        public int timestamp { get; set; }
    }

    public class Purchase
    {
        public string actionType { get; set; } //: "CREATEPACK"
        public int assetId { get; set; } //: 1
        public int coins { get; set; } //: 400
        public List<Currencies> currencies;
        public string customAttribute { get; set; } //=Featured
        public string dealType { get; set; } //: "REGULAR"
        public string description { get; set; } //: "pickpack description goes here"
        public DisplayGroup displayGroup;
        public int displayGroupAssetId { get; set; } //: 1
        public bool displayGroupUseDefaultImage { get; set; } //: true
        public int fifaCashPrice { get; set; } //75
        public int id { get; set; } //: 100
        public bool isPremium { get; set; } //: false
        public bool isSeasonTicketDiscount { get; set; } //: false
        public int lastPurchasedTime { get; set; } //: 0
        public PackContentInfo packContentInfo;
        public string packType { get; set; } //: "CARDPACK"
        public string productId { get; set; } //: "0"
        public int purchaseCount { get; set; } //: 0
        public int purchaseLimit { get; set; } //: 0
        public string purchaseMethod { get; set; } //: "COIN"
        public int quantity { get; set; } //: -1
        public int saleId { get; set; } //: 0
        public string saleType { get; set; } //: "NONE"
        public int sortPriority { get; set; } //: 0
        public string state { get; set; } //: "active"
        public string type { get; set; } //: "cardpack"
        private bool _unopened;
        public bool unopened {
            get { return _unopened; }
            set { _unopened = value;  }
        } // : false
        public bool useDefaultImage { get; set; } //;
    }

    public class Currencies
    {
        public string name { get; set; }
        public int funds { get; set; }
        public int finalFunds { get; set; }
    }
    public class currencie
    {
        public string name;
        public string value;
    }

    public class DisplayGroup
    {
        public string value { get; set; }
        public int priority { get; set; }
        public int timestamp { get; set; }
    }

    public class PackContentInfo
    {
        public int itemQuantity { get; set; }
        public int goldQuantity { get; set; }
        public int silverQuantity { get; set; }
        public int bronzeQuantity { get; set; }
        public int rareQuantity { get; set; }

    }
}
