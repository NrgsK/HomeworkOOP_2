using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Apply(ILoanManager loanManager)
        {
            //Başvuran bilgilerini değerlendirme
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager(); // Doğru bir yöntem değil.

            loanManager.Calculate();

        }

        public void DoLoanPreInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }

    }
}
