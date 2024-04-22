namespace Utils
{
    public record Applicant
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Role { get; set; }
        public int ApplicantCount { get; set; }
        public string MedicalHistory { get; set; }
        public string Risk { get; set; }
        public string ApplicationMode { get; set; }
        public string Reasons { get; set; }
        public string Notes { get; set; }
    }
}
