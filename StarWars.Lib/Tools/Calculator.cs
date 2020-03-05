using System;
using StarWars.Domain.Common;
using StarWars.Domain.Entities;

namespace StarWars.Lib.Tools
{
    public static class Calculator
    {
        #region Methods

        public static double ToStops(long distance, long mglt, double hours)
        {
            return (long)((double)distance / (hours * mglt));
        }

        public static double ToHours(Duration duration)
        {
            if (duration == null)
                throw new ArgumentNullException(nameof(duration));

            return duration.Unit switch
            {
                TimeUnit.Day => 24 * duration.Time,
                TimeUnit.Week => 168 * duration.Time,
                TimeUnit.Month => 730 * duration.Time,
                TimeUnit.Year => 8760 * duration.Time,
                _ => 0,
            };
        }


        #endregion
    }
}
