namespace TelephoneDirectoryApi.Entities
{
    public class TelephoneDirectory : BaseEntity
    {
        //public Guid? ID { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Company { get; set; }
        public string? CommunicationInformation { get; set; }
        public int? CommunicationType { get; set; }
        public string? InformationContent { get; set; }
        public string? Report { get; set; }
    }
}
