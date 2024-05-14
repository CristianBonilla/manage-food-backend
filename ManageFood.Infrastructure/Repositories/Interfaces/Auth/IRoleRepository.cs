using ManageFood.Contracts.Repository;
using ManageFood.Domain.Entities;
using ManageFood.Infrastructure.Contexts.FoodShop;

namespace ManageFood.Infrastructure.Repositories.Interfaces.Auth
{
  public interface IRoleRepository : IRepository<FoodShopContext, RoleEntity> { }
}
