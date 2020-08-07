using System;

namespace LearningUsing
{
    //good for automatically disposing something once you're done
    //using it
    class MyResource : IDisposable
    {
        public void Dispose()
        {
            //implementing the interface from IDisposable

            //this fires second because even though Dispose()
            //is not called explicitly in the resource object (var resource),
            //IDesposable gets called by the using statement
            Console.WriteLine("Disposing our resource");
        }
    }
    class Program
    {
        //delegates, events and lambda expressions tomorrow
        static void Main(string[] args)
        {
            //variable that will give us reference to the resource
            //in IDisposable
            using (var resource = new MyResource())
            {
                //this fires first b/c it's calling MyResource(IDesposable
                //first
                Console.WriteLine("Using my resource");
            }
            //fires third, finally get out of using scope, and see 'finished' message
            Console.WriteLine("Finished");
        }
    }
}
