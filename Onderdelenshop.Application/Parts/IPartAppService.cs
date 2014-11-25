using Abp.Application.Services;
using Onderdelenshop.Parts.Dtos;

namespace Onderdelenshop.Parts{
	public interface IPartAppService : IApplicationService{
		GetPartsOutput GetParts(GetPartsInput input);
		void UpdatePart(UpdatePartInput input);
		void CreatePart(CreatePartInput input);
	}
}