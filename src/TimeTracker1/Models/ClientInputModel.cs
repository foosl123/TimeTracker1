using TimeTracker1.Domain;

namespace TimeTracker1.Models
{
    public class ClientInputModel
    {
        public string Name { get; set; }

        public void MapTo(Client client)
        {
            client.Name = Name;
        }
    }
}
