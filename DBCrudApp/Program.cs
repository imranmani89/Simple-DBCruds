using DBCrudApp.Models;

namespace DBCrudApp;


public static class Program
{
    public static void Main(string[] args)
    {
        //Add ANother table of PersonAttendance With Columns {Id, PersonId, AttendanceDateTime, IsActive}
        //write CreateAttendance and GetData functions
        //Make sure these work properly

        Person P = new Person(1, "Imran", "Imtiaz", "imran@imran,com", 
            "sdfsdfgdfgsdg", "35202-12345678-5", "0123453354", "Senior Employee"
            ,DateTime.Parse("1989-07-06"), 1 );

        Console.WriteLine($"Person id is {P.Id}  {P.FirstName}  {P.LastName}  {P.Address} {P.RegistrationDate.ToString()} ");
        Console.WriteLine(P.DayOfDOB());
        Console.ReadKey();
    }
}
