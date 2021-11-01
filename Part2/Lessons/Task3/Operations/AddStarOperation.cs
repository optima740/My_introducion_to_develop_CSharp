﻿using Space.AttributeSetters;
using Space.InputOutput;
using Space.Models;

namespace Space.Operations
{
    class AddStarOperation : BaseAddOperation
    {
        public AddStarOperation(ModelAttributeSetter setter, IOutput printInConsole, IInput readFromConsole) : base(setter, printInConsole, readFromConsole) { }

        protected override SpaceObject CreateModel()
        {
            return new Star();
        }
    }
}
