using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseTracking
{
    // Base abstract class
    abstract class Activity
    {
        private DateTime _date;
        private int _lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public DateTime Date => _date;
        public int LengthMinutes => _lengthMinutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            string dateStr = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
            string activityName = this.GetType().Name;
            string distanceUnit = "miles";
            string speedUnit = "mph";
            string paceUnit = "min per mile";

            double distance = GetDistance();
            double speed = GetSpeed();
            double pace = GetPace();

            return $"{dateStr} {activityName} ({_lengthMinutes} min) - Distance {distance:F1} {distanceUnit}, Speed {speed:F1} {speedUnit}, Pace: {pace:F2} {paceUnit}";
        }
    }

    class Running : Activity
    {
        private double _distanceMiles;

        public Running(DateTime date, int lengthMinutes, double distanceMiles) 
            : base(date, lengthMinutes)
        {
            _distanceMiles = distanceMiles;
        }

        public override double GetDistance() => _distanceMiles;

        public override double GetSpeed() => (GetDistance() / LengthMinutes) * 60;

        public override double GetPace() => LengthMinutes / GetDistance();
    }

    class Cycling : Activity
    {
        private double _speedMph;

        public Cycling(DateTime date, int lengthMinutes, double speedMph)
            : base(date, lengthMinutes)
        {
            _speedMph = speedMph;
        }

        public override double GetDistance() => _speedMph * (LengthMinutes / 60.0);

        public override double GetSpeed() => _speedMph;

        public override double GetPace() => 60 / _speedMph;
    }

    class Swimming : Activity
    {
        private int _laps;
        private const double LapLengthMeters = 50;
        private const double MeterToMiles = 0.000621371;

        public Swimming(DateTime date, int lengthMinutes, int laps)
            : base(date, lengthMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * LapLengthMeters * MeterToMiles;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthMinutes) * 60;
        }

        public override double GetPace()
        {
            return LengthMinutes / GetDistance();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>()
            {
                new Running(new DateTime(2022, 11, 3), 30, 3.0),
                new Cycling(new DateTime(2022, 11, 3), 30, 12.0),
                new Swimming(new DateTime(2022, 11, 3), 30, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
