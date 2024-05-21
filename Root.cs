namespace EmployeeStat;

[Serializable()]
[System.Xml.Serialization.XmlRoot(ElementName = "root", Namespace = "", IsNullable = false)]
public class Root
{
    [System.Xml.Serialization.XmlElement("employee")]
    public List<Employee> Employees;
}

[Serializable()]
public class Employee
{
    [System.Xml.Serialization.XmlElement("project")]
    public List<Project> Projects;

    [System.Xml.Serialization.XmlAttribute("id")]
    public int Id;

    [System.Xml.Serialization.XmlAttribute("salary")]
    public int Salary;

    [System.Xml.Serialization.XmlAttribute("name")]
    public string Name;

    public int TotalSalary => Salary + Projects.Sum(project => project.Bonus);

    public override string ToString() => $"Dolgozó: {Name}, Id: {Id}, Teljes fizetés: {TotalSalary}";
}

[Serializable()]
public class Project
{
    [System.Xml.Serialization.XmlAttribute("bonus")]
    public int Bonus;

    [System.Xml.Serialization.XmlText()]
    public string Name;
}
