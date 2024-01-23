namespace PalSearch.Models {
    public class Pal {
        public string PalNumber { get; set; }
        public string PalName { get; set; }
        public string PalElement { get; set; }
        public string PartnerSkill { get; set; }
        public List<PalJob> PalJobs { get; set; }
        public List<string> PalDrops { get; set; }
    }

    public class PalJob {
        public string WorkName { get; set; }
        public string Level { get; set; }
    }
}