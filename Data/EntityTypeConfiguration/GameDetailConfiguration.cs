namespace Data.EntityTypeConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class GameDetailConfiguration : IEntityTypeConfiguration<GameDetail>
    {
        public void Configure(EntityTypeBuilder<GameDetail> builder)
        {
            builder.HasKey(tcm => new { tcm.GameId, tcm.DetailId });

            builder.HasOne(tcm => tcm.Game)
                .WithMany(t => t.GameDetails)
                .HasForeignKey(tcm => tcm.GameId);

            builder.HasOne(tcm => tcm.Detail)
                .WithMany(tc => tc.GameDetails)
                .HasForeignKey(tcm => tcm.DetailId);
        }
    }
}
