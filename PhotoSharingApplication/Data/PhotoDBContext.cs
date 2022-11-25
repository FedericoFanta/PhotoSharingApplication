using PhotoSharingApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Data
{
    public class PhotoDBContext : DbContext
    {
        public PhotoDBContext(): base ("keyPhotoDB") { }

        public DbSet<Photo> photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}