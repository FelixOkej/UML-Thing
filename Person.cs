namespace UML_OOPClassLib;
public class Person
{
    public string Name {get; set;}
    public int PersonalNumber{get; set;}
    public int PhoneNumber{get; set;}
    public List<Email> EmailAddresses = new List<Email>(); 
}
