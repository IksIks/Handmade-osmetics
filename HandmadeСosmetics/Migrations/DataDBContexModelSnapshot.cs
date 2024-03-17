﻿// <auto-generated />
using HandmadeСosmetics.DataCotnext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HandmadeСosmetics.Migrations
{
    [DbContext(typeof(DataDBContex))]
    partial class DataDBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<double>("CostPerUnitMeasurement")
                        .HasColumnType("double precision");

                    b.Property<double>("IngridientCost")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("PackageWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("UnitMeasurement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("NetCost")
                        .HasColumnType("double precision");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.WeightInRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("IngredientId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipesId")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipesId");

                    b.ToTable("WeightInRecipe");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.HasKey("IngredientsId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.Product", b =>
                {
                    b.HasOne("HandmadeСosmetics.Models.MaterialsAndProducts.Recipe", "Recipe")
                        .WithMany("Products")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.WeightInRecipe", b =>
                {
                    b.HasOne("HandmadeСosmetics.Models.MaterialsAndProducts.Ingredient", "Ingredient")
                        .WithMany("WeightInRecipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HandmadeСosmetics.Models.MaterialsAndProducts.Recipe", "Recipes")
                        .WithMany("WeightInRecipes")
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("HandmadeСosmetics.Models.MaterialsAndProducts.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HandmadeСosmetics.Models.MaterialsAndProducts.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.Ingredient", b =>
                {
                    b.Navigation("WeightInRecipes");
                });

            modelBuilder.Entity("HandmadeСosmetics.Models.MaterialsAndProducts.Recipe", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("WeightInRecipes");
                });
#pragma warning restore 612, 618
        }
    }
}
