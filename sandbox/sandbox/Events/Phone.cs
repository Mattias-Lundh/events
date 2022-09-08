using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox.Events
{
    public class Phone
    {
        public event EventHandler Call;
        public event EventHandler<TextMessageContent> TextMessage;


        // a very simple event being broadcasted to all subscribers
        public void OnCall()
        {
            Call.Invoke(this, EventArgs.Empty);
        }

        // an event containing a parameter being broadcasted to all subscribers
        public void OnTextMessage(string text)
        {
            var message = new TextMessageContent();
            message.Text = text;

            TextMessage.Invoke(this, message);
        }
    }
}
