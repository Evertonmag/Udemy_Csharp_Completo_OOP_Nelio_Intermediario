using Heranca.Entitites;

namespace Heranca;
internal class Program
{
    static void Main(string[] args)
    {
        //ExemploHeranca();
        //ExemploUpcastingDowncasting();
        Sobreposicao();
    }

    /// <summary>
    /// <b>Exemplo</b>
    /// <para>
    ///     Suponha um negócio de banco que possui uma conta comum e uma conta para empresas, sendo
    ///     que a conta para empresa possui todos membros da conta comum, mais um limite de emprestimo
    ///     e uma operação de realizar emprestimo.
    /// </para>
    /// </summary>
    static void ExemploHeranca()
    {
        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

        Console.WriteLine(account.Balance);

        // com o modificador protected não é possivel modificar o balnce da account pois ele
        // nao permite o acesso de outras classes no assembly(projeto) ele só permite para
        // classes que herdam dela.
        // account.Balance = 200.0;
    }

    static void ExemploUpcastingDowncasting()
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        #region UPCASTING
        
        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        #endregion

        #region DOWNCASTING
        // não confiavel pois pode dar erro se o tivo convertido nao for compativel
        // o compilador só ira interpretar esse erro na hora da depuracao

        BusinessAccount acc4 = (BusinessAccount)acc2;
        acc4.Loan(100.0);

        //BusinessAccount acc5 = (BusinessAccount)acc3;
        if (acc3 is BusinessAccount)
        {
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            BusinessAccount acc5 = acc3 as BusinessAccount;
            acc5.Loan(200.0);
            Console.WriteLine("Loan!");
        }

        if (acc3 is SavingsAccount)
        {
            //SavingsAccount acc5 = (SavingsAccount)acc3;
            SavingsAccount acc5 = acc3 as SavingsAccount;
            acc5.UpdateBalance();
            Console.WriteLine("Upadate!");
        }

        #endregion
    }

    static void Sobreposicao()
    {
        Account acc1 = new Account(1001, "Alex", 500.0);
        Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);

        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);
    }
}
