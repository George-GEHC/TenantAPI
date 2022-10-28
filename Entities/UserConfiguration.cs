// ----------------------------------------------------------------------------------
// <copyright company="Exesoft Inc.">
//	This code was generated by Instant Web API code automation software (https://www.InstantWebAPI.com)
//	Copyright Exesoft Inc. © 2019.  All rights reserved.
// </copyright>
// ----------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TenantAPI.Entities {
    
    
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        
        private string _schema = "dbo";
        
        public virtual void Configure(EntityTypeBuilder<User> builder) {
            Configure(builder, _schema);
        }
        
        private void Configure(EntityTypeBuilder<User> builder, string schema) {
            builder.ToTable("User", schema);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(x => x.TenantId).HasColumnName(@"TenantId").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.AuthProvider).HasColumnName(@"AuthProvider").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            builder.Property(x => x.EmailConfirmed).HasColumnName(@"EmailConfirmed").HasColumnType("bit").IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar").IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.PasswordHash).HasColumnName(@"PasswordHash").HasColumnType("nvarchar(max)").IsRequired(false);
            builder.Property(x => x.LockoutEnabled).HasColumnName(@"LockoutEnabled").HasColumnType("bit").IsRequired();
            builder.Property(x => x.AccessFailedCount).HasColumnName(@"AccessFailedCount").HasColumnType("int").IsRequired();
            builder.Property(x => x.LockoutEnd).HasColumnName(@"LockoutEnd").HasColumnType("datetimeoffset").IsRequired(false);
            builder.Property(x => x.Token).HasColumnName(@"Token").HasColumnType("nvarchar").IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.TokenDate).HasColumnName(@"TokenDate").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.LastLoginDate).HasColumnName(@"LastLoginDate").HasColumnType("datetime").IsRequired(false);

            //Foreign keys
            builder.HasOne(a => a.Tenant).WithMany(b => b.Users).HasForeignKey(c => c.TenantId).OnDelete(DeleteBehavior.Restrict); // FK_User_Tenant
            builder.HasOne(a => a.AuthProvider_AuthProvider).WithMany(b => b.Users).HasForeignKey(c => c.AuthProvider).OnDelete(DeleteBehavior.Restrict); // FK_User_AuthProvider
            builder.HasOne(a => a.UserTitle).WithMany(b => b.Users).HasForeignKey(c => c.TitleId).OnDelete(DeleteBehavior.Restrict); // FK_User_UserTitle
        }
    }
}

