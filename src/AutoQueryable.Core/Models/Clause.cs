﻿using AutoQueryable.Core.Enums;

namespace AutoQueryable.Core.Models
{
    public class Clause
    {
        public ClauseType ClauseType { get; set; }

        public string Value { get; set; }
    }

    public class Clauses
    {
        public Clause Select { get; set; }
        
        public Clause Top { get; set; }
        
        public Clause Skip { get; set; }
        
        public Clause OrderBy { get; set; }
        
        public Clause OrderByDesc { get; set; }
        
        public Clause GroupBy { get; set; }
        
        public Clause First { get; set; }
        
        public Clause Last { get; set; }
        
        public Clause WrapWith { get; set; }
        
        public Clause Filter { get; set; }
        
        public Clause Expand { get; set; }
        
        public Clause Search { get; set; }
    }
}
