using System.Xml.Serialization;

namespace EmployeeStat;

public class FileService : IFileService
{
    private string path;

    public FileService(string path)
    {
            this.path = path;
    }

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        var fileContent = await File.ReadAllTextAsync(path);
        using var reader = new StringReader(fileContent);
        var serializer = new XmlSerializer(typeof(Root));
        var rootData = (Root)serializer.Deserialize(reader);

        return rootData.Employees;
    }
}
