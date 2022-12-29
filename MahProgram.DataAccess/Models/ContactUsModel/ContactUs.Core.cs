namespace MahProgram.DataAccess.Models.ContactUsModel;

public partial class ContactUs
{
    public ContactUs(int contactUsId, string name, string email, string text, DateTime createDate, bool isDeleted = false, bool hasAnswere = false)
    {
        ContactUsId = contactUsId;
        Name = name;
        Email = email;
        Text = text;
        CreateDate = createDate;
        IsDeleted = isDeleted;
        HasAnswere = hasAnswere;
    }

    public ContactUs(int contactUsId, string name, string email, string text) : this(contactUsId, name, email, text, DateTime.Now)
    {

    }

    public ContactUs(string name, string email, string text) : this(0, name, email, text, DateTime.Now)
    {

    }

    public ContactUs()
    {

    }

    public override string ToString() => $"ContactUs {{ ContactUsId = {ContactUsId}, Name = {Name}, Email = {Email}, Text = {Text}, CreateDate = {CreateDate}}}";
}
