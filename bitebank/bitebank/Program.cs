using bitebank.Contas;
using bitebank.Titular;


//ContaCorrente contaDoAndre = new ContaCorrente();

//contaDoAndre.titular = "André da Silva";
//contaDoAndre.agencia = 1;
//contaDoAndre.conta = "2064-8";
//contaDoAndre.saldo = 100;

//Console.WriteLine($"Titula da conta: {contaDoAndre.titular}");
//Console.WriteLine($"Número da conta: {contaDoAndre.conta}");
//Console.WriteLine($"Agência: {contaDoAndre.agencia}");
//Console.WriteLine($"Saldo da conta: {String.Format("{0:0.00}", contaDoAndre.saldo)}");

//contaDoAndre.Depositar(200);

//Console.WriteLine($"Saldo da conta pós-deposito: {String.Format("{0:0.00}", contaDoAndre.saldo)}");

//double valorDoSaque = 1;
//bool saque = contaDoAndre.Sacar(valorDoSaque);

//Console.WriteLine($"Solicitado saque de {String.Format("{0:0.00}", valorDoSaque)}");
//Console.WriteLine("Processando...");

//if (!saque)
//{
//    Console.WriteLine("Saldo insuficiente");
//}
//else
//{
//    Console.WriteLine($"Saldo da conta pós-saque: {String.Format("{0:0.00}", contaDoAndre.saldo)}");
//}

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Nogueira";
//contaDaMaria.agencia = 2;
//contaDaMaria.conta = "2065-8";
//contaDaMaria.saldo = 100;
//Console.WriteLine($"Saldo da conta da Maria: {contaDaMaria.saldo}");


//double transferenciaValor = 100;

//contaDoAndre.Transferir(contaDaMaria, transferenciaValor);
//Console.WriteLine($"Saldo da conta da Maria pós-transferência: {contaDaMaria.saldo}");
//Console.WriteLine($"Saldo da conta do Anré pós-transferência: {contaDoAndre.saldo}");

Cliente cliente = new Cliente();
cliente.nome = "Lutiero";
cliente.cpf = "000.111.222-33";
cliente.profissao = "Desenvolvedor";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-1";
conta.agencia = 1;
conta.saldo = 100;

Console.WriteLine($"Titular: {conta.titular.nome}");
Console.WriteLine($"CPF: {conta.titular.cpf}");
Console.WriteLine($"Profissão: {conta.titular.profissao}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.agencia}");
Console.WriteLine($"Saldo da conta: {String.Format("{0:0.00}", conta.saldo)}");

