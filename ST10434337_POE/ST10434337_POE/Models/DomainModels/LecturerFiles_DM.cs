namespace ST10434337_POE.Models.DomainModels
{
    public class LecturerFiles_DM
    {
        public int LecFileId { get; set; }
        public int UserId { get; set; }
        public string? FileLocation { get; set; }
        public string? FileExtention { get; set; }
        public int FileSize { get; set; }
    }
}
