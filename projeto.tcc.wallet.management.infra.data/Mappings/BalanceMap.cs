using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;

namespace projeto.tcc.wallet.management.infra.data.Mappings
{
	public class BalanceMap : IEntityTypeConfiguration<UserBalance>
	{
		public void Configure(EntityTypeBuilder<UserBalance> builder)
		{
			builder.ToTable("Balance");
			builder.HasKey(balance => balance.Id);
			builder.Property<Guid>("_userId")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("UserId");
			
			builder.Property<decimal>("_totalPatrimony")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("TotalProperty");
			
			builder.Property<decimal>("_transientBalance")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("TrasientBalance");
			
		}
	}
}