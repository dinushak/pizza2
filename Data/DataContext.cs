using Microsoft.EntityFrameworkCore;

namespace PizzaService.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options){}

    public DbSet<PizzaOrder> PizzaOrders { get; set; }

}