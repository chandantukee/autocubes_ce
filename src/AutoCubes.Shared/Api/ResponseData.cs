namespace AutoCubes.Shared.Api
{
    public class ResponseData
    {
        public List<Message> Messages { get; set; }
        public object Data { get; set; }
    }

    public class Message
    {
        public string MessageText { get; set; }
        public string MessageType { get; set; }
    }
}
