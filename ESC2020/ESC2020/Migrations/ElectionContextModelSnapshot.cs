﻿// <auto-generated />
using System;
using ESC2020.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ESC2020.Migrations
{
    [DbContext(typeof(ElectionContext))]
    partial class ElectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ESC2020.Model.Election", b =>
                {
                    b.Property<int>("ElectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CodeElection")
                        .HasColumnType("text");

                    b.Property<int?>("ElectedId")
                        .HasColumnType("integer");

                    b.Property<int>("ElectionPhaseId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HostId")
                        .HasColumnType("integer");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Mission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Responsability")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ElectionId");

                    b.HasIndex("ElectedId");

                    b.HasIndex("ElectionPhaseId");

                    b.HasIndex("HostId");

                    b.ToTable("Election");
                });

            modelBuilder.Entity("ESC2020.Model.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("DateMessage")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Sentence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("MessageId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ESC2020.Model.Notification", b =>
                {
                    b.Property<int>("NotifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("DateNotification")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("NotifId");

                    b.HasIndex("ElectionId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("ESC2020.Model.Opinion", b =>
                {
                    b.Property<int>("OpinionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("ConcernedId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("DateOpinion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("OpinionId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ConcernedId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("TypeId");

                    b.ToTable("Opinion");
                });

            modelBuilder.Entity("ESC2020.Model.Participant", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("ElectionId")
                        .HasColumnType("integer");

                    b.Property<bool>("HasTalked")
                        .HasColumnType("boolean");

                    b.Property<int>("VoteCounter")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "ElectionId");

                    b.HasIndex("ElectionId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("ESC2020.Model.Phase", b =>
                {
                    b.Property<int>("PhaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PhaseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PhaseId");

                    b.ToTable("Phase");
                });

            modelBuilder.Entity("ESC2020.Model.TypeOpinion", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("OpinionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TypeId");

                    b.ToTable("TypeOpinion");
                });

            modelBuilder.Entity("ESC2020.Model.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte[]>("Avatar")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ESC2020.Model.Election", b =>
                {
                    b.HasOne("ESC2020.Model.Users", "ElectedElection")
                        .WithMany("ElectedElection")
                        .HasForeignKey("ElectedId");

                    b.HasOne("ESC2020.Model.Phase", "Phase")
                        .WithMany("Election")
                        .HasForeignKey("ElectionPhaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Users", "HostElection")
                        .WithMany("HostElection")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Message", b =>
                {
                    b.HasOne("ESC2020.Model.Election", "Election")
                        .WithMany("Message")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Users", "User")
                        .WithMany("Message")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Notification", b =>
                {
                    b.HasOne("ESC2020.Model.Election", "Election")
                        .WithMany("Notification")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Opinion", b =>
                {
                    b.HasOne("ESC2020.Model.Users", "AuthorOpinion")
                        .WithMany("AuthorOpinion")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Users", "ConcernedOpinion")
                        .WithMany("ConcernedOpinion")
                        .HasForeignKey("ConcernedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Election", "Election")
                        .WithMany("Opinion")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.TypeOpinion", "TypeOpinion")
                        .WithMany("Opinion")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ESC2020.Model.Participant", b =>
                {
                    b.HasOne("ESC2020.Model.Election", "Elections")
                        .WithMany("Participant")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESC2020.Model.Users", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
