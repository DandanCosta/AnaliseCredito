decimal valor,valorParcela, rendaComprovada, ParcelaPermitida;
int qtdParcelas;

Console.WriteLine("--- Analise de Credito ---\n");

Console.Write("Digite o valor do emprestimo: ");
valor = decimal.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de parcelas: ");
qtdParcelas = int.Parse(Console.ReadLine()!);

Console.Write("Digite a renda mensal comprovada: ");
rendaComprovada = decimal.Parse(Console.ReadLine()!);

valorParcela = valor / qtdParcelas;
ParcelaPermitida = rendaComprovada / 100 * 30;

Console.WriteLine($"Parcela: {valorParcela:C2}");
Console.WriteLine($"Maior Parcela permitida: {ParcelaPermitida:C2}");

if(valorParcela > ParcelaPermitida){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Emprestimo não autorizado");
}
else{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Emprestimo autorizado");
}

Console.ResetColor();
