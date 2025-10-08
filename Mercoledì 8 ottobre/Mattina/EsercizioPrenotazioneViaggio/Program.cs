using EsercizioPrenotazioneViaggio.Classi;

var viaggio = new PrenotazioneViaggio("Seoul");

viaggio.VisualizzaStato();

viaggio.PrenotaPosti(10);

viaggio.AnnullaPrenotazione(5);

var persona = new Persona("Mario");

persona.Prenota(viaggio, 1);