namespace MahProgram.DataAccess.Models.ContactUsModel
{
    public partial class ContactUsAnswere
    {
        public ContactUsAnswere()
        {

        }

        public ContactUsAnswere(string responseMessage, int contactUsId) : this(0, contactUsId, responseMessage, false, DateTime.Now)
        {

        }

        public ContactUsAnswere(int contactUsAnswereId, int contactUsId, string responseMessage, bool isDeleted, DateTime createDate)
        {
            ContactUsAnswereId = contactUsAnswereId;
            ContactUsId = contactUsId;
            ResponseMessage = responseMessage;
            IsDeleted = isDeleted;
            CreateDate = createDate;
        }

        public override string ToString() => $"ContactUsAnswere {{ ContactUsAnswereId = {ContactUsAnswereId}, ContactUsId = {ContactUsId}, ResponseMessage = {ResponseMessage}, IsDeleted = {IsDeleted}, CreateDate = {CreateDate}}}";
    }
}
