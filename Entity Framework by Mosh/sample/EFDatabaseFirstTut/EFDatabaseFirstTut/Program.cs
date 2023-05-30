using EFDatabaseFirstTut.EFDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirstTut
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a instance of DbContext object
            // DBContext class name - EF_DataBaseFirstTutEntities1

            EF_DataBaseFirstTutEntities1 dbcontext = new EF_DataBaseFirstTutEntities1();

            // create a new post 

            var post = new master_post()
            {
                Body = "Test Description",
                DatePublished = DateTime.Now,
                Title = "Post1",
                PostId = 1

            };

            // add new post in db using dbContext instance
            // added to dbset
            dbcontext.master_post.Add(post);
            //push the data into db
            dbcontext.SaveChanges();





        }
    }
}
