using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Phd_Port.Data;

public partial class BookmarkhubContext : DbContext
{
    public BookmarkhubContext()
    {
    }

    public BookmarkhubContext(DbContextOptions<BookmarkhubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Bookmark> Bookmarks { get; set; }

    public virtual DbSet<CallForPaper> CallForPapers { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventsFavorite> EventsFavorites { get; set; }

    public virtual DbSet<Jobpost> Jobposts { get; set; }

    public virtual DbSet<Jobpoststhe> Jobpoststhes { get; set; }

    public virtual DbSet<LoginAttempt> LoginAttempts { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<UploadDetail> UploadDetails { get; set; }

    public virtual DbSet<UploadDetailsFavorite> UploadDetailsFavorites { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=bookmarkhub;user=root;password=Nemtudom11;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("accounts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aboutme)
                .HasColumnType("text")
                .HasColumnName("aboutme");
            entity.Property(e => e.ActivationCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("activation_code");
            entity.Property(e => e.Affiliation)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("affiliation");
            entity.Property(e => e.Countryoforigin)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("countryoforigin");
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("firstname");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Language)
                .HasMaxLength(450)
                .HasDefaultValueSql("''")
                .HasColumnName("language");
            entity.Property(e => e.LastSeen)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("last_seen");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("lastname");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("location");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Registered)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("registered");
            entity.Property(e => e.Rememberme)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rememberme");
            entity.Property(e => e.Researchinterest)
                .HasMaxLength(3000)
                .HasColumnName("researchinterest");
            entity.Property(e => e.Reset)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reset");
            entity.Property(e => e.TfaCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("tfa_code");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.Userstatus).HasColumnName("userstatus");
        });

        modelBuilder.Entity<Bookmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bookmarks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BmDataSource)
                .HasColumnType("text")
                .HasColumnName("bm_data_source");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.FilePath)
                .HasMaxLength(255)
                .HasColumnName("file_path");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CallForPaper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("call_for_papers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.ContactPerson)
                .HasColumnType("text")
                .HasColumnName("contact_person");
            entity.Property(e => e.Institution)
                .HasDefaultValueSql("'1'")
                .HasColumnName("institution");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.PostSubmissionTime)
                .HasColumnType("date")
                .HasColumnName("post_submission_time");
            entity.Property(e => e.SubmissionDeadline)
                .HasColumnType("date")
                .HasColumnName("submission_deadline");
            entity.Property(e => e.TimeOfEventEnd)
                .HasColumnType("date")
                .HasColumnName("time_of_event_end");
            entity.Property(e => e.TimeOfEventStart)
                .HasColumnType("date")
                .HasColumnName("time_of_event_start");
            entity.Property(e => e.TitleOfConf)
                .HasColumnType("text")
                .HasColumnName("title_of_conf");
            entity.Property(e => e.UrlLink)
                .HasColumnType("text")
                .HasColumnName("url_link");
            entity.Property(e => e.Username)
                .HasColumnType("text")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("companies");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(512)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("director");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Surename)
                .HasMaxLength(255)
                .HasColumnName("surename");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dateend)
                .HasColumnType("date")
                .HasColumnName("dateend");
            entity.Property(e => e.Datestart)
                .HasColumnType("date")
                .HasColumnName("datestart");
            entity.Property(e => e.Eventdescription)
                .HasColumnType("text")
                .HasColumnName("eventdescription");
            entity.Property(e => e.Eventlocation)
                .HasColumnType("text")
                .HasColumnName("eventlocation");
            entity.Property(e => e.Eventtype)
                .HasColumnType("text")
                .HasColumnName("eventtype");
            entity.Property(e => e.Eventurl)
                .HasColumnType("text")
                .HasColumnName("eventurl");
            entity.Property(e => e.FavText).HasMaxLength(10);
            entity.Property(e => e.Fee)
                .HasColumnType("text")
                .HasColumnName("fee");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.Mode)
                .HasColumnType("text")
                .HasColumnName("mode");
            entity.Property(e => e.Organizer)
                .HasColumnType("text")
                .HasColumnName("organizer");
            entity.Property(e => e.PostedBy)
                .HasColumnType("text")
                .HasColumnName("posted_by");
            entity.Property(e => e.SubmitDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("submit_date");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
        });

        modelBuilder.Entity<EventsFavorite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("events_favorites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Targetid).HasColumnName("targetid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Jobpost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("jobposts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.Deadline).HasColumnType("date");
            entity.Property(e => e.Institution).HasMaxLength(110);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Jobdescription).HasColumnType("text");
            entity.Property(e => e.Jobtitle).HasMaxLength(50);
            entity.Property(e => e.Keywords).HasColumnType("text");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Posteddate).HasColumnType("date");
            entity.Property(e => e.Salary).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(110)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Jobpoststhe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("jobpoststhe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Details)
                .HasMaxLength(184)
                .HasColumnName("details");
            entity.Property(e => e.Institute)
                .HasMaxLength(51)
                .HasColumnName("institute");
            entity.Property(e => e.Location)
                .HasMaxLength(36)
                .HasColumnName("location");
            entity.Property(e => e.Positionlink)
                .HasMaxLength(184)
                .HasColumnName("positionlink");
            entity.Property(e => e.Positiontitle)
                .HasMaxLength(98)
                .HasColumnName("positiontitle");
            entity.Property(e => e.Posted)
                .HasMaxLength(11)
                .HasColumnName("posted");
            entity.Property(e => e.Shortdescription)
                .HasMaxLength(145)
                .HasColumnName("shortdescription");
        });

        modelBuilder.Entity<LoginAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("login_attempts");

            entity.HasIndex(e => e.IpAddress, "ip_address").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttemptsLeft)
                .IsRequired()
                .HasDefaultValueSql("'5'")
                .HasColumnName("attempts_left");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("settings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasDefaultValueSql("'General'")
                .HasColumnName("category");
            entity.Property(e => e.SettingKey)
                .HasMaxLength(50)
                .HasColumnName("setting_key");
            entity.Property(e => e.SettingValue)
                .HasMaxLength(50)
                .HasColumnName("setting_value");
        });

        modelBuilder.Entity<UploadDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("upload_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .HasColumnName("category_name");
            entity.Property(e => e.DataSource)
                .HasMaxLength(20)
                .HasColumnName("data_source");
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .HasColumnName("data_type");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("date_added");
            entity.Property(e => e.Favorite).HasColumnName("favorite");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Keywords)
                .HasMaxLength(255)
                .HasColumnName("keywords");
            entity.Property(e => e.PostedBy).HasColumnName("posted_by");
            entity.Property(e => e.UrlLink)
                .HasMaxLength(255)
                .HasColumnName("url_link");
        });

        modelBuilder.Entity<UploadDetailsFavorite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("upload_details_favorites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Targetid).HasColumnName("targetid");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aboutme)
                .HasColumnType("text")
                .HasColumnName("aboutme");
            entity.Property(e => e.Affiliation)
                .HasColumnType("text")
                .HasColumnName("affiliation");
            entity.Property(e => e.DateAdded)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("date_added");
            entity.Property(e => e.Department)
                .HasColumnType("text")
                .HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Facebook)
                .HasMaxLength(80)
                .HasDefaultValueSql("'none'")
                .HasColumnName("facebook");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .HasDefaultValueSql("'none'")
                .HasColumnName("location");
            entity.Property(e => e.ResearchInterest)
                .HasColumnType("text")
                .HasColumnName("research_interest");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(50)
                .HasDefaultValueSql("'none'")
                .HasColumnName("twitter");
            entity.Property(e => e.Userstatus).HasColumnName("userstatus");

            entity.HasMany(d => d.Directors).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "Fav",
                    r => r.HasOne<Director>().WithMany()
                        .HasForeignKey("DirectorId")
                        .HasConstraintName("favs_ibfk_2"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("favs_ibfk_1"),
                    j =>
                    {
                        j.HasKey("UserId", "DirectorId").HasName("PRIMARY");
                        j.ToTable("favs");
                        j.HasIndex(new[] { "DirectorId" }, "director_id");
                        j.IndexerProperty<int>("UserId").HasColumnName("user_id");
                        j.IndexerProperty<int>("DirectorId").HasColumnName("director_id");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
