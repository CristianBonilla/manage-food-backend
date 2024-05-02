using ManageFood.Contracts.DTO.SeedData;
using ManageFood.Domain.Entities;

namespace ManageFood.Domain.SeedWork.Collections.FoodShop
{
  class ProductCollection : SeedData, ISeedDataCollection<ProductEntity, ProductEntity>
  {
    int _index;
    readonly ISeedDataCollection<Guid, CatalogueEntity> _catalogues;
    readonly ISeedDataCollection<Guid, InventoryEntity> _inventories;
    readonly ProductEntity[] _products = new ProductEntity[13];

    public int Length => _products.Length;

    public ProductCollection()
    {
      _catalogues = FoodShop.Catalogues;
      _inventories = FoodShop.Inventories;
      Init([
        new ProductEntity
        {
          ProductId = new("{0ab34369-9ea3-4153-97ae-099ebef7f746}"),
          InventoryId = _inventories[0],
          CatalogueId = _catalogues[0],
          Name = "Apio",
          Description = "Apio crudo",
          Created = new DateTimeOffset(2024, 2, 10, 9, 46, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{b1369640-650a-46f8-ad78-677690e222db}"),
          InventoryId = _inventories[1],
          CatalogueId = _catalogues[0],
          Name = "Chayote cocido picado",
          Created = new DateTimeOffset(2024, 2, 11, 2, 26, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{9f15a35d-c294-471b-905f-e72d85538610}"),
          InventoryId = _inventories[2],
          CatalogueId = _catalogues[0],
          Name = "Chile jalapeño",
          Created = new DateTimeOffset(2024, 2, 11, 10, 4, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{8b0ce0e2-2850-4673-bc32-8cfd0554409b}"),
          InventoryId = _inventories[3],
          CatalogueId = _catalogues[1],
          Name = "Fresa entera",
          Created = new DateTimeOffset(2024, 2, 14, 55, 31, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{3bfd012b-734b-424b-8c38-31f550037db6}"),
          InventoryId = _inventories[4],
          CatalogueId = _catalogues[1],
          Name = "Guayaba rosa",
          Created = new DateTimeOffset(2024, 2, 15, 47, 11, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{7124211b-ff28-41b6-8404-d111c0a7ddb3}"),
          InventoryId = _inventories[5],
          CatalogueId = _catalogues[2],
          Name = "Galleta salmas",
          Created = new DateTimeOffset(2024, 2, 18, 6, 10, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{9037cc53-fa37-4dd6-8833-40d583fd2371}"),
          InventoryId = _inventories[6],
          CatalogueId = _catalogues[2],
          Name = "Maíz Tostado",
          Created = new DateTimeOffset(2024, 2, 18, 40, 33, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{3cbcffd4-60a8-4584-97a0-eacabf555ad8}"),
          InventoryId = _inventories[7],
          CatalogueId = _catalogues[2],
          Name = "Galleta de animalitos",
          Created = new DateTimeOffset(2024, 2, 18, 43, 17, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{920c202d-4ed1-453d-8769-557f4e5d0f90}"),
          InventoryId = _inventories[8],
          CatalogueId = _catalogues[2],
          Name = "Pan de barra",
          Created = new DateTimeOffset(2024, 2, 19, 3, 56, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{96be3795-4827-4def-b766-6302e4ae3fef}"),
          InventoryId = _inventories[9],
          CatalogueId = _catalogues[2],
          Name = "Galleta maría",
          Created = new DateTimeOffset(2024, 2, 19, 10, 5, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{b3ce1679-ae8e-4f5b-9c22-0b672d7aab48}"),
          InventoryId = _inventories[10],
          CatalogueId = _catalogues[3],
          Name = "Cristal",
          Description = "Agua natural Cristal",
          Created = new DateTimeOffset(2024, 2, 19, 48, 36, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{67073233-c813-4646-ba42-06b7e7997fa9}"),
          InventoryId = _inventories[11],
          CatalogueId = _catalogues[3],
          Name = "Leche entera",
          Description = "Leche entera alqueria",
          Created = new DateTimeOffset(2024, 2, 21, 2, 0, 0, TimeSpan.FromHours(3))
        },
        new ProductEntity
        {
          ProductId = new("{b323b549-dd2f-4fa5-aace-46239ed7f954}"),
          InventoryId = _inventories[12],
          CatalogueId = _catalogues[3],
          Name = "Té Verde",
          Description = "Té Verde FUZE Manzanilla",
          Created = new DateTimeOffset(2024, 2, 22, 9, 59, 0, TimeSpan.FromHours(3))
        }
      ]);
    }

    public ProductEntity this[int index] => _products.ElementAt(index);

    public IEnumerable<ProductEntity> GetAll() => [.. _products];

    private void Init(params ProductEntity[] products)
    {
      foreach (ProductEntity product in products)
        _products[_index++] = product;
    }
  }
}