namespace Command
{
	class TestCommand
	{
	    
		static void Main(string[] args)
		{
		Console.WriteLine("Command: ");
	        string world = Console.ReadLine();
	        string[] command = world.Split(" ");
		    switch(command[0])
		    {
		        case "date":
		        DateTime fecha = DateTime.Now;
		        Console.WriteLine(fecha);
		        break;
		        case "say":
		        if(command.Count() > 1)
		        {
		            string telling = "";
		            for(int i = 1; i < command.Count(); i++)
		            {
		               telling += command[i] + " ";
		            }
		            Console.WriteLine(telling);
		        } else {
		            Console.WriteLine("A message was not received!");
		        }
		        break;
		        default:
		            Console.WriteLine("Command does not exist!");
		        break;
		    }
		}
	}
}
