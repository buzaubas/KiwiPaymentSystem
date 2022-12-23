using KiwiPaymentSystem.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiPaymentSystem
{
    public class OperatorService
    {
        EntityModal db = new EntityModal();

        public List<Operators> GetOperators()
        {
            List<Operators> operators = db.Operators.ToList();
            return operators;
        }

        public bool AddOperator(Operators operators)
        {
            try
            {
                db.Operators.Add(operators);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
