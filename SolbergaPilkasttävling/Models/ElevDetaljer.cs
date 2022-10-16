namespace SolbergaPilkasttävling.Models
{
    public class ElevDetaljer
    {
        public string? FörNamn { get; set; }
        public string? EfterNamn { get; set; }
        public string? Klass { get; set; }
        public int? Poäng { get; set; }

        public ElevDetaljer() { }

        public ElevDetaljer(string? förNamn, string? efterNamn, string? klass, int? poäng)
        {
            FörNamn = förNamn;
            EfterNamn = efterNamn;
            Klass = klass;
            Poäng = poäng;
        }
    }
}
