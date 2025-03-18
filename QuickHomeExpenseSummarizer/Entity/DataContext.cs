using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickHomeExpenseSummarizer.Entity
{
    public class DataContext : DbContext
    {
        public DbSet<SourceFolder> SourceFolders { get; set; }

        public DataContext()
        {
            string appName = "QuickHomeExpenseSummarizer";
            var appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                           appName);
            string dbFileName = "QHESummarizer.db";
            DbPath = Path.Join(appDataPath, dbFileName);

            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            if (!File.Exists(DbPath))
            {
                //!FIX: copy in an empty database from the project resources
                // this will have all of the migration tables too
                //!FIX: should we wrap this stuff up in the installer vs. in code?
            }

            //
            // FIRST TIME: run this in PMC window
            // Add-Migration InitialCreate
            // Update-Database
            //
        }

        /* !FIX: copy QHESummarizer.db to folder if no file exists there - first time install
         * FROM: https://stackoverflow.com/questions/4405813/copying-embedded-resource-as-file-to-disk-in-c-sharp
            var stream = assembly.GetManifestResourceStream("name of the manifest resourse");
            var fileStream = File.Create(@"C:\Test.xml");
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(fileStream);
            fileStream.Close();
         */

        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        //!FIX: https://stackoverflow.com/questions/49592274/how-to-create-autoincrement-column-in-sqlite-using-ef-core
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Explicitly tell it to generate a new value when it's added (code-first approach)
            modelBuilder.Entity<SourceFolder>()
                .Property(e => e.SourceFolderId)
                .ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }
    }
}
