using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderServices
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
           return  _orderDal.GetAll();
        }

        public Order GetByOrderId(int id)
        {
             return _orderDal.Get(o=>o.OrderId==id);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
