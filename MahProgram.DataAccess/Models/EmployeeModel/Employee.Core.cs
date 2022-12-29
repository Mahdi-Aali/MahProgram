namespace MahProgram.DataAccess.Models.EmployeeModel;

public partial class Employee
{
	public Employee()
	{

	}

	public Employee(string fullName, string skill, string bio, string imagePath, string? gitHubLink,
		string? linkedingLink, string? twitterLink, string? instagramLink, string? telegramLink,
		bool isDeleted = false ) : this(0, fullName, skill, bio, imagePath, gitHubLink, linkedingLink,
			twitterLink, instagramLink, telegramLink, DateTime.Now, false)
	{

	}

	public Employee(int employeeId, string fullName, string skill, string bio, string imagePath,
		string? gitHubLink, string? linkedingLink, string? twitterLink, string? instagramLink,
		string? telegramLink, DateTime createDate, bool isDeleted = false)
	{
		EmployeeId = employeeId;
		FullName = fullName;
		Skill = skill;
		Bio = bio;
		ImagePath = imagePath;
		GitHubLink = gitHubLink;
		LinkedinLink = linkedingLink;
		TwitterLink = twitterLink;
		InstagramLink = instagramLink;
		TelegramLink = telegramLink;
		CreateDate = createDate;
		IsDeleted = IsDeleted;
	}
}
