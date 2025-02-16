﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {

        public int CarId { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public string BrandName { get; set; }

        public string ColorName { get; set; }

        public string CarName { get; set; }

        public decimal DailyPrice { get; set; }

    }
}
