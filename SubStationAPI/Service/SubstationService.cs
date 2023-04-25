using SubStationAPI.Model;

namespace SubStationAPI.Service
{
    public class SubstationService : ISubstationService
    {
        private readonly SubstationModel _model;

        public SubstationService() { _model = new SubstationModel(); }

        public double GetLoad()
        {
            return _model.Load;
        }



        public void SetLoad(double load)
        {
            _model.Load = load;
        }

    }
}
