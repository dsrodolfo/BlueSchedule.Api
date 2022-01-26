namespace BlueSchedule.Application.Models
{
    public class GenericModel
    {
        public GenericModel(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}