﻿using airport_finder.Models;

namespace airport_finder.Services
{
    public interface IDistMethods
    {
        double CalculateDistance(Location l1, Location l2, Location l3);
        double HaversineDistance(Location location1, Location location2);
        double DegreesToRadians(double degrees);
    }
}
