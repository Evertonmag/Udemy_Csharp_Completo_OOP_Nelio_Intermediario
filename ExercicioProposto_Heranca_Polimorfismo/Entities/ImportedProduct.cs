namespace ExercicioProposto_Heranca_Polimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price) => CustomsFee = customsFee;

        public override string PriceTag() => base.PriceTag() + $" (Customs Fee: $ {CustomsFee})";
    }
}
