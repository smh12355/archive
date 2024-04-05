
class Message<T>
{
    public static T? Testik; 
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base("oleg") 
    { 
        
    }
}
class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) 
    { }
}
class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}