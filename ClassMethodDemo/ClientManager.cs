using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
        public void AddClient(Client client)
        {
            Console.WriteLine("Client ID  "+client.ClientId+" added to the database!!" );
        }

        public void DeleteClient(Client client)
        {
            Console.WriteLine(client.ClientName+" "+client.ClientSurname+" has deleted!!");
        }

        public void UpgrateClient(Client client)
        {
            Console.WriteLine(client.ClientName+" "+client.ClientSurname+" has upgrated!!");
        }
    }
}
