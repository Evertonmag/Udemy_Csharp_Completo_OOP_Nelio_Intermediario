namespace ExercicioProposto_ClassesMetodosAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annuAlIncome, int numberOfEmployees)
            : base(name, annuAlIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
                return AnnuAlIncome * 0.14;
            else
                return AnnuAlIncome * 0.16;
        }
    }
}
