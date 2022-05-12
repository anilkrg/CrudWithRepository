using CrudWithRepository.Models.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithRepository.Models.Repository.Services
{
    public class Clientservices : IClient
    {
        private ApplicationDbContext dbContext;
        public Clientservices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Client> ClientList()
        {
            var cli = dbContext.Clients.ToList();
            return cli;
        }

        public Client CreateClientRecord(Client client)
        {
            throw new NotImplementedException();
        }

        public Client DeleteClientRecord(int Id)
        {
            throw new NotImplementedException();
        }

        public Client GetClientById(int Id)
        {
            throw new NotImplementedException();
        }

        public Client UpdateClientRecord(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
