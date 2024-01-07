using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC6.Models
{
	[MetadataType(typeof(EmployeeMetadata))]
	public partial class Employee: EmployeeData
	{
	}

	public class EmployeeMetadata
	{
		[DisplayAttribute(Name ="Full name")]
		public string FullName { get; set; }

	}
}