using IctBaden.Api1NCE.Models;
// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace IctBaden._1NCE.Dashboard.ViewModels
{
    public class SimCardVm
    {
        public string IMSI { get; set; }
        public string Label { get; set; }
        public bool IsSelected { get; set; }
        public string Class => IsSelected ? "selected" : "";

        public SimCardVm()
        {
        }
        public SimCardVm(SimCard sim)
        {
            IMSI = sim.IMSI;
            Label = sim.Label;
        }
    }
}