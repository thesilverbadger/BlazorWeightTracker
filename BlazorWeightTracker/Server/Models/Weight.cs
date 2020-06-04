using System;
using System.ComponentModel.DataAnnotations;
using BlazorWeightTracker.Shared;

namespace BlazorWeightTracker.Server.Models
{
    public class Weight
    {
        [Key]
        public int WeightId { get; set; }

        public string UserId { get; set; }

        public DateTime Created { get; set; }

        public decimal KgValue { get; set; }

        public WeightUnit Unit { get; set; }
    }
}
