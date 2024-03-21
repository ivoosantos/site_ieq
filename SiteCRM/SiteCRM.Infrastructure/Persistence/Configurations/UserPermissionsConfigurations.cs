using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Infrastructure.Persistence.Configurations
{
	public class UserPermissionsConfigurations : IEntityTypeConfiguration<UserPermissions>
	{
		public void Configure(EntityTypeBuilder<UserPermissions> builder)
		{
			builder.HasKey(x => x.Id);
		}
	}
}
