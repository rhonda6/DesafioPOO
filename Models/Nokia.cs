namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int menoria) : base(numero, modelo, imei, menoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo instaldo com sucesso {nomeApp} no número: {this.Numero} aparelho: {this.Modelo} com memória de {this.Memoria} e IMEI: {this.IMEI}");
        }
    }
}