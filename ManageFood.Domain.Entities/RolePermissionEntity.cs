namespace ManageFood.Domain.Entities
{
  public class RolePermissionEntity
  {
    public Guid RoleId { get; set; }
    public Guid PermissionId { get; set; }
    public DateTimeOffset Created { get; set; }
    public byte[] Version { get; set; } = null!;
    public RoleEntity Role { get; set; } = null!;
    public PermissionEntity Permission { get; set; } = null!;
  }
}
