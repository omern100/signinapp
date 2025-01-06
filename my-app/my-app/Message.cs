using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_app
{
    public class Message
    {
        public Person Receiver { get; set; }

        public Person Sender { get; set; }
        public string Body { get; set; }
        public DateTime SentTime { get; set; }

        bool isSeen { get; set; }
        public Message(Person sender, string body, Person receiver)
        {
            Sender = sender;
            Body = body;
            SentTime = DateTime.Now;
            Receiver = receiver;
            isSeen = false;
        }
        public static List<Message> GetMessagesForPerson(List<Message> messages, Person person)
        {
            return messages.Where(m => m.Sender == person || m.Receiver == person).ToList();
        }

        public override string ToString()
        {
            return $"{Sender.Username}: {Body} (Sent on {SentTime})";
        }
    }
}
