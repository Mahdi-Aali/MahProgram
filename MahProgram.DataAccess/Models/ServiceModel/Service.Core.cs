using MahProgram.DataAccess.Repositories.ContactUsAnswereRepositories;

namespace MahProgram.DataAccess.Models.ServiceModel;

public partial class Service
{
	public Service()
	{

	}

	public Service(string name, string description, string icon, string imagePath)
		: this(0, name, description, icon, imagePath, DateTime.Now)
	{

	}

	public Service(int serviceId, string name, string description, string icon, string imagePath, DateTime createDate, bool isDeleted = false)
	{
		ServiceId = serviceId;
		Name = name;
		Description = description;
		Icon = icon;
		ImagePath = imagePath;
		CreateDate = createDate;
		IsDeleted = isDeleted;
	}

	public override string ToString() => $"Service {{ ServiceId = {ServiceId}, Name = {Name}, Description = {Description}, Icon = {Icon}, ImagePath = {ImagePath}, CreateDate = {CreateDate}, IsDeleted = {IsDeleted} }}";
}
