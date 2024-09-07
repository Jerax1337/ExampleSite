using Example.Features.DtoModels.Center;
using Example.Logic.DtoModels.Filters;

namespace Example.Features.Interfaces.Managers
{
    public interface ICenterManager
    {
		public void Create(EditCenter editCenter);

		public void Update(EditCenter updateCenter);

		public void Delete(Guid isnNode);

		public CenterDto GetCenter(Guid isnNode);

		CenterDto[] GetListCenters(CenterFilterDto centerFilter);
	}
}
