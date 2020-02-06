using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrBackEnd.netCore.Entitys;

namespace HrBackEnd.netCore.Repository
{
    public class HRDBContext_12 : DbContext
    {
        public HRDBContext_12(DbContextOptions<HRDBContext_12> options) : base(options)
        {

        }

        public DbSet<Candidate> candidates { get; set; }
        public DbSet<CandidateHistory> candidatesHistores { get; set; }
        public DbSet<CandidateInterviewer> CandidateInterviewers { get; set; }
        public DbSet<CandidateProjectSession> candidateProjects { get; set; }
        public DbSet<Interviewer> interviewers { get; set; }
        public DbSet<JobPost> jobPosts{ get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectSession> projectSessions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPrivilages> userPrivilages { get; set; }
        public DbSet<UserUserPrivilages> UserUserPrivilages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.HasKey(c => c.idCandidate);

                entity.Property(c => c.expectedSalary);

                entity.Property(c => c.salary);

                entity.Property(c => c.firstName);

                entity.Property(c => c.lastName);

                entity.Property(c => c.status);

                entity.Property(c => c.CV);

                entity.Property(c => c.coverLetter);

                entity.Property(c => c.phoneDate);

                entity.Property(c => c.interviewDate);

                entity.Property(c => c.cobyDate);

                entity.Property(c => c.startDate);

                entity.HasOne(c => c.postAcceptedNavigator)
                .WithMany(p => p.candidatesNavigator)
                .HasForeignKey(c => c.idPostAccepted);            
            });

            modelBuilder.Entity<CandidateHistory>(entity =>
            {
                entity.HasKey(CH => CH.idHistory);

                entity.Property(CH => CH.jsonChangesHistory);

                entity.HasOne(Ch => Ch.candidateNavigator)
                .WithMany(c => c.candidateHistoriesNavigator)
                .HasForeignKey(Ch => Ch.idCandidate);
            });

            modelBuilder.Entity<CandidateInterviewer>(entity =>
            {
                entity.HasKey(ci => new { ci.idCandidate, ci.idInterviewer });

                entity.HasOne(ci => ci.CandidateNavigator)
                .WithMany(c => c.candidateInterviewersNavigator)
                .HasForeignKey(ci => ci.idCandidate);

                entity.HasOne(ci => ci.InterviewerNavigator)
                .WithMany(i => i.candidatesInterviewerNavigator)
                .HasForeignKey(ci => ci.idInterviewer);
            });

            modelBuilder.Entity<CandidateProjectSession>(entity =>
            {
                entity.HasKey(cp => new { cp.idCandidate, cp.idProjectSession });

                entity.HasOne(cp => cp.candidateNavigator)
                .WithMany(c => c.candidateProjectsSessionsNavigator)
                .HasForeignKey(cp => cp.idCandidate);

                entity.HasOne(cp => cp.projectSessionNavigator)
                .WithMany(ps => ps.candidatesProjectSessionNavigator)
                .HasForeignKey(cp => cp.idProjectSession);
            });

            modelBuilder.Entity<Interviewer>(entity =>
            {
                entity.HasKey(i => i.idInterviewer);

                entity.Property(i => i.interviewerName);
            });

            modelBuilder.Entity<JobPost>(entity =>
            {
                entity.HasKey(jp => jp.IdJobPost);

                entity.Property(jp => jp.jsonChangesHistory);

                entity.Property(jp => jp.department);

                entity.Property(jp => jp.domain);

                entity.Property(jp => jp.platform);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(p => p.idProject);

                entity.Property(p => p.projectName);
            });

            modelBuilder.Entity<ProjectSession>(entity =>
            {
                entity.HasKey(ps => ps.IdProjectSession);

                entity.Property(ps => ps.startDateSession);

                entity.Property(ps => ps.endDateSession);

                entity.HasOne(ps => ps.projectNavigator)
                .WithMany(p => p.projectSessionNavigator)
                .HasForeignKey(ps => ps.idProject);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.idUser);

                entity.Property(u => u.userName);

                entity.Property(u => u.lastName);

                entity.Property(u => u.password);

                entity.Property(u => u.profileImage);
            });

            modelBuilder.Entity<UserPrivilages>(entity =>
            {
                entity.HasKey(up => up.idUserPrivilage);

            entity.Property(up => up.domain);
            });

            modelBuilder.Entity<UserUserPrivilages>(entity =>
            {
                entity.HasKey(uup => new { uup.idUser, uup.idUserPrivilage });

                entity.Property(uup => uup.isOnlyView);

                entity.HasOne(uup => uup.userNavigator)
                .WithMany(u => u.userUserPrivilagesNavigator)
                .HasForeignKey(uup => uup.idUser);

                entity.HasOne(uup => uup.userPrivilagesNavigator)
                .WithMany(up => up.usersUserPrivilagesNavigator)
                .HasForeignKey(uup => uup.idUserPrivilage);
            });
        }
    }
}
