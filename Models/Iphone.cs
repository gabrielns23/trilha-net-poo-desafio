namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string numero): base(numero)
        {
            
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} iphone...");
        }
    }
}