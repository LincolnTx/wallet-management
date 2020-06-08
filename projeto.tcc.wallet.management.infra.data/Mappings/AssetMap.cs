using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate;

namespace projeto.tcc.wallet.management.infra.data.Mappings
{
	public class AssetMap : IEntityTypeConfiguration<Asset>
	{
		public void Configure(EntityTypeBuilder<Asset> builder)
		{
			builder.ToTable("Asset");
			builder.HasKey(balance => balance.Id);
			builder.Property<Guid>("_userId")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("UserId");
			
			builder.Property<string>("_name")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("Name");
			
			builder.Property<string>("_symbol")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("Symbol");
			
			builder.Property<decimal>("_startPrice")
				.UsePropertyAccessMode(PropertyAccessMode.Field)
				.HasColumnName("StartPrice");
		}
	}
}