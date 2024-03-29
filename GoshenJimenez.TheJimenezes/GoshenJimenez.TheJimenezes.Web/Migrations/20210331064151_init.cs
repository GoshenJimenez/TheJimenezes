﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoshenJimenez.TheJimenezes.Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatThreads",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatThreads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Columns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 75, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 150, nullable: true),
                    ColumnType = table.Column<int>(nullable: false),
                    BannerUrl = table.Column<string>(maxLength: 500, nullable: true),
                    IconUrl = table.Column<string>(maxLength: 500, nullable: true),
                    Layout = table.Column<string>(maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ChatThreadId = table.Column<Guid>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_ChatThreads_ChatThreadId",
                        column: x => x.ChatThreadId,
                        principalTable: "ChatThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    ChatThreadId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatUsers_ChatThreads_ChatThreadId",
                        column: x => x.ChatThreadId,
                        principalTable: "ChatThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 75, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 150, nullable: true),
                    Author = table.Column<string>(maxLength: 30, nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    Content = table.Column<string>(maxLength: 5000, nullable: true),
                    ColumnId = table.Column<Guid>(nullable: false),
                    IsStarred = table.Column<bool>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Rating = table.Column<decimal>(nullable: false),
                    Views = table.Column<int>(nullable: false),
                    Comments = table.Column<int>(nullable: false),
                    MembersOnly = table.Column<bool>(nullable: false),
                    BannerUrl = table.Column<string>(maxLength: 500, nullable: true),
                    Layout = table.Column<string>(maxLength: 75, nullable: true),
                    LikesEnabled = table.Column<bool>(nullable: false),
                    RatingsEnabled = table.Column<bool>(nullable: false),
                    CommentsEnabled = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Columns_ColumnId",
                        column: x => x.ColumnId,
                        principalTable: "Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(maxLength: 20, nullable: true),
                    Value = table.Column<string>(maxLength: 1000, nullable: true),
                    LoginType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    AttachmentUrl = table.Column<string>(maxLength: 500, nullable: true),
                    ContentType = table.Column<string>(maxLength: 20, nullable: true),
                    Caption = table.Column<string>(maxLength: 150, nullable: true),
                    SortOrder = table.Column<int>(nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    LikesEnabled = table.Column<bool>(nullable: false),
                    CommentsEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    MaskUser = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 500, nullable: true),
                    IsPublished = table.Column<bool>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    LikesEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    MaskUser = table.Column<bool>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    IsCounted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "BannerUrl", "ColumnType", "CreatedAt", "IconUrl", "Layout", "SubTitle", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"), null, 0, new DateTime(2021, 3, 31, 6, 41, 50, 40, DateTimeKind.Utc).AddTicks(5709), "", null, "", "Projects", new DateTime(2021, 3, 31, 6, 41, 50, 40, DateTimeKind.Utc).AddTicks(6892) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be201"), null, 0, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2845), "", null, "", "Programming", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2863) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be202"), null, 0, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2961), "", null, "", "Tech Talk", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2962) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be203"), null, 1, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2970), "", null, "", "Parallax", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2971) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be204"), null, 1, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2977), "", null, "", "Parallax II", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2978) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be205"), null, 2, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2990), "", null, "", "Travel Logs", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2991) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be206"), null, 2, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2996), "", null, "", "Food Reviews", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(2997) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be207"), null, 3, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3002), "", null, "", "Fambam!", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3004) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be208"), null, 3, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3008), "", null, "", "Xiah's World", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3010) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be209"), null, 3, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3017), "", null, "", "Ayu's Corner", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3018) },
                    { new Guid("12febb22-f596-4b1e-b0a8-b11ad54be210"), null, 3, new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3023), "", null, "", "Sights and Visions", new DateTime(2021, 3, 31, 6, 41, 50, 41, DateTimeKind.Utc).AddTicks(3024) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BannerUrl", "ColumnId", "Comments", "CommentsEnabled", "Content", "CreatedAt", "IsStarred", "Layout", "Likes", "LikesEnabled", "MembersOnly", "Rating", "RatingsEnabled", "Status", "SubTitle", "Title", "Type", "UpdatedAt", "UserId", "Views" },
                values: new object[] { new Guid("13febb22-f596-4b1e-b0a8-b11ad54be200"), "Goshen", null, new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"), 0, false, null, new DateTime(2021, 3, 31, 6, 41, 50, 44, DateTimeKind.Utc).AddTicks(4283), false, null, 0, false, false, 0m, false, 1, "Project 1", "Project 1", 0, new DateTime(2021, 3, 31, 6, 41, 50, 44, DateTimeKind.Utc).AddTicks(4302), null, 0 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BannerUrl", "ColumnId", "Comments", "CommentsEnabled", "Content", "CreatedAt", "IsStarred", "Layout", "Likes", "LikesEnabled", "MembersOnly", "Rating", "RatingsEnabled", "Status", "SubTitle", "Title", "Type", "UpdatedAt", "UserId", "Views" },
                values: new object[] { new Guid("13febb22-f596-4b1e-b0a8-b11ad54be201"), "Tere", null, new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"), 0, false, null, new DateTime(2021, 3, 31, 6, 41, 50, 44, DateTimeKind.Utc).AddTicks(9769), false, null, 0, false, false, 0m, false, 1, "Project 2", "Project 2", 0, new DateTime(2021, 3, 31, 6, 41, 50, 44, DateTimeKind.Utc).AddTicks(9777), null, 0 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BannerUrl", "ColumnId", "Comments", "CommentsEnabled", "Content", "CreatedAt", "IsStarred", "Layout", "Likes", "LikesEnabled", "MembersOnly", "Rating", "RatingsEnabled", "Status", "SubTitle", "Title", "Type", "UpdatedAt", "UserId", "Views" },
                values: new object[] { new Guid("13febb22-f596-4b1e-b0a8-b11ad54be202"), "Aya", null, new Guid("12febb22-f596-4b1e-b0a8-b11ad54be200"), 0, false, null, new DateTime(2021, 3, 31, 6, 41, 50, 44, DateTimeKind.Utc).AddTicks(9884), false, null, 0, false, false, 0m, false, 1, "Project 3", "Project 3", 0, new DateTime(2021, 3, 31, 6, 41, 50, 44, DateTimeKind.Utc).AddTicks(9886), null, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_PostId",
                table: "Attachments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ChatThreadId",
                table: "ChatMessages",
                column: "ChatThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_UserId",
                table: "ChatMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUsers_ChatThreadId",
                table: "ChatUsers",
                column: "ChatThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUsers_UserId",
                table: "ChatUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ColumnId",
                table: "Posts",
                column: "ColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PostId",
                table: "Ratings",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DropTable(
                name: "ChatUsers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "ChatThreads");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
