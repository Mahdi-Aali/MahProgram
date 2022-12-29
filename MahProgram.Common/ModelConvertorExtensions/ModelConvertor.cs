using MahProgram.DataAccess.Models.ContactUsModel;
using MahProgram.DataAccess.Models.EmployeeModel;
using MahProgram.DataAccess.Models.ProjectModel;
using MahProgram.DataAccess.Models.ServiceModel;
using MahProgram.DTOs.Models.ContactUsModels;
using MahProgram.DTOs.Models.EmployeeModels;
using MahProgram.DTOs.Models.ProjectModel;
using MahProgram.DTOs.Models.ServiceModels;

namespace MahProgram.Common.ModelConvertorExtensions
{
    public static class ModelConvertor
    {
        public static ContactUs ToContactUs(this ContactUsViewModel contactUsViewModel)
        => new(contactUsViewModel.Name, contactUsViewModel.Email, contactUsViewModel.Text);

        public static ContactUsAnswere ToContactUsAnswere(this ContactUsAnswereViewModel contactUsAnswereViewModel)
            => new(contactUsAnswereViewModel.ResponseMessage, contactUsAnswereViewModel.ContactUsId);

        public static Service ToService(this CreateServiceViewModel createServiceViewModel, string imagePath)
            => new(createServiceViewModel.Name, createServiceViewModel.Description, createServiceViewModel.Icon, imagePath);

        public static EditServiceViewModel ToEditServiceViewModel(this Service service)
            => new()
            {
                ServiceId = service.ServiceId,
                CreateDate = service.CreateDate,
                Description = service.Description,
                Icon = service.Icon,
                IsDeleted = service.IsDeleted,
                Name = service.Name
            };

        public static Employee ToEmployee(this CreateEmployeeViewModel model, string imagePath)
            => new(model.FullName, model.Skill, model.Bio, imagePath, model.GitHubLink, model.LinkedinLink,
                model.TwitterLink, model.InstagramLink, model.TelegramLink, false);

        public static Project ToProject(this CreateProjectViewModel model, string iconName, string mockUpImageOne, string mockUpImageTwo,
            string mockUpImageThree, string mockUpImageFour)
            => new(model.Name, model.Description, iconName, mockUpImageOne, mockUpImageTwo, mockUpImageThree, mockUpImageFour, DateTime.Now, false);
    }
}
