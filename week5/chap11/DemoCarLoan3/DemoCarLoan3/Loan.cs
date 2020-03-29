﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCarLoan3
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }

        public const double Minimum_LOAN = 5000;

        protected double loanAmount;
        public double LoanAmount
        {
            set
            {
                loanAmount = value < Minimum_LOAN ? Minimum_LOAN : value;

                if (value < Minimum_LOAN)
                    loanAmount = Minimum_LOAN;
                else
                    LoanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }

        public Loan(int num, string name, double amount)
        {
            this.LoanNumber = num;
            this.LastName = name;
            this.loanAmount = amount;
        }
    }
}