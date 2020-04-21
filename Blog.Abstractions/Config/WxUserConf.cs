using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Blog.EntityFramework;
using Blog.Abstractions.Entitys;
using Microsoft.EntityFrameworkCore;
namespace Blog.Abstractions.Config
{
    public class WxUserConf : EntityTypeConfigurationBase<WxUser, int>
    {
        /// <summary>
        /// 重写以实现实体类型各个属性的数据库配置
        /// </summary>
        /// <param name="builder">实体类型创建器</param>
        public override void Configure(EntityTypeBuilder<WxUser> builder)
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

            builder.Property(x => x.Openid).HasMaxLength(500).IsRequired();
            builder.Property(x => x.NickName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Sex).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Province).HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(50).IsRequired();
            builder.Property(x => x.HeadImgUrl).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Privilege).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Unionid).HasMaxLength(500).IsRequired();


        }
    }
}
