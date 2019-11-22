using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IctBaden.Api1NCE;
using IctBaden.Api1NCE.Models;
using IctBaden.Stonehenge3.Core;
using IctBaden.Stonehenge3.ViewModel;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace IctBaden._1NCE.Dashboard.ViewModels
{
    public class SimsVm : ActiveViewModel, IDisposable
    {
        public SimCardVm[] SimCards => GetSims();

        public bool HasSelected => Selected != null;
        public SimCard Selected { get; private set; }
        
        
        public bool HasSimEvents => SimEvents != null;
        public SimEvent[] SimEvents { get; private set; }
        
        
        public SimsVm(AppSession session) : base(session)
        {
            _simsApi = new SimsV1(DefaultUrls.Api, Program.ApiToken);
        }

        public void Dispose()
        {
            _simsApi.Dispose();
        }

        private readonly SimsV1 _simsApi;
        private SimCard[] _simCards;
        private SimCardVm[] _simCardVms;
        private SimCardVm[] GetSims()
        {
            if (_simCardVms != null)
            {
                return _simCardVms;
            }
            
            _simCardVms = new SimCardVm[]
            {
                new SimCardVm { IMSI = "loading..." }
            };

            Task.Run(() =>
            {
                _simCards = _simsApi.GetSimCards().ToArray();
                _simCardVms = _simCards
                    .OrderBy(sim => sim.IMSI)
                    .Select(sim => new SimCardVm(sim))
                    .ToArray();
                    
                NotifyPropertyChanged(nameof(SimCards));
            });

            return _simCardVms;
        }

        [ActionMethod]
        public void SelectSim(string imsi)
        {
            foreach (var sim in _simCardVms)
            {
                sim.IsSelected = sim.IMSI == imsi;
            }

            Selected = _simCards.First(s => s.IMSI == imsi);
            SimEvents = null;
        }

        [ActionMethod]
        public void ShowSimEvents()
        {
            SimEvents = _simsApi.GetSimEvents(Selected.ICCID)
                .ToArray();
        }
        
    }
}
