public class SuperHeroe
{
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public bool PuedeVolar { get; set; }
    public SuperPoder SuperPoder { get; set; }

    public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
    {
        Nombre = nombre;
        IdentidadSecreta = identidadSecreta;
        Ciudad = ciudad;
        PuedeVolar = puedeVolar;
        SuperPoder = superPoder;
    }

    // Imprimir
    public override string ToString()
    {
        return $"Nombre: {Nombre}\n" +
               $"Identidad Secreta: {IdentidadSecreta}\n" +
               $"Ciudad: {Ciudad}\n" +
               $"Puede Volar: {(PuedeVolar ? "Sí" : "No")}\n" +
               $"Super Poder: {SuperPoder.Nombre}\n" +
               $"Descripción del Poder: {SuperPoder.Descripcion}\n" +
               $"Nivel del Poder: {SuperPoder.Nivel}\n";
    }
}
