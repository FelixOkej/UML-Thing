namespace UML_OOPClassLib;
public class Client : Organization
{
    public List<Contract> Contracts = new List<Contract>();
    public string ContactAddress {get; set; }
    
}
