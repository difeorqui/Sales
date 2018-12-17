namespace Sales.Backend.Models
{
  using Sales.Domain.Models;

  public class LoalDataContext : DataContext
  {
    public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
  }
}