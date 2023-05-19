using bitebank;

ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 1;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;


Console.WriteLine("Saldo da conta do André R$ " + contaDoAndre.saldo);

contaDoAndre.Depositar(100);

Console.WriteLine("Novo saldo da conta do André R$ " + contaDoAndre.saldo);
