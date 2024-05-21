namespace EmployeeStat;

[Serializable]
public class EmployeeBase
{

    [System.Xml.Serialization.XmlAttribute("id")]
    public int Id;

    [System.Xml.Serialization.XmlAttribute("name")]
    public string Name;
    [System.Xml.Serialization.XmlElement("project")]
    public List<Project> Projects;

    [System.Xml.Serialization.XmlAttribute("salary")]
    public int Salary;

    public virtual int TotalSalary => Salary + Projects.First().Bonus;

    public override string ToString() => $"Dolgozó: {Name}, Id: {Id}, Teljes fizetés: {TotalSalary}";
}