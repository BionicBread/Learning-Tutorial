using System;
using System.Collections.Generic;
namespace Exercise1
{
    public class StopWatch
    {
        ////////////////////////////////////////////////SOLUTION ONE//////////////////////////////////////////////
        private TimeSpan elapsedTime;
        private TimeSpan elapsedTimeCont;
        private DateTime startWatchTime;
        private DateTime stopWatchTime;
        private readonly List<DateTime> timeRecord = new List<DateTime>();

        //public StopWatch()
        //{
        //    this.startWatchTime = DateTime.Now;
        //    this.timeRecord.Add(startTime.Subtract(startTime));
        //}

        public void Start()
        {
            
            if (timeRecord.Count == 0)
            {
                this.startWatchTime = DateTime.Now;
                this.timeRecord.Add(startWatchTime);
                Console.WriteLine("Stop Watch has started! \n");
            }
            else if (timeRecord.Count >= 1 )
            {
                //Console.WriteLine("you entered start twice!");
                throw new InvalidOperationException(); 
            }
        }
        public void Stop()
        {
            this.stopWatchTime = DateTime.Now;
            //this.timeRecord.Add(stopWatchTime);
            startWatchTime = timeRecord[0];
            this.elapsedTime = stopWatchTime.Subtract(startWatchTime);
            elapsedTimeCont += elapsedTime;
            Console.WriteLine(string.Format("Elapsed Time: " + "{0:hh\\:mm\\:ss}", elapsedTimeCont));
            timeRecord.Clear();
        }
        ////////////////////////////////////////////////SOLUTION ONE END//////////////////////////////////////////////
        ///

        ////////////////////////////////////////////////SOLUTION TWO /////////////////////////////////////////////////
        //private TimeSpan elapsedTime;
        //private TimeSpan elapsedTimeCont;
        //private DateTime startWatchTime;
        //private DateTime stopWatchTime;


        //public StopWatch()
        //{
        //   List<DateTime> timeRecord = new List<DateTime>() { DateTime.Now };
        //}

        //public void Start()
        //{
        //    Console.WriteLine();
        //}
    }
}
