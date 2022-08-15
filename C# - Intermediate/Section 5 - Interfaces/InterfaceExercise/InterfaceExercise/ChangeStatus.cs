namespace InterfaceExercise
{
    public class ChangeStatus : IUpload
    {
        public void Execute()
        {
            System.Console.WriteLine("Status changed to processing");
        }
    }
}
