namespace InterfaceExercise
{
    public class SendEmail : IUpload
    {
        public void Execute()
        {
            System.Console.WriteLine("Send email to owner about processing video");
        }
    }
}
