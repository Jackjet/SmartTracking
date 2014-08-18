using System.Data.Entity;

namespace SmartTracking.Entities
{
    /// <summary>
    /// 默认数据上下文
    /// </summary>
    public class DefaultDbContext : DbContext
    {
        public DbSet<VisitorRecord> User { get; set; }
    }
}