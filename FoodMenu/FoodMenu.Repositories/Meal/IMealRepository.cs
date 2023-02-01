﻿using FoodMenu.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Repositories
{
    public interface IMealRepository
    {
        public IQueryable<Meal> GetMeal();
    }
}