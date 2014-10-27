﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;
using Model;
using System.Diagnostics;

namespace BLL
{
    public class GenreBLL
    {
        StoreContext db = new StoreContext();

        public DbSet<Genre> getGenres()
        {
            return db.Genres;
        }
        
        public Genre getSelectedGenre(string genre)
        {
            var genreModel = db.getSelectedGenre(genre);
            return genreModel;
        }
    }

}
