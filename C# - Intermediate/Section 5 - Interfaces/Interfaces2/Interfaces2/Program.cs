namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //extensibility mechanism allows changing the behaviour of a class by writing more classes

            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger()); // new ConsoleLogger is the concrete class of ILogger. ILogger contains the method used in ConsoleLogger
            dbMigrator.Migrate();

            DbMigrator dbMigrator2 = new DbMigrator(new FileLogger(@"C:\test\log.txt")); // we can change the implementation of ConsoleLogger by simply changing to FileLogger class
            dbMigrator.Migrate();

            // Open Close Principle (OCP) - software entities should be Opened for extentions but Closed for modification 
            // This is extensibilty 
        }
    }
}
