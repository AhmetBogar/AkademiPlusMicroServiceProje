namespace AkademiPlusMicroServiceProje.Frontend.Models
{
    public class ServiceApiSettings
    {
        public string IdentityBaseUrl { get; set; }
        public string PhotoStockUrl { get; set; }
        public string GatewayBaseUrl { get; set; }
        public ServiceApi Catalog { get; set; }
        public ServiceApi Basket { get; set; }
        public ServiceApi PhotoStock { get; set; }
        public ServiceApi Order { get; set; }
        public ServiceApi Discount { get; set; }

        public class ServiceApi
        {
            public string Path { get; set; }
        }
    }
}
