namespace CasgemMicroservice.Services.Payment.WebApi.Dal
{
    public class PaymetDetail
    {
        public int PaymetDetailID { get; set; }
        public string CardNumber { get; set; }
        public string CustomerNameSurname { get; set; }
        public decimal Price { get; set; }
        public string PaymetStatus { get; set; }
    }
}
