﻿using System;
using System.Globalization;

namespace Interfaces.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return (DueDate.ToShortDateString()
                + " - " +
                Amount.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
