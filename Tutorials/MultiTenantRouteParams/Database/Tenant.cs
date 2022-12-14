namespace MultiTenantRouteParams.Database;

public class Tenant
{
    public Tenant(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; }
    public string Name { get; }
}
