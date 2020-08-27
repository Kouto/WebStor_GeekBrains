using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStor_GeekBrains.ViewModels;

namespace WebStor_GeekBrains.Properties.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Position = "Начальник"
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Position = "Программист"
            }
        };

        private readonly List<EmployeeViewModelCars> _employeeCars = new List<EmployeeViewModelCars>
        {
        new EmployeeViewModelCars
        {
            Id=1,
            BrandName="Audi",
            Model = "XR1",
            Color="Black",
            EngineCapacity=100.5,
            YearOfIssue=2020
        },
        new EmployeeViewModelCars
        {
            Id=2,
            BrandName="Audi",
            Model = "XR2",
            Color="Black",
            EngineCapacity=200,
            YearOfIssue=2020
        },
        new EmployeeViewModelCars
        {
            Id=3,
            BrandName="Audi",
            Model = "XR3",
            Color="Black",
            EngineCapacity=200.80,
            YearOfIssue=2021
        },
        new EmployeeViewModelCars
        {
            Id=4,
            BrandName="Audi",
            Model = "XR4",
            Color="Black",
            EngineCapacity=300.10,
            YearOfIssue=2022
        },
        };

        //home/index
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employees()
        {
            return View(_employees);
        }
        public IActionResult EmployeesDetails(int id)
        {
            //Получаем сотрудника по Id
            var employee = _employees.FirstOrDefault(t => t.Id == id);

            //Если такого не существует
            if (employee == null)
                return NotFound(); // возвращаем результат 404 Not Found

            //Иначе возвращаем сотрудника
            return View(employee);
        }
        public IActionResult EmployeesCars()
        {
            return View(_employeeCars);
        }
        public IActionResult EmployeesCarsDetails(int id)
        {
            //return View(_employeeCars.FirstOrDefault(x => x.Id == id));
            var employeescars = _employeeCars.FirstOrDefault(t => t.Id == id);
            
            if (employeescars == null)
                return NotFound(); // возвращаем результат 404 Not Found
            return View(employeescars);
        }
    }
}
