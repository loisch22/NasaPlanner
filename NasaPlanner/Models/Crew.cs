﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace NasaPlanner.Models
{
    public class Crew
    {
        public int CrewId { get; set; }
        public string Name { get; set; }
    }
}