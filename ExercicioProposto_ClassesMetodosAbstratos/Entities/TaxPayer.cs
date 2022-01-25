namespace ExercicioProposto_ClassesMetodosAbstratos.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnuAlIncome { get; set; }

        public TaxPayer(string name, double annuAlIncome)
        {
            Name = name;
            AnnuAlIncome = annuAlIncome;
        }

        public abstract double Tax();
    }
}
