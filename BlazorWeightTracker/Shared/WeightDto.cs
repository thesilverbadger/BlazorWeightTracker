using System;
namespace BlazorWeightTracker.Shared
{
    public class WeightDto
    {
        public int WeightId { get; set; }

        public Guid UserId { get; set; }

        public DateTime Created { get; set; }

        public decimal KgValue { get; set; }

        public WeightUnit Unit { get; set; }

        public decimal Value
        {
            get
            {
                switch(Unit)
                { 
                    case WeightUnit.Lb:
                        return KgValue * 2.2M;

                    case WeightUnit.St:
                        throw new NotImplementedException("Need to convert KG to St & Lb");

                    //The default is Kilos
                    default:
                        return KgValue;
                }
            }
        }
    }
}
