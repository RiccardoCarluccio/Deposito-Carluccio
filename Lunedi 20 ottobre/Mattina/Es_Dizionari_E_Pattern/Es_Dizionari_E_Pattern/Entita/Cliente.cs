using Es_Dizionari_E_Pattern.Factory;

namespace Es_Dizionari_E_Pattern.Entita;

public class Cliente
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<IConto> Conto { get; set; }

    public Cliente(string name, string email)
    {
        this.Name = name;
        this.Email = email;
    }
}
