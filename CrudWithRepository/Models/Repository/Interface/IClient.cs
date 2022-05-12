using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithRepository.Models.Repository.Interface
{
    public interface IClient
    {
        List<Client> ClientList();
        Client GetClientById(int Id);
        Client CreateClientRecord(Client client);
        Client UpdateClientRecord(Client client);
        Client DeleteClientRecord(int Id);
    }
}
