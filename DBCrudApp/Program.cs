using DBCrudApp.Repositories;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DBCrudApp;


public static class Program
{
    public static void Main(string[] args)
    {

        var list = PersonRepository.GetData();

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Id}\t|\t{item.FirstName} {item.LastName}\t|\t{item.Email}\t|\t{item.CNIC}\t|\t{item.DOB.ToString("dd-MMM-yyyy")}\t|\t ");
        }

    }


}
