Console.OutputEncoding = System.Text.Encoding.UTF8;

SendMessage(new Message("Hello World"));
SendMessage(new EmailMessage("Bye World"));

// where açar sözündən istifadə edərək genric tipin hansı ola biləcəyini təyin edə bilərik.
void SendMessage<T>(T message) where T : Message
{
    Console.WriteLine($"Məktub göndərilir: {message.Text}");
}


class Message
{
    public string Text { get; }
    public Message(string text)
    {
        Text = text;
    }
}

class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}