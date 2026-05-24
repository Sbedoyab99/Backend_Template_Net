using Microsoft.EntityFrameworkCore;

namespace Backend_Template.Infrastructure.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {

    }
}
