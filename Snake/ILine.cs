﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal interface ILine : IPoint, IDrawable
    {
        int Length { get; set; }
    }
}
