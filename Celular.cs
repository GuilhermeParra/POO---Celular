namespace POO___Celular
{
    public class Celular
    
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;
        public string informacao;
        public string chamada;
        public string mensagem;
        public string Ligar(){
            return "O celular está ligando"; 
        }
        public string Desligar(){
        return "O celular esta desligando";
        }
        public string FazerLigacao(){
            return "Fazendo ligação \nLigação realizada com sucesso!";
        }

        public string EnviarMensagem(){
            return "Enviando mensagem \nMensagem enviada com sucesso! ";
        }
        public string Informacoes(){
            return "Informações verificadas, esta tudo correto";
        }
        

    }}
            
    

