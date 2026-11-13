using System;
    class Car1
    {
        private int model= 5471;
        private string manufacturer = "Toyota";
        private int fuel = 0;
        private int distance = 0;

        public void EngineWork()
        {
            Console.WriteLine("Engine is running");
        }

        public void SetFuelValue(int value)
        {
            fuel = value;
        }

        public int GetModel()
        {
            return model;
        }
    }
