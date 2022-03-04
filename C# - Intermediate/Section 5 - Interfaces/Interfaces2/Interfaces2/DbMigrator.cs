using System;

namespace Interfaces2
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        
        public DbMigrator(ILogger logger) // Dependancy injection - in the contructor the dependancies is specified
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.LogInfo("Migration Started at {0}" + DateTime.Now);
            
        }
    }
}
