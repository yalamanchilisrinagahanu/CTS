namespace KafkaChatApp.Models
{
    public class ChatMessage
    {
        public string User { get; set; } = "";

        public string Message { get; set; } = "";

        public DateTime Time { get; set; } = DateTime.Now;
    }
}
