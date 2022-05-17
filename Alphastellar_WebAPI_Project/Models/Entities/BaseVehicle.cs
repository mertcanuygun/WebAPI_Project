namespace Alphastellar_WebAPI_Project.Models.Entities
{
    public enum Status { Active = 1, Modified = 2, Passive = 3 }
    public abstract class BaseVehicle
    {
        public int Id { get; set; }
        public string Colour { get; set; }

        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get => _createDate;
            set => _createDate = value;
        }

        private Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;
        }
    }
}
