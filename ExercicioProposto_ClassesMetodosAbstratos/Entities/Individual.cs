using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto_ClassesMetodosAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annuAlIncome, double healthExpenditures)
            : base(name, annuAlIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnnuAlIncome >= 20000)
                return AnnuAlIncome * 0.25 - HealthExpenditures * 0.5;
            else
                return AnnuAlIncome * 0.15 - HealthExpenditures * 0.5;
        }
    }
}
