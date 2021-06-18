using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace examenEmpleados.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Código")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "No debe tener más de 50 cáracteres.")]
        [MinLength(2, ErrorMessage = "El mínimo de cáracteres es 2.")]
        [Display(Name = "Apellido")]
        public string EmployeeApellido { get; set; }

        [Required(ErrorMessage = "Los nombres son obligatorios.")]
        [StringLength(60, ErrorMessage = "No debe tener más de 60 cáracteres.")]
        [MinLength(1, ErrorMessage = "El mínimo de cáracteres es 1.")]
        [Display(Name = "Nombres")]
        public string EmployeeNombres { get; set; }

        [Required(ErrorMessage = "El apodo es obligatorio.")]
        [StringLength(50, ErrorMessage = "No debe tener más de 50 cáracteres.")]
        [MinLength(1, ErrorMessage = "El mínimo de cáracteres es 1.")]
        [Display(Name = "Apodo")]
        public string EmployeeApodo { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(50, ErrorMessage = "No debe tener más de 50 cáracteres.")]
        [MinLength(10, ErrorMessage = "El mínimo de cáracteres es 10.")]
        [Display(Name = "Dirección")]
        public string EmployeeDireccion { get; set; }

        [Required(ErrorMessage = "El código postal es obligatorio.")]
        [StringLength(50, ErrorMessage = "No debe tener más de 50 cáracteres.")]
        [MinLength(3, ErrorMessage = "El mínimo de cáracteres es 3.")]
        [Display(Name = "Código Postal")]
        public string EmployeeCodigoPostal { get; set; }

        [Required(ErrorMessage = "El número de télefono es obligatorio.")]
        [StringLength(30, ErrorMessage = "No debe tener más de 30 cáracteres.")]
        [MinLength(5, ErrorMessage = "El mínimo de cáracteres es 5.")]
        [Display(Name = "Télefono")]
        public string EmployeeTelefono { get; set; }

        [Required(ErrorMessage = "El número de celular es obligatorio.")]
        [StringLength(30, ErrorMessage = "No debe tener más de 30 cáracteres.")]
        [MinLength(5, ErrorMessage = "El mínimo de cáracteres es 5.")]
        [Display(Name = "Celular")]
        public string EmployeeCelular { get; set; }

        [Required(ErrorMessage = "El número de fax es obligatorio.")]
        [StringLength(40, ErrorMessage = "No debe tener más de 40 cáracteres.")]
        [MinLength(5, ErrorMessage = "El mínimo de cáracteres es 5.")]
        [Display(Name = "Fax")]
        public string EmployeeFax{ get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [StringLength(60, ErrorMessage = "No debe tener más de 60 cáracteres.")]
        [MinLength(5, ErrorMessage = "El mínimo de cáracteres es 5.")]
        [Display(Name = "Email")]
        public string EmployeeEmail { get; set; }


        [StringLength(1000, ErrorMessage = "No debe tener más de 1000 cáracteres.")]
        [Display(Name = "Observaciones")]
        public string EmployeeObservaciones { get; set; }

    }
}
