﻿namespace Pizza.Domain.Entity.Food
{
    public class Pizza : FoodBase
    {
        public override string? Type { get => GetType().Name; set { }}       
    }
}
