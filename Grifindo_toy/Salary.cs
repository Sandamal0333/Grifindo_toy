using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_toy
{
    class Salary
    {
        public int findAbDays(int worked_days, int date_range)
        {
            int absent_days;
            absent_days = date_range - worked_days;
            return absent_days;

        }
        public int noPay(int monthly_salary,int date_range,int absent_days)
        {
            int nopay;
            nopay = (monthly_salary / date_range) * absent_days;
            return nopay;
        }
        public int basePay(int monthly_salary,int allowances,int ot_rate,int ot_hours)
        {
            int basePay;
            basePay = monthly_salary + allowances + (ot_rate * ot_hours);
            return basePay;
        }

        public int grossPay(int base_pay, int no_pay, int taxrt)
        {
            int grossPay;
            grossPay = base_pay - (no_pay + base_pay * (taxrt)/100);
            return grossPay;
        }
    }
}
