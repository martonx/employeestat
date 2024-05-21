namespace EmployeeStat;

[Serializable()]
[System.Xml.Serialization.XmlRoot(ElementName = "root", Namespace = "", IsNullable = false)]
public class Root
{
    [System.Xml.Serialization.XmlElement("employee")]
    public List<Employee> Employees;
}

[Serializable()]
public class Employee : EmployeeBase
{
    public override int TotalSalary => Salary + Projects.Sum(project => project.Bonus);
}

[Serializable()]
public class Project
{
    [System.Xml.Serialization.XmlAttribute("bonus")]
    public int Bonus;

    [System.Xml.Serialization.XmlText()]
    public string Name;
}
