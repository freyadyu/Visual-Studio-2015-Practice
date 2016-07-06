using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search.Model;
using Search.Data;

namespace Search.Services
{
    public class SearchServices
    {
        public void Search(int Id)
        {
            Index index = new Index();
            index.id = Id;

            Dbhelper dbHelper = new Dbhelper();
            dbHelper.searchByID(index);
        }
    }
}
