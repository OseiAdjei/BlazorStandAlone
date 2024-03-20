﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        //One to Many Relationship
        [JsonIgnore]
        public List<Employee> Employees { get; set; }
    }
}