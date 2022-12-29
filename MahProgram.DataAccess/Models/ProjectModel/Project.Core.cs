namespace MahProgram.DataAccess.Models.ProjectModel;

public partial class Project
{
	public Project()
	{

	}

	public Project(string name, string description, string icon, string mockUpImageOne, string mockUpImageTwo, string mockUpImageThree,
		string mockUpImageFour, DateTime createDate, bool isDeleted = false)
		: this (0, name, description, icon, mockUpImageOne, mockUpImageTwo, mockUpImageThree, mockUpImageFour, DateTime.Now, isDeleted)
	{

	}

	public Project(int projectId, string name, string description, string icon, string mockUpImageOne, string mockUpImageTwo,
		string mockUpImageThree, string mockUpImageFour, DateTime createDate, bool isDeleted = false)
	{
		ProjectId = projectId;
		Name = name;
		Description = description;
		Icon = icon;
		MockUpImageOne = mockUpImageOne;
		MockUpImageTwo = mockUpImageTwo;
		MockUpImageThree = mockUpImageThree;
		MockUpImageFour = mockUpImageFour;
		CreateDate = createDate;
		IsDeleted = IsDeleted;
	}
}
