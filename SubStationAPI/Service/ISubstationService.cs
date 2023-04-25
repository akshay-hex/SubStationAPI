namespace SubStationAPI.Service
{
    public interface ISubstationService
    {
        public double GetLoad();
        public void   SetLoad(double load);
    }
}
