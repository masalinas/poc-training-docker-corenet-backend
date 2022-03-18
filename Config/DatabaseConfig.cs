namespace poc_training_docker_corenet_backend.Config;

public class DatabaseConfig
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string ProductCollectionName { get; set; } = null!;
}