using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(category => category.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("CategoryId").IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Category_CategoryId") { IsUnique = true }));
            Property(category => category.CategoryName).IsRequired().HasMaxLength(256);
            Property(category => category.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(category => category.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(category => category.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}