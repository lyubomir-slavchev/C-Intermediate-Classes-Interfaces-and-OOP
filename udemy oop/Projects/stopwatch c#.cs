using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography.X509Certificates;



namespace ConsoleApp4
{

    public class Stopwatch {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;


        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Already running");

            _startTime= DateTime.Now;
            _isRunning= true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Already running");

            _endTime = DateTime.Now;
            _isRunning= false;
        }

        public TimeSpan Result() { 
            return _endTime - _startTime;
        }

    }

    

    internal class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Thread.Sleep(1000);

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Result());
            Console.ReadLine();

            
            
        }
    }
}