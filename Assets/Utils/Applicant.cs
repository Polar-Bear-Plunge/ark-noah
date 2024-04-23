using System;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    [Serializable]
    public record Applications
    {
        public List<Applicant> Applicants { get; set; }
        public List<Relic> Relics { get; set; }
    }

    [Serializable]
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

    [Serializable]
    public record Relic
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Medium { get; set; }
        public string Risk { get; set; }
        public string Justification { get; set; }
        public string Importance { get; set; }
    }

    public class ApplicationsRepository
    {
        private Applications _applications;
        public ApplicationsRepository(string fileName)
        {
            string data = Resources.Load<TextAsset>(fileName).text;
            _applications = JsonUtility.FromJson<Applications>(data);
        }

        public Relic GetRandomRelic()
        {
            return _applications.Relics[UnityEngine.Random.Range(0, _applications.Relics.Count)];
        }

        public Applicant GetRandomApplicant()
        {
            return _applications.Applicants[UnityEngine.Random.Range(0, _applications.Applicants.Count)];
        }
    }
}
