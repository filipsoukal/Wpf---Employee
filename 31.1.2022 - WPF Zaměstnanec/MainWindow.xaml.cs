using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _31._1._2022___WPF_Zaměstnanec
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Human {
		public Human(string name, string surname, DateTime birthdate){
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
	}
    public class Employee : Human {
        public Employee(string name, string surname, DateTime birthdate, int education, string job, double grosssalary) : base(name, surname, birthdate) {
            Education = education;
            Job = job;
            GrossSalary = grosssalary;
        }
        public int Education { get; set; }
        public string Job { get; set; }
        public double GrossSalary { get; set; }
		public override string ToString() {
			
            return base.ToString(); //https://github.com/RonStudeny/Employee-Form.git
		}
	}
}
