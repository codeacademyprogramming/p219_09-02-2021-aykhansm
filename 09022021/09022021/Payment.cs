using System;
using System.Collections.Generic;
using System.Text;

namespace _09022021
{
    class Payment
    {
        private double _amount;
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value > 0)
                {
                    _amount = value;
                }
            }
        }
        public bool IsPaid;
        //{
        //    if (boolean==true)
        //        return true;
        //    else
        //        return false;
        //}
        public Payment(double amount,bool ispaid)
        {
            this.Amount = amount;
            this.IsPaid = ispaid;
           
        }
    }
}
