using System;
namespace UML_OOPClassLib;
public class Contract
{
    public DateTime StartDate {get; set; }
    public DateTime EndDate {get; set; }
    public double HourlyRate {get; set; }
    
    //todo: add consultant somehow
    public string ConsultantName {get; set; }
    
}
