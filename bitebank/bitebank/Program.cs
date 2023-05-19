using bitebank;


ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André da Silva";
contaDoAndre.agencia = 1;
contaDoAndre.conta = "2064-8";
contaDoAndre.saldo = 100;

Console.WriteLine($"Titula da conta: {contaDoAndre.titular}");
Console.WriteLine($"Número da conta: {contaDoAndre.conta}");
Console.WriteLine($"Agência: {contaDoAndre.agencia}");
Console.WriteLine($"Saldo da conta: {String.Format("{0:0.00}", contaDoAndre.saldo)}");

contaDoAndre.Depositar(200);

Console.WriteLine($"Saldo da conta pós-deposito: {String.Format("{0:0.00}", contaDoAndre.saldo)}");

double valorDoSaque = 1;
bool saque = contaDoAndre.Sacar(valorDoSaque);

Console.WriteLine($"Solicitado saque de {String.Format("{0:0.00}", valorDoSaque)}");
Console.WriteLine("Processando...");

if (!saque)
{
    Console.WriteLine("Saldo insuficiente");
}
else
{
    Console.WriteLine($"Saldo da conta pós-saque: {String.Format("{0:0.00}", contaDoAndre.saldo)}");
}

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Nogueira";
contaDaMaria.agencia = 2;
contaDaMaria.conta = "2065-8";
contaDaMaria.saldo = 100;
Console.WriteLine($"Saldo da conta da Maria: {contaDaMaria.saldo}");


double transferenciaValor = 100;

contaDoAndre.Transferir(contaDaMaria, transferenciaValor);
Console.WriteLine($"Saldo da conta da Maria pós-transferência: {contaDaMaria.saldo}");
Console.WriteLine($"Saldo da conta do Anré pós-transferência: {contaDoAndre.saldo}");
