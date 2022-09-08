using sandbox.Events;

var phone = new Phone();

// the  +=  syntax is used to subscribe a function to an event. This function will run when the event occurs.
// you will need to put 'sender' and 'eventArgs' here because thats what is required.
phone.Call += (sender, eventArgs) =>
{
    Console.WriteLine("Moshi moshi, gaijin des");
};

phone.TextMessage+= (sender, textMessageContent) =>
{
    Console.WriteLine($"oh, i got a new text, it reads: {textMessageContent.Text}");
};


// this activates the events;
phone.OnCall();
phone.OnTextMessage("dinner starts at 8.00pm");

Console.WriteLine();