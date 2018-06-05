using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using aucassin_03_june_18_homework;

namespace HomeworkProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("aucassin_03_june_18_homework.exe");
            var typeUser = asm.GetType("aucassin_03_june_18_homework.UserFolder.User", false, true);
            var typeEmployee = asm.GetType("aucassin_03_june_18_homework.EmployeeFolder.Employee", false, true);
            var methodsU = typeUser.GetMethods(BindingFlags.Public);
            var methodsE = typeEmployee.GetMethods(BindingFlags.Static);
            foreach (MethodInfo mi in typeUser.GetMethods())
            {
                    Console.WriteLine(mi.ReturnType.Name + " " + mi.Name);
                //mi.Invoke(Activator.CreateInstance(typeUser, null), null);
            }
            
            //var types = asm.GetTypes();
            //foreach (var item in types)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}
