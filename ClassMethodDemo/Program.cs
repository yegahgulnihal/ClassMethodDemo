using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.ClientId = 10001;
            client1.ClientName = "Yegah Gülnihal";
            client1.ClientSurname = "Değirmenci";
            client1.ClientAge = 24;

            Client client2 = new Client();
            client2.ClientId = 10002;
            client2.ClientName = "Muhammed Fatih";
            client2.ClientSurname = "Doğan";
            client2.ClientAge = 26;

            Client client3 = new Client();
            client3.ClientId = 10003;
            client3.ClientName = "Mirza";
            client3.ClientSurname = "Demirci";
            client3.ClientAge = 19;

            Client client4 = new Client();
            client4.ClientId = 10004;
            client4.ClientName = "Gülendam";
            client4.ClientSurname = "Demirci";
            client4.ClientAge = 24;

            Client[] client = new Client[] { client1, client2, client3, client4 };

            foreach (var item in client)
            {                            
                Console.WriteLine(item.ClientName+" "+item.ClientSurname);
                ClientManager clientManager = new ClientManager();
                clientManager.AddClient(item);
                Console.WriteLine("----------------");
            }

            ClientManager clientmanager = new ClientManager();
            clientmanager.DeleteClient(client1);
            Console.WriteLine("--------------------");
            clientmanager.UpgrateClient(client2);
            

        }
    }
}
