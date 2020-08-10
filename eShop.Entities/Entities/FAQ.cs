namespace eShop.Entities.Entities
{
    public class FAQ
    {
        public int FAQId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}