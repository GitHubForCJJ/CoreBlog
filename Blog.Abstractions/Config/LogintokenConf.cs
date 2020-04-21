using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Blog.Abstractions.Config
{
    public class LogintokenConf : EntityTypeConfigurationBase<Logintoken, int>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Logintoken> builder)
        {
            builder.HasKey(x => x.KID);
            builder.Property(x => x.States).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(0);
        }
    }
}
