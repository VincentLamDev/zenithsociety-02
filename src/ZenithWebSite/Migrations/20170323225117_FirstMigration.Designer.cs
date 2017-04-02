using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ZenithWebSite.Models;

namespace ZenithWebSite.Migrations
{
    [DbContext(typeof(ZenithContext))]
    [Migration("20170323225117_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("ZenithWebSite.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("ZenithWebSite.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("End");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Start");

                    b.HasKey("EventId");

                    b.HasIndex("ActivityId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ZenithWebSite.Models.Event", b =>
                {
                    b.HasOne("ZenithWebSite.Models.Activity", "Activity")
                        .WithMany("Events")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
