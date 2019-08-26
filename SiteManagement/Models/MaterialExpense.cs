﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteManagement.Models
{
    public class MaterialExpense
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int LabourId { get; set; }

        public DateTime Date { get; set; }
        public string Particular { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }

    }
}
