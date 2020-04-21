using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Blog.Abstractions.Config
{
    public class SysuserroleConf : EntityTypeConfigurationBase<Sysuserrole, int>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sysuserrole> builder)
        {
            builder.HasKey(x => x.KID);
            builder.Property(x => x.States).HasColumnType("tinyint(4)").IsRequired().HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).HasColumnType("tinyint(4)").IsRequired().HasDefaultValue(0);
            builder.Property(x => x.CreateUserId).HasMaxLength(512).IsRequired().HasDefaultValue("1");
            builder.Property(x => x.CreateUserName).HasMaxLength(512).IsRequired().HasDefaultValue("System");
            builder.Property(x => x.UpdateTime).IsRequired().HasColumnType("timestamp").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(x => x.CreateTime).IsRequired().HasDefaultValue("1970-01-01 08:00:00");
            builder.Property(x => x.UpdateUserId).HasMaxLength(512).IsRequired().HasDefaultValue("");
            builder.Property(x => x.UpdateUserName).HasMaxLength(512).IsRequired().HasDefaultValue("");
            builder.Property(x => x.UserType).IsRequired().HasDefaultValue(0);

            builder.HasOne<Employee>(en => en.Employee).WithMany(x => x.Sysuserroles).HasForeignKey(x => x.Userid).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict); ;//只需在这边指定外键就行
            builder.HasOne<Sysrole>(en => en.Sysrole).WithMany(x => x.Sysuserroles).HasForeignKey(x => x.Roleid).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);//级联对内存中和数据库中的关联对象不处理//只需在这边指定外键就行
        }
    }
}
