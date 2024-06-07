using System;
namespace Лаба4{
    class Program{
        static void Main(){

    

StaffList staffList = new StaffList();

staffList.AddPerson(new Employee { FIO = "Иванов Иван Иванович", CertificateNumber = 12345 });
staffList.AddPerson(new Student { FIO = "Петров Петр Петрович", RecordBookNumber = 11111 });
staffList.AddPerson(new Employee { FIO = "Сидоров Сидор Сидорович", CertificateNumber = 67890 });
staffList.AddPerson(new Student { FIO = "Кузнецов Кузьма Кузьмич", RecordBookNumber = 22222 });
staffList.AddPerson(new Employee { FIO = "Лебедев Лев Лебедевич", CertificateNumber = 34567 });

var employeeCount = staffList.GetEmployeeCount();
var studentCount = staffList.GetStudentCount();

Console.WriteLine("Список персонала:");
foreach (var person in staffList.Persons)
{
    if (person is Employee)
    {
        Console.WriteLine($"Преподаватель: {person.FIO}, № удостоверения: {((Employee)person).CertificateNumber}");
    }
    else if (person is Student)
    {
        Console.WriteLine(value: $"Студент: {person.FIO}, № зачётки: {((Student)person).RecordBookNumber}");
    }
}
Console.WriteLine($"Количество преподавателей: {employeeCount}");
Console.WriteLine($"Количество студентов: {studentCount}");
 }
    }
}