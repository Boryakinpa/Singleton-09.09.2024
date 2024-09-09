namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            List<Server> servers = new List<Server>();
            Server server = new Server("http://5");
            servers.Add(server);
            for (int i = 0; i < 10; i++)
            {
                server = new Server("http://" + i);
                servers.Add(server);
                if (instance1.AddServer(servers[i]))
                {
                    Console.WriteLine($"Server {servers[i].Adress} has been added");
                }
                else
                {
                    Console.WriteLine($"Error with server {servers[i].Adress}");
                }
            }
        }
    }

    
}