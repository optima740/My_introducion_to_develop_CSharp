﻿using SpaceObjects.Api.Models;

namespace SpaceObjects.Api.Initializers
{
    public static class SpaceObjectInitializer
    {
        static public Star Initialize(Star spaceObj)
        {
            InitializeBaseAttributs(spaceObj);          
            spaceObj.Name = "NewStar";
            spaceObj.DegOfIllumination = 4.0f;
            return spaceObj;
        }

        static public Planet Initialize(Planet spaceObj)
        {
            InitializeBaseAttributs(spaceObj);           
            spaceObj.Name = "NewPlanet";
            spaceObj.TiltAngle = 1.4f;
            return spaceObj;
        }

        static public Asteroid Initialize(Asteroid spaceObj)
        {
            InitializeBaseAttributs(spaceObj);          
            spaceObj.Name = "NewAsteroid";
            spaceObj.Speed = 50.0f;
            return spaceObj;
        }

        static public BlackHole Initialize(BlackHole spaceObj)
        {
            InitializeBaseAttributs(spaceObj);         
            spaceObj.Name = "NewBlackHole";
            spaceObj.Density = 8.0f;
            return spaceObj;
        }

        private static void InitializeBaseAttributs(SpaceObject spaceObj)
        {
            spaceObj.Diametr = 100.0f;
            spaceObj.Weight = 200.0f;
            spaceObj.DistToSun = 300.0f;
        }
    }
}
