using AutoMapper;
using BLL.interfaces;
using DAL.interfaces;
using DAL.models;
using DTO;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.functions
{
    public class OrdersBLL: IOrdersBLL
    {
        static IMapper _Mapper;
        IOrdersDAL _IOrdersDAL;

        public OrdersBLL(IOrdersDAL i)
        {
            _IOrdersDAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            _Mapper = config.CreateMapper();
        }


        ////////////////////////////

        public int AddOrder(OrdersDTO order)
        {
            return _IOrdersDAL.AddOrder
                (_Mapper.Map<OrdersDTO, OrdersTbl>(order));
        }

        public bool DeleteOrder(int orderId)
        {
            return _IOrdersDAL.DeleteOrder(orderId);
        }

        public List<OrdersDTO> GetAllOrders()
        {
            return _Mapper.Map<List<OrdersTbl>, List<OrdersDTO>>
                (_IOrdersDAL.GetAllOrders());
        }

        public bool UpdateOrder(OrdersDTO order)
        {
            return _IOrdersDAL.UpdateOrder
                ( _Mapper.Map<OrdersDTO, OrdersTbl>(order));
        }
    }
}
