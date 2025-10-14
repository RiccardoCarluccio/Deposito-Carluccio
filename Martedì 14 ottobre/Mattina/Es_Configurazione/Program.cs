using Es_Configurazione;

var config1 = ConfigurazioneSistema.Instance;
config1.Imposta("Volume", "50");
Console.WriteLine(config1.Leggi("Volume") + "\n");

ConfigurazioneSistema.Instance.StampaTutte();

var config2 = ConfigurazioneSistema.Instance;
config2.Imposta("Tema", "Scuro");
Console.WriteLine(config1.Leggi("Tema") + "\n");

ConfigurazioneSistema.Instance.StampaTutte();

Console.WriteLine("Inserisci una configurazione ed il suo valore");
string chiaveConfig = Console.ReadLine()!;
string valoreConfig = Console.ReadLine()!;
config2.Imposta(chiaveConfig, valoreConfig);

Console.WriteLine($"'{ConfigurazioneSistema.Instance.Leggi(chiaveConfig)}' " +
    $"aggiunta con successo");