using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Blog.Abstractions.Config
{
    public class Fd_sys_operationlogConf : EntityTypeConfigurationBase<Operationlog, int>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Operationlog> builder)
        {
            builder.HasKey(x => x.KID);
            builder.Property(x => x.States).IsRequired().HasColumnType("tinyint(4)").HasDefaultValue(0);
            builder.Property(x => x.CreateUserId).HasMaxLength(512).IsRequired().HasDefaultValue("1");
            builder.Property(x => x.CreateUserName).HasMaxLength(512).IsRequired().HasDefaultValue("System");
            builder.Property(x => x.CreateUserId).IsRequired().HasDefaultValue("1");
            builder.Property(x => x.CreateUserName).IsRequired().HasDefaultValue("System");

        }
    }
}
