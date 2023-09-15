// See https://aka.ms/new-console-template for more information
using System.Collections;
using CollectionsvsGenericcollectionsApp;
//Console.WriteLine("Hello, World!");


//ArrayList arraylist = new ArrayList();
//arraylist.Add(1);
//arraylist.Add("Sripriya");
//arraylist.Add(2.5);

//foreach (var i in arraylist)
//{
//    Console.WriteLine(i);
//}

List <Employee> list = new List<Employee> ()
{
    new Employee(){
     ID = 100,
    Name = "John",
    Salary = 30000
    },

     new Employee(){
     ID = 101,
    Name = "Mike",
    Salary = 40000
    },
          
      new Employee(){
     ID = 102,
    Name = "Tyson",
    Salary = 10000
    },

};
foreach(Employee employee in list){
    Console.WriteLine($"ID={employee.ID}, Name={employee.Name}, Salary={employee.Salary}");
}
