decimal valor,valorParcela, rendaComprovada, ParcelasPermidas;
int qtdParcelas;

Console.WriteLine("--- Anilise de Credito ---\n");

Console.Write("Digite o valor do emprestimo: ");
valor = decimal.Parse(Console.ReadLine()!);

Console.Write("Digite a quatidade de parcelas: ");
qtdParcelas = int.Parse(Console.ReadLine()!);

Console.Write("Digite a renda mensal comprovada: ");
rendaComprovada = decimal.Parse(Console.ReadLine()!);

valorParcela = valor / qtdParcelas;
ParcelasPermidas = rendaComprovada / 100 * 30;

Console.WriteLine($"Parcela: {valorParcela:C2}");
Console.WriteLine($"Maior Parcela permitidas: {ParcelasPermidas:C2}");

if(valorParcela > ParcelasPermidas){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Emprestimo não autorizado");
}
else{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Emprestimo autorizado");


}

Console.ResetColor();
