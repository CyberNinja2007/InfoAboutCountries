using System.Data;

namespace InfoAboutCountries
{
    public class Creator
    {
         public static DataTable CreateCountryTable()
         { 
             DataTable resultTable = new DataTable();
                    
             resultTable.Columns.Add("Название");
             resultTable.Columns.Add("Код_страны");
             resultTable.Columns.Add("Столица");
             resultTable.Columns.Add("Площадь");
             resultTable.Columns.Add("Население");
             resultTable.Columns.Add("Регион");
        
             return resultTable;
         }
    }
}