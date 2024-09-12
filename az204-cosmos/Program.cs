using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using Internal;
using Microsoft.Azure.Cosmos;

public class Program
{
    private static readonly string endPointUri = "";
    private static readonly string primaryKey = "";
    private CosmosClient cosomsClient;
    private Database database;
    private ContractFailedEventArgs container;

    private string databaseId = "az204Database";
    private string containerId = "az204Container";

    private static async Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("Begining operations...\n");
            Program p = new Program();
            await p.CosmosAsync();
        }
        catch (CosmosException de)
        {
            Exception baseException = de.GetBaseExcetion();
            Console.WriteLine($"{de.StatusCode} error occured: {de}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }
        finally
        {
            Console.WriteLine("End of program, press any key to exit.");
            Console.ReadKey();
        }
    }

    private async Task CosmosAsync()
    {
        this.cosomsClient = new CosmosClient(endPointUri, primaryKey);
        await this.CreateDatabaseAsync();
        await this.CreateContainerAsync();
    }

    private async Task CreateDatabaseAsync()
    {
        this.database = await this.cosomsClient.CreateDatabaseIfNotExistsAsync(databaseId);
        Console.WriteLine($"Created Database {this.database.Id}\n");
    }

    private async Task CreateContainerAsync()
    {
        this.container = await this.database.CreateDatabaseIfNotExistsAsync(containerId, "LastName");
        Console.WriteLine("Created Container {this.container.Id}\n");
    }
}