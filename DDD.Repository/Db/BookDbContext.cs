using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Repository.Db
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(string conn):base()
        {

        }


    }
}
