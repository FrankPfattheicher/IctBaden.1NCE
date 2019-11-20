using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IctBaden.Api1NCE;
using IctBaden.Api1NCE.Models;
using IctBaden.Stonehenge3.Core;
using IctBaden.Stonehenge3.ViewModel;
// ReSharper disable MemberCanBePrivate.Global

namespace IctBaden._1NCE.Dashboard.ViewModels
{
    public class SimsVm : ActiveViewModel
    {
        public List<SimCard> SimCards => GetSims();


        public SimsVm(AppSession session) : base(session)
        {
        }

        private List<SimCard> _simCards;
        private List<SimCard> GetSims()
        {
            if (_simCards != null)
            {
                return _simCards;
            }
            
            _simCards = new List<SimCard>
            {
                new SimCard { IMSI = "loading..." }
            };

            Task.Run(() =>
            {
                var sims = new SimsV1(DefaultUrls.Api, Program.ApiToken);
                _simCards = sims.GetSimCards()
                    .OrderBy(sim => sim.IMSI)
                    .ToList();
                    
                NotifyPropertyChanged(nameof(SimCards));
            });

            return _simCards;
        }
        
    }
}
