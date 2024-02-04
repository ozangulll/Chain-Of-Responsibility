using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector:Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü -Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşteriye talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü -Zeynep Yılmaz";
                customerProcess.Description = "Para çekme tutarı Bölge Direktörünün ödeyebileceği limiti aşar. Maksimum 400.000TL çekilebilir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                

            }

        }
    }
}
