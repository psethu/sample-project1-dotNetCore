
namespace DatabaseAccessLibrary.Models
{
    public abstract class SurchargeBaseModel
    {
        public abstract decimal Amount { get; set; }
        public abstract void Calculate();
    }
}
