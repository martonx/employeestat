using System.Data;
using System.Xml.Serialization;

namespace EmployeeStat;

public class FileService
{
    public async Task<List<Employee>> GetEmployeesAsync()
    {
        var fileContent = await File.ReadAllTextAsync("employees.xml");
        using var reader = new StringReader(fileContent);
        var serializer = new XmlSerializer(typeof(Root));
        var rootData = (Root)serializer.Deserialize(reader);

        return rootData.Employees;
    }
}
