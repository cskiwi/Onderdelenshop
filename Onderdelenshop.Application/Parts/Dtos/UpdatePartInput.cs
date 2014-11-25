using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace Onderdelenshop.Parts.Dtos{
	public class UpdatePartInput : IInputDto, ICustomValidate{
		[Range(1, long.MaxValue)]
		public long PartId { get; set; }

		public int? UserId { get; set; }
		public PartState? State { get; set; }

		public void AddValidationErrors(List<ValidationResult> results){
			if (UserId == null && State == null){
				results.Add(new ValidationResult("Both of UserId and State can not be null in order to update a Task!", new[] { "UserId", "State" }));
			}
		}

		public override string ToString(){
			return string.Format("[UpdateTaskInput > PartId = {0}, UserId = {1}, State = {2}]", PartId, UserId, State);
		}
	}
}