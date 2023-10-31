namespace BlazorApp1
{
    public class AddressInfo
    {
        public List<Result> results { get; set; }
        public int status { get; set; }
        public string message { get; set; }
    }

    public class Result
    {
        public string address1 { get; set; } // 都道府県
        public string address2 { get; set; } // 市区町村
        public string address3 { get; set; } // 住所
        public string kana1 { get; set; }   // ひらがな・カタカナの都道府県名
        public string kana2 { get; set; }   // ひらがな・カタカナの市区町村名
        public string kana3 { get; set; }   // ひらがな・カタカナの住所名
        public string prefcode { get; set; } // 都道府県コード
        public string zipcode { get; set; }  // 郵便番号
    }
}
