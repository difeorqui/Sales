namespace Sales.Backend.Models
{
  using Domain.Models;

  public class LoalDataContext : DataContext
  {
    public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
  }
}