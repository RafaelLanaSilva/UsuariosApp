namespace UsuariosApp.API.Settings
{
    /// <summary>
    /// Classe para armazenar os parametros de conexão com o servidor
    /// do RabbitMQ (servidor de mensageria)
    /// </summary>
    public class RabbitMQSettings
    {
        //caminho para conexão com o servidor
        public static string Url => @"amqps://jyuqvgih:M8BGwBQeOqCciEiRbfxDnKLLY76ofMWh@chimpanzee.rmq.cloudamqp.com/jyuqvgih";

        //Nome da fila que será criada/acessada no servidor
        public static string Queue => @"mensagens_usuario";
    }
}
