﻿namespace FinancePlatform.API.Models
{
    public class TodoItem
    {
        public long Id { get; set; } //unique key in a relational database.
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
}
