namespace eShop.Entities.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDescription { get; set; }
    }
}