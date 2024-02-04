namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class CustomerProcess
    {
        public int CustomerProcessID { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string EmployeeName { get; internal set; }
    }
}
