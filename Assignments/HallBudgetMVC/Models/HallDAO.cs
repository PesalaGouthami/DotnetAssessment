namespace HallBudgetMVC.Models
{
    public class HallDAO:IHallDataAccess
    {
        private readonly HallDBContext dbctx;
        public HallDAO(HallDBContext dbctx)
        {
            this.dbctx = dbctx;
        }
        public List<Hall> GetHalls(int price)
        {

            var halls = dbctx.hall.Where(h => h.CostPerDay <= price).ToList();
            return halls;
        }
    }
}
