namespace BlazorApp1
{
    public class AddressInfo
    {
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public string address1 { get; set; } // 都道府県
        public string address2 { get; set; } // 市区町村
    }
}
