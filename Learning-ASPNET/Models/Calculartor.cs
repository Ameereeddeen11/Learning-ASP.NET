using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Learning_ASPNET.Models
{
	public class Calculartor
	{
		[
            Display(Name = "1 Number"),
            Required(ErrorMessage = "Write a number."),
			Range(0, 100, ErrorMessage = "The number must be between 0 and 100.")
		]
		public int FirstNumber { get; set; }

		[
            Display(Name = "2 Number"),
            Required(ErrorMessage = "Write a number."),
			Range(0, 100, ErrorMessage = "The number must be between 0 and 100.")
		]
		public int SecondNumber { get; set; }

		public double Result { get; private set; }

		[
            Display(Name = "Operation"),
            Required(ErrorMessage = "Select an operation."),
		]
		public string Operation { get; set; }

		public List<SelectListItem> PosibleOperations { get; set; }

		public Calculartor()
		{
			Operation = "+";
			PosibleOperations = new List<SelectListItem>()
			{
				new SelectListItem { Value = "+", Text = "Sumar" },
				new SelectListItem { Value = "-", Text = "Restar" },
				new SelectListItem { Value = "*", Text = "Multiplicar" },
				new SelectListItem { Value = "/", Text = "Dividir" }
			};
		}
		
		public void Calculate()
		{
			Result = Operation switch
			{
				"+" => FirstNumber + SecondNumber,
				"-" => FirstNumber - SecondNumber,
				"*" => FirstNumber * SecondNumber,
				"/" => FirstNumber / SecondNumber,
				_ => 0
			};
		}
	}
}
