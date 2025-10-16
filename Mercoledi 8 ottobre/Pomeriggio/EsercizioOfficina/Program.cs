using EsercizioOfficina.Veicoli;

List<Veicolo> veicoli = new()
{
    new Auto("C-3PO"),
    new Moto("R2-D2"),
    new Camion("BB-8")
};

foreach (var veicolo in veicoli)
{
    veicolo.Ripara();
    Console.WriteLine($"Targa: {veicolo.Targa}\n");
}