namespace SubStationAPI.Repository
{ 
    // not being used right now. Will use when we'll have to develop a ML model or advance CRUD operations
    public interface ISubstationRepository
    {
        public double GetLoad();
        public void SetLoad(double load);
    }
}
