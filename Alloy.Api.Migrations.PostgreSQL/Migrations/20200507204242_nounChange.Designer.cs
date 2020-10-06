﻿/*
Crucible
Copyright 2020 Carnegie Mellon University.
NO WARRANTY. THIS CARNEGIE MELLON UNIVERSITY AND SOFTWARE ENGINEERING INSTITUTE MATERIAL IS FURNISHED ON AN "AS-IS" BASIS. CARNEGIE MELLON UNIVERSITY MAKES NO WARRANTIES OF ANY KIND, EITHER EXPRESSED OR IMPLIED, AS TO ANY MATTER INCLUDING, BUT NOT LIMITED TO, WARRANTY OF FITNESS FOR PURPOSE OR MERCHANTABILITY, EXCLUSIVITY, OR RESULTS OBTAINED FROM USE OF THE MATERIAL. CARNEGIE MELLON UNIVERSITY DOES NOT MAKE ANY WARRANTY OF ANY KIND WITH RESPECT TO FREEDOM FROM PATENT, TRADEMARK, OR COPYRIGHT INFRINGEMENT.
Released under a MIT (SEI)-style license, please see license.txt or contact permission@sei.cmu.edu for full terms.
[DISTRIBUTION STATEMENT A] This material has been approved for public release and unlimited distribution.  Please see Copyright notice for non-US Government use and distribution.
Carnegie Mellon(R) and CERT(R) are registered in the U.S. Patent and Trademark Office by Carnegie Mellon University.
DM20-0181
*/

// <auto-generated />
using System;
using Alloy.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Alloy.Api.Migrations.PostgreSQL.Migrations
{
    [DbContext(typeof(AlloyContext))]
    [Migration("20200507204242_nounChange")]
    partial class nounChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Alloy.Api.Data.Models.EventEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnName("date_created");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnName("date_modified");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("end_date");

                    b.Property<Guid?>("EventTemplateId")
                        .HasColumnName("event_template_id");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnName("exercise_id");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnName("expiration_date");

                    b.Property<int>("FailureCount")
                        .HasColumnName("failure_count");

                    b.Property<int>("InternalStatus")
                        .HasColumnName("internal_status");

                    b.Property<int>("LastEndInternalStatus")
                        .HasColumnName("last_end_internal_status");

                    b.Property<int>("LastEndStatus")
                        .HasColumnName("last_end_status");

                    b.Property<int>("LastLaunchInternalStatus")
                        .HasColumnName("last_launch_internal_status");

                    b.Property<int>("LastLaunchStatus")
                        .HasColumnName("last_launch_status");

                    b.Property<DateTime?>("LaunchDate")
                        .HasColumnName("launch_date");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnName("modified_by");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<Guid?>("RunId")
                        .HasColumnName("run_id");

                    b.Property<Guid?>("SessionId")
                        .HasColumnName("session_id");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnName("status_date");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("Username")
                        .HasColumnName("username");

                    b.Property<Guid?>("WorkspaceId")
                        .HasColumnName("workspace_id");

                    b.HasKey("Id");

                    b.HasIndex("EventTemplateId");

                    b.ToTable("events");
                });

            modelBuilder.Entity("Alloy.Api.Data.Models.EventTemplateEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnName("date_created");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnName("date_modified");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<Guid?>("DirectoryId")
                        .HasColumnName("directory_id");

                    b.Property<int>("DurationHours")
                        .HasColumnName("duration_hours");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnName("exercise_id");

                    b.Property<bool>("IsPublished")
                        .HasColumnName("is_published");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnName("modified_by");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<Guid?>("ScenarioId")
                        .HasColumnName("scenario_id");

                    b.Property<bool>("UseDynamicHost")
                        .HasColumnName("use_dynamic_host");

                    b.HasKey("Id");

                    b.ToTable("event_templates");
                });

            modelBuilder.Entity("Alloy.Api.Data.Models.EventEntity", b =>
                {
                    b.HasOne("Alloy.Api.Data.Models.EventTemplateEntity", "EventTemplate")
                        .WithMany()
                        .HasForeignKey("EventTemplateId");
                });
#pragma warning restore 612, 618
        }
    }
}
