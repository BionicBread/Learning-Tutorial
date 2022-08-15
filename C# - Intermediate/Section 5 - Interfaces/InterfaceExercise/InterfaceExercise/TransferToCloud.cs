using System;

namespace InterfaceExercise
{
    public class TransferToCloud : IUpload
    {
        public void Execute()
        {
            Console.WriteLine("Transfer to cloud storage complete");
        }
    }
}
