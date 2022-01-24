namespace BlueSchedule.Application.Models
{
    public class ItemModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
    }
}