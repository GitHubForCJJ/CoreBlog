using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Blog.Abstractions.Config
{
    public class CategoryConf : EntityTypeConfigurationBase<Category, int>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.KID);
            builder.Property(x => x.States).IsRequired().HasColumnType("tinyint(4)").HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).IsRequired().HasColumnType("tinyint(4)").HasDefaultValue(0);
            builder.Property(x => x.CreateUserId).HasMaxLength(512).IsRequired().HasDefaultValue("1");
            builder.Property(x => x.CreateUserName).HasMaxLength(512).IsRequired().HasDefaultValue("System");
            builder.Property(x => x.UpdateTime).IsRequired().HasColumnType("timestamp").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(x => x.CreateTime).IsRequired().HasDefaultValue("1970-01-01 08:00:00");
            builder.Property(x => x.UpdateUserId).HasMaxLength(512).IsRequired().HasDefaultValue("");
            builder.Property(x => x.UpdateUserName).HasMaxLength(512).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Extend1).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Extend2).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Extend3).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Extend4).HasMaxLength(128).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Extend5).HasMaxLength(128).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Extend6).HasMaxLength(128).IsRequired().HasDefaultValue("");

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.HasData(new Category()
            {
                KID = 1,
                CreateTime = new DateTime(2019, 09, 09, 09, 09, 09),
                UpdateTime = DateTime.Now,
                Name = "efcore",
                UpdateUserId = "1",
                UpdateUserName = "System内置"
            });
        }
    }
}
