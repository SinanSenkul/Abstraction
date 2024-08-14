using System;

public class EmployeeBase //defined the base class with standard values like name, lastname etc.
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
    public EmployeeBase(string name, string lastName, string department)
    {
        Name = name;
        LastName = lastName;
        Department = department;
    }
}
public interface IObjective //defined the interface
{
    public abstract void Objective(); //Gorev() method has been defined as an abstract 
}

public class Developer : EmployeeBase, IObjective //developer class, which uses EmployeeBase as base class and IObjective as
    //interface
{
    public string Position { get; set; }
    public Developer(string name, string lastname, string department, string position) : base(name, lastname, department)
    {
        Name = name;
        LastName = lastname;
        Department = department;
        Position = position;
    }
    public void Objective()
    {
        Console.WriteLine($"Merhaba! Adım {Name}, Şirkette developer olarak çalışıyorum");
    }
}

public class SalesSpecialist : EmployeeBase, IObjective
{
    public string Position { get; set; }
    public SalesSpecialist(string name, string lastname, string department, string position) : base(name, lastname, department)
    {
        Name = name;
        LastName = lastname;
        Department = department;
        Position = position;
    }
    public void Objective()
    {
        Console.WriteLine($"Merhaba! Adım {Name}, Şirkette developer olarak çalışıyorum");
    }
}