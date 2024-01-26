using TimeTracker1.Domain;

namespace TimeTracker1.Models
{
    public class ClientModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public static ClientModel FromClient(Client client)
        {
            return new ClientModel
            {
                Id = client.Id,
                Name = client.Name
            };
        }
    }
}
