namespace Es_Dictionary.Classi;

public class Utente
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public DateTimeOffset DataCreazione { get; set; }
    public Stato Stato { get; set; }

    public Utente(int id, string username, string email, DateTimeOffset dataCreazione, Stato stato)
    {
        Id = id;
        Username = username;
        Email = email;
        DataCreazione = dataCreazione;
        Stato = stato;
    }

    public override string ToString()
    {
        return $"Username: {Username}, Email: {Email}, Stato: {Stato}, Creato il: {DataCreazione}";
    }
}

public enum Stato
{
    Attivo,
    Inattivo,
    Invalid
}
