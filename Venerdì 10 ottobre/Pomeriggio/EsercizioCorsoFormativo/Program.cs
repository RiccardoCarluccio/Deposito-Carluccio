using EsercizioCorsoFormativo.Classi;
using EsercizioCorsoFormativo.ClassiAstratte;
using EsercizioCorsoFormativo.Estensioni;

List<Corso> corsi = new()
{
    new CorsoInPresenza("Infermiere", 900, "2B", 150),
    new CorsoOnline("Sviluppatore Web", 700, "1509", "https://link.accesso.com")
};

var corsoInPresenza = corsi[0];
var corsoOnline = corsi[1];


StampaInformazioni.Stampa(corsoInPresenza);

corsoOnline.ErogaCorso();