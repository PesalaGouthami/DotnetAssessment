namespace HallBudgetMVC.Models
{
    public interface IHallDataAccess
    {
        public List<Hall> GetHalls(int price);
    }
}
