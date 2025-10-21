public interface IStorageService
{
    void Upload(string data);
}

public class DiskStorageService : IStorageService
{
    public void Upload(string data)
    {
        Console.WriteLine($"{data} " +
            $"salvato su disco");
    }
}

public class InMemoryStorageService : IStorageService
{
    public void Upload(string data)
    {
        Console.WriteLine($"{data} " +
            $"salvato InMemory");
    }
}

public class FileUploader
{
    public IStorageService storageService;

    public void UploadFile(string data)
    {
        if (storageService == null)
        {
            Console.WriteLine("Dispositivo di salvataggio non presente");
            return;
        }
        storageService.Upload(data);
        Console.WriteLine("Upload completato");
    }
}

class Program
{
    static void Main()
    {
        var fileUploader = new FileUploader();

        fileUploader.storageService = new DiskStorageService();
        fileUploader.UploadFile("Data");

        Console.WriteLine("");

        fileUploader.storageService = new InMemoryStorageService();
        fileUploader.UploadFile("Data");
    }
}