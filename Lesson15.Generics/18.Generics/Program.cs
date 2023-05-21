Console.OutputEncoding = System.Text.Encoding.UTF8;

Messenger<Message, Person> telegram = new Messenger<Message, Person>();
Person tom = new Person("Tom");
Person bob = new Person("Bob");
Message hello = new Message("Hello, Bob!");
telegram.SendMessage(tom, bob, hello);

class Messenger<T, P> where T : Message where P : Person
{
    public void SendMessage(P sender, P receiver, T message)
    {
        Console.WriteLine($"Göndərən: {sender.Name}");
        Console.WriteLine($"Alan: {receiver.Name}");
        Console.WriteLine($"Məktub: {message.Text}");
    }
}
class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
}