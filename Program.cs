using System;

namespace POO___Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Samsung = new Celular();
            
            Samsung.cor = "Vermelho";
            Samsung.modelo = "J6 Prime";
            Samsung.ligado = true;
            Samsung.tamanho = 7.0f;
            
            if(Samsung.ligado == true){
            Console.WriteLine(Samsung.Ligar());
            
            Console.WriteLine("A cor do seu celular é: " + Samsung.cor);
            Console.WriteLine("Seu celular é o modelo: " + Samsung.modelo);
            Console.WriteLine("O tamanho do seu celular é de: " + Samsung.tamanho + " polegadas ");

            Console.WriteLine("Essas informações estão corretas?");

            Samsung.informacao = Console.ReadLine();

             if(Samsung.informacao == "sim" || Samsung.informacao == "Sim"){
                 Console.WriteLine(Samsung.Informar());
                 Console.WriteLine("Seu celular também pode fazer ligações, deseja ligar para alguém?");
                 Samsung.chamada = Console.ReadLine();
                 if(Samsung.chamada == "sim" || Samsung.chamada == "Sim"){
                     Console.WriteLine(Samsung.FazerLigacao());
                     
                     Console.WriteLine("Deseja enviar uma mensagem para alguem?");
                     Samsung.mensagem = Console.ReadLine();
                     if(Samsung.mensagem == "Sim" || Samsung.mensagem == "sim"){
                         Console.WriteLine(Samsung.EnviarMensagem());
                     }else{
                         Console.WriteLine("Tudo bem!");
                         Console.WriteLine(Samsung.Desligar());
                     }
                 }
                 else{
                     Console.WriteLine("Tudo bem, deseja enviar mensagem para alguém?");
                     Samsung.mensagem = Console.ReadLine();
                     if(Samsung.mensagem == "Sim" || Samsung.mensagem == "sim"){
                         Console.WriteLine(Samsung.EnviarMensagem());
                     }else{
                         Console.WriteLine("Tudo bem!");
                         Console.WriteLine(Samsung.Desligar());
                     }
                 }
            }
            else{
                Console.WriteLine(Samsung.Desligar());
            }
            }else if (Samsung.ligado == false){
                Console.WriteLine(Samsung.Desligar());
            }

            
             
        }
    }
}
