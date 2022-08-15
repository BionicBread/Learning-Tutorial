using System.Collections.Generic;
using System;

namespace InterfaceExercise
{
    public class WorkFlowList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class WorkFlowEngine
    {
        
        public void Run(IUpload input)
        {
            input.Execute();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var FlowList = new WorkFlowEngine();

            //FlowList.Run(new CallWebService());

            //var workFlowList = new WorkFlowList<IUpload>();

            //workFlowList.Add(new TransferToCloud());
            //workFlowList.Add(new CallWebService());
            //workFlowList.Add(new SendEmail());
            //workFlowList.Add(new ChangeStatus());

            //foreach(IUpload item in workFlowList)

            List<IUpload> workFlowList = new List<IUpload>();
            workFlowList.Add(new TransferToCloud());
            workFlowList.Add(new CallWebService());
            workFlowList.Add(new SendEmail());
            workFlowList.Add(new ChangeStatus());

            foreach (IUpload item in workFlowList)
            {
                WorkFlowEngine start = new WorkFlowEngine();
                start.Run(item);
            }
        }
    }
}
