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
        public string ApplicationMethod { get; set; }
        public string Justification { get; set; }
        public string Notes { get; set; }
    }

    public record Relic
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Medium { get; set; }
        public string Risk { get; set; }
        public string Justification { get; set; }
        public string Importance { get; set; }
    }
}
