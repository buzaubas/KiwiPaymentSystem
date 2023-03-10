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
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool editOperator(Operators _oper)
        {
            try
            {
                var oper = db.Operators.FirstOrDefault(w => w.Id == _oper.Id);
                oper.Logo = _oper.Logo;
                oper.Phone = _oper.Phone;
                oper.Name = _oper.Name;
                oper.Percent = _oper.Percent;
                oper.CreateDate = _oper.CreateDate;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
