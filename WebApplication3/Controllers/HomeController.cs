using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee() { FullName = "Test",Age =10 , DepartmentId = 1 , Id = 1 , Salary = 12000 };
            Employee employee1 = new Employee() { FullName = "maga",Age =15 , DepartmentId = 2 , Id = 2 , Salary = 22000 };
            Employee employee2 = new Employee() { FullName = "ramze",Age =17 , DepartmentId = 3 , Id = 3 , Salary = 32000 };
            Employee employee3 = new Employee() { FullName = "eli",Age =18 , DepartmentId = 4 , Id = 4 , Salary = 42000 };
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee);

            List<Department> departments = new List<Department>();
            Department department = new Department() { Name = "IT", Id = 1 };
            Department department1 = new Department() { Name = "UI", Id = 2};
            Department department2 = new Department() { Name = "UX", Id = 3};
            Department department3 = new Department() { Name = "BACK", Id =4 };
            departments.Add(department1);
            departments.Add(department2);
            departments.Add(department3);
            departments.Add(department);


            HomeViewModels homeViewModel = new HomeViewModels();
            homeViewModel.employees = employees;
            homeViewModel.departments = departments;    


            


            return View(homeViewModel);
        }

        public IActionResult Detail(int id)
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee() { FullName = "Test", Age = 10, DepartmentId = 1, Id = 1, Salary = 12000 };
            Employee employee1 = new Employee() { FullName = "maga", Age = 15, DepartmentId = 2, Id = 2, Salary = 22000 };
            Employee employee2 = new Employee() { FullName = "ramze", Age = 17, DepartmentId = 3, Id = 3, Salary = 32000 };
            Employee employee3 = new Employee() { FullName = "eli", Age = 18, DepartmentId = 4, Id = 4, Salary = 42000 };
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee);

            Employee wanted = employees.Find(x => x.Id == id);
            if (wanted == null)
            {
                return NotFound();
            }

            return View(wanted);

        }
    }
}
