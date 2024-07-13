using DBCrudApp.Repositories;
namespace DBCrudApp;


public static class Program
{
    public static void Main(string[] args)
    {
        //Add ANother table of PersonAttendance With Columns {Id, PersonId, AttendanceDateTime, IsActive}
        //write CreateAttendance and GetData functions
        //Make sure these work properly

        var list = PersonRepository.GetData();

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Id}\t|\t{item.FirstName} {item.LastName}\t|\t{item.Email}\t|\t{item.CNIC}\t|\t{item.DOB.ToString("dd-MMM-yyyy")}\t|\t ");
        }
    }
}
