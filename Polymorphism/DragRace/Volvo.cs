using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Volvo : ICar, IModifiedCar
    {
        private int _currentSpeed = 0;
        public string Name()
        {
            return "Volvo";
        }

        public void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public void SlowDown()
        {
            _currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Phh......");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 50;
        }
    }
}
