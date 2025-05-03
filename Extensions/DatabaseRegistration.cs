namespace Workshop.Extensions;

public static class DatabaseRegistration
{
    public static IServiceCollection RegisterDatabase(this IServiceCollection services)
    {
        Console.WriteLine($"Database registration standin...");
        return services;
    }
}
