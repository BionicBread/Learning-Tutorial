using System;

namespace Interfaces2
{
    
    public class DbMigrator // this class talks to an interface
    {
        
        private readonly ILogger logger; 
        
        public DbMigrator(ILogger logger) // Dependancy injection - in the contructor the dependancies is specified
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.LogInfo("Migration Started at" + DateTime.Now); // logger interface calls the LogInfo() method from ConsoleLogger  
            
        }
        //public void Mirgrate() // Removed for interface implementation
        //{
        //    Console.WriteLine("Migration started.....at {0}", DateTime.Now);
        //    Console.WriteLine("Migration ended .....at {0}", DateTime.Now);
        //}
    }
}
