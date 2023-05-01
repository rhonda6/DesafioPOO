namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        /// <summary>
        /// Propriedade que representa o modelo do aparelho smarthphone.
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Propriedade que representa o código IMEI do aparelho smarthphone.
        /// </summary>
        public string IMEI { get; set; }

        /// <summary>
        /// Proprriedade que representa a quantidade de memória do aparelho smarthphone.
        /// </summary>
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int menoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades            
            Modelo = modelo;
            IMEI = imei;
            Memoria = menoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}