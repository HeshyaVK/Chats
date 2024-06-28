﻿// <auto-generated />
using System;
using ChartsApi.dbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChartsApi.Migrations
{
    [DbContext(typeof(DashboardContext))]
    partial class DashboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChartsApi.Models.DashboardWidget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BorderColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChartType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatasetData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatasetLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Fill")
                        .HasColumnType("bit");

                    b.Property<string>("Labels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionCol")
                        .HasColumnType("int");

                    b.Property<int>("PositionRow")
                        .HasColumnType("int");

                    b.Property<int>("SizeCols")
                        .HasColumnType("int");

                    b.Property<int>("SizeRows")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DashboardWidgets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackgroundColor = "#FF6384,#36A2EB,#FFCE56",
                            ChartType = "pie",
                            DatasetData = "300,50,100",
                            Labels = "A,B,C",
                            PositionCol = 0,
                            PositionRow = 0,
                            SizeCols = 3,
                            SizeRows = 2
                        },
                        new
                        {
                            Id = 2,
                            BackgroundColor = "#FF6384,#36A2EB,#FFCE56",
                            ChartType = "bar",
                            DatasetData = "65,59,80",
                            DatasetLabel = "Sales",
                            Labels = "January,February,March",
                            PositionCol = 9,
                            PositionRow = 0,
                            SizeCols = 3,
                            SizeRows = 2
                        },
                        new
                        {
                            Id = 3,
                            BackgroundColor = "#FF6384,#36A2EB,#FFCE56",
                            BorderColor = "#4bc0c0",
                            ChartType = "line",
                            DatasetData = "65,59,80",
                            DatasetLabel = "Sales",
                            Fill = false,
                            Labels = "January,February,March",
                            PositionCol = 0,
                            PositionRow = 2,
                            SizeCols = 3,
                            SizeRows = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
