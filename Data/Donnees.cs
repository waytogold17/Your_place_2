using hotellerie.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotellerie.Data
{
    public class Donnees
    {
        string dbPath;
        private SQLiteConnection conn;

        public Donnees (String dbPath)
        {
            this.dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection (dbPath);
            conn.CreateTable<User>();
        }
        public List<User> GetUsers()
        {
            Init();
            return conn.Table<User>().ToList();
        }
        public void Add (User user)
        {
            conn = new SQLiteConnection(dbPath);
            conn.Insert(user);
        }
    }
}
