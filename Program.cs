using bancoOnline;
using bancoOnline.Titular;

Console.WriteLine("Bem vindo ao seu Banco Online! \n");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "pedro gomes";
//conta1.conta = "10234-x";
//conta1.numero_agencia = 29;
//conta1.nome_agencia = "agência central";
//conta1.saldo = 154.30;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Aldo gomes";
//conta2.conta = "10236-x";
//conta2.numero_agencia = 22;
//conta2.nome_agencia = "agência central";
//conta2.saldo = 154.30;

//Console.WriteLine("Saldo do Aldo pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Pedro pré-transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
//Console.WriteLine("Saldo do Aldo pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Pedro pós-transferência: " + conta1.saldo);

//Cliente cliente = new Cliente();

//cliente.nome = "Pedro Gomes";
//cliente.cpf = "10253543463";
//cliente.profissao = "Desenvolvedor";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "Pedro Gomes";
//conta3.titular.cpf = "10253543463";
//conta3.titular.profissao = "Desenvolvedor";

//conta3.conta = "1313252-X";
//conta3.numero_agencia = 28;
//conta3.nome_agencia = "Agência Central";
//Console.WriteLine(conta3.titular.nome);

//if (conta3.titular == null)
//{
//    Console.WriteLine("O campo titular está nulo");
//}
//Cliente Pedro = new Cliente();
//Pedro.Nome = "Pedro Gomes";

//ContaCorrente conta4 = new ContaCorrente(125, "232424-x");
//conta4.Saldo = 1350;
//conta4.Titular = Pedro;


//Console.WriteLine("Nome: " + conta4.Titular.Nome);
//Console.WriteLine("Saldo: R$ " + conta4.Saldo);
//Console.WriteLine("Numero da agência: " + conta4.Numero_agencia);
//Console.WriteLine("Numero da Conta: " + conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(135, "125123-X");

ContaCorrente conta6 = new ContaCorrente(231, "957987-X");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();