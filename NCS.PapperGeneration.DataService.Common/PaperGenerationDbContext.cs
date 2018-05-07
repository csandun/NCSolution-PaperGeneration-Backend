// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaperGenerationDbContext.cs" company="">
//   
// </copyright>
// <summary>
//   The paper generation db context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using NCS.PaperGeneration.Entities.Entities;

namespace NCS.PapperGeneration.DataService.Common
{
    using System.Data.Entity;

    /// <summary>
    /// The paper generation db context.
    /// </summary>
    public class PaperGenerationDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaperGenerationDbContext"/> class.
        /// </summary>
        public PaperGenerationDbContext() : base("PaperGenerationDbContext")
        {
            Database.SetInitializer<PaperGenerationDbContext>(null);
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<UserExamAttempt> UserExamAttempts { get; set; }
        public DbSet<UserExamAttemptQuestion> UserExamAttemptQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Algorithms> Algorithms { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>().ToTable("Exam");
            modelBuilder.Entity<UserExamAttempt>().ToTable("UserExamAttempt");
            modelBuilder.Entity<UserExamAttemptQuestion>().ToTable("UserExamAttemptQuestion");                
            modelBuilder.Entity<Question>().ToTable("Question");
            modelBuilder.Entity<Choice>().ToTable("Choice");
            modelBuilder.Entity<Chapter>().ToTable("Chapter");
            modelBuilder.Entity<Section>().ToTable("Sections");
            modelBuilder.Entity<Algorithms>().ToTable("Algorithms");
            modelBuilder.Entity<LoginUser>().ToTable("LoginUser");
        }
    }
}
