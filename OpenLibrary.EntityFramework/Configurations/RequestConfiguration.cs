using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class RequestConfiguration : EntityTypeConfiguration<Request>
    {
        public RequestConfiguration()
        {
            Property(request => request.RequestId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("RequestId").IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Request_RequestId") { IsUnique = true }));
            Property(request => request.Description).IsRequired().HasMaxLength(1024);


            Property(request => request.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(request => request.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(request => request.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(request => request.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}