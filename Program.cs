
using System;




namespace ConstructorInjectionProject
{
    class Program
    {
        static void Main(string[] args)
    {
            IlkClass oIlkClass = new IlkClass();
            IkinciClass oIkinciClass = new IkinciClass(oIlkClass);
            oIkinciClass.MesajıGoster("Örbek bir mesaj");
        Console.ReadLine();
    }
}}