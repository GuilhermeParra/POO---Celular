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

        /// <summary>
        /// Liga o celular
        /// </summary>
        /// <returns>O celular está çigando</returns>
        public string Ligar(){
            return "O celular está ligando"; 
        }

        /// <summary>
        /// Desliga o celular
        /// </summary>
        /// <returns>Desligando celular</returns>
        public string Desligar(){
        return "O celular esta desligando";
        }

        /// <summary>
        /// Faz uma ligação 
        /// </summary>
        /// <returns>Fazendo ligação</returns>
        public string FazerLigacao(){
            return "Fazendo ligação \nLigação realizada com sucesso!";
        }

        /// <summary>
        /// Envia mensagem
        /// </summary>
        /// <returns>Enviando mensagem</returns>
        public string EnviarMensagem(){
            return "Enviando mensagem \nMensagem enviada com sucesso! ";
        }

        /// <summary>
        /// Recebe as informações para verificar se estão corretas
        /// </summary>
        /// <returns>Informações corretas</returns>
        public string Informar(){
            return "Informações verificadas, esta tudo correto";
        }
        

    }}
            
    

