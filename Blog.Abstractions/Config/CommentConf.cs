using Blog.Abstractions.Entitys;
using Blog.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Blog.Abstractions.Config
{
    public class CommentConf : EntityTypeConfigurationBase<Comment, int>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Comment> builder)
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

            builder.Property(x => x.Memberid).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MemberName).HasMaxLength(500).IsRequired();
            builder.Property(x => x.BlogNum).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Commentid).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ToMemberid).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Avatar).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(500).IsRequired();

            // builder.HasOne<Bloginfo>(en => en.Bloginfo).WithMany(x => x.CommentList).HasForeignKey(x => x.BlogNum);//只需在这边指定外键就行
        }
    }
}
