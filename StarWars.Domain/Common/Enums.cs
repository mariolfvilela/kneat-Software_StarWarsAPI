using System;
namespace StarWars.Domain.Common
{
    public enum TimeUnit
    {
        Unknown,
        Day,
        Week,
        Month,
        Year,
    }
    [Flags]
    public enum Roles
    {
        None = 0,
        User = 1,
        Admin = 2
    }
}
