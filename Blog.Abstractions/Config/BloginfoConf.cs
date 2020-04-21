using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Abstractions.Config
{
    /// <summary>
    /// bloginfo配置
    /// </summary>
    public class BloginfoConf : EntityTypeConfigurationBase<Bloginfo, int>
    {
        public override void Configure(EntityTypeBuilder<Bloginfo> builder)
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

            builder.Property(x => x.Title).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Sorc).HasColumnType("tinyint(4)").IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Views).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.BlogNum).HasMaxLength(50).IsRequired();


            //builder.HasOne<Blogcontent>(en => en.Content).WithOne(x => x.Bloginfo);
            builder.HasOne<Category>(x => x.Category).WithMany().HasForeignKey(x => x.Type);
            //builder.HasMany<ArticlePraise>(x => x.ArticlePraises).WithOne(x => x.Bloginfo);
            //builder.HasMany<Comment>(x => x.CommentList).WithOne(x => x.Bloginfo);
        }
    }
}
