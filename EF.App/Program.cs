using EF.Lib;
using Microsoft.EntityFrameworkCore;


namespace EF.App
{
    class Program
    {
        static void Main()
        {
            MSDataBase ms = new MSDataBase();
            MySQLDataBase my = new MySQLDataBase();
            ms.Database.Migrate();
            my.Database.Migrate();

        }
    }

}
