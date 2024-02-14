using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScripts.CompanyChallenges
{
    public class AmountPaid
    {
        public double CompanyAmountPaid(int salary, int[] debts, int[] interests)
        {
            //int salary = 50;
            //int[] debts = new int[3] { 2, 2, 5 };
            //int[] interests = new int[3] { 200, 100, 150 };
            double amountPaid = 0;
            bool mounthsCounter = true;
            do
            {
                double tenPorcent = salary * 0.10;
                for (int x = 0; x < debts.Length; x++)
                {
                    {
                        if (debts[x] <= tenPorcent)
                        {
                            tenPorcent = tenPorcent - debts[x];
                            amountPaid += debts[x];
                            debts[x] = 0;
                        }
                        else if (debts[x] > tenPorcent)
                        {
                            debts[x] = debts[x] - (int)tenPorcent + (debts[x] - (int)tenPorcent) * (interests[x] / 100);
                            amountPaid += (int)tenPorcent;
                            tenPorcent = 0;
                        }
                    }
                }
            } while (mounthsCounter);

            return amountPaid;

        }
    }
}
