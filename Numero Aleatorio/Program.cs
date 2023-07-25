public class Numero_Aleatorio
{
    static void Main(string[] args)
    {

        int numero;

        Random numeroAleatorio = new Random();

        int numeroSorteado = numeroAleatorio.Next(0, 20); 

       

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um numero de 0 a 20!!!");

        numero = int.Parse(Console.ReadLine()); 
            if(numero == numeroSorteado)
            {
                Console.WriteLine("Parabéns!!!! Você acertou o número secreto!!!");
                break;
            } else
            {
                Console.WriteLine("Tente novamente");
                
            }
        }    


        

    }
}