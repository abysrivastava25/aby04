using CodeFirst_Entity.Models;
using CodeFirst_Entity.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Entity.Services
{
    public class Sales : ISales
    {
        public bool NewOrder(Orders orders)
        {
            var db_con = new CodeFirstContext();
            try
            {

                db_con.Orders.Add(orders);
                db_con.Customers.Add(orders.FkCust);
                db_con.Products.Add(orders.FkProd);
                var res = db_con.SaveChanges();
                if (res > 0)
                    return true;
                else
                    return false;
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public bool RemoveRecord(Orders orders)
        {
            var db_con = new CodeFirstContext();
            try
            {
                var o = db_con.Customers.First(d => d.CustId == orders.FkCustId);
                db_con.Customers.Remove(o);
                var c = db_con.Orders.First(d => d.OrderId == orders.OrderId);
                db_con.Orders.Remove(c);
                var p = db_con.Products.First(d => d.ProdId == orders.FkProdId);
                db_con.Products.Remove(p);
                var res = db_con.SaveChanges();
                if (res > 0)
                    return true;
                else
                    return false;
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public List<Customer> Show()
        {
            var db_con = new CodeFirstContext();
            try
            {
                var d = db_con.Customers.ToList();
                return d;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customer> ShowSingle(int id)
        {
            var db_con = new CodeFirstContext();
            try
            {
                var data = db_con.Customers.Where(c => c.CustId == id).Include(o => o.Orders).ThenInclude(p => p.FkProd).ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //public bool NewRecord(Orders orders)
        //{
        //    var db_con = new CodeFirstContext();
        //    try
        //    {
        //        db_con.Orders.Add(orders);
        //        var cust = db_con.Orders.Count(o => o.FkCustId == orders.FkCustId);
        //        var no = cust + 1;
        //        Customer c = db_con.Customers.FirstOrDefault(c => c.CustId == orders.FkCustId);
        //        c.NoOfOrders = no;
        //        var res = db_con.SaveChanges();
        //        if (res > 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        throw ex;
        //    }
    }

        //public bool RemoveRecord(Orders orders)
        //{
        //    var db_con = new CodeFirstContext();
        //    try
        //    {
        //        var o = db_con.Customers.First(d => d.CustId == orders.FkCustId);
        //        db_con.Customers.Remove(o);
        //        var c = db_con.Orders.First(d => d.OrderId == orders.OrderId);
        //        db_con.Orders.Remove(c);
        //        var p = db_con.Products.First(d => d.ProdId == orders.FkProdId);
        //        db_con.Products.Remove(p);
        //        var res = db_con.SaveChanges();
        //        if (res > 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<Customer> Show()
        //{
        //    var db_con = new CodeFirstContext();
        //    try
        //    {
        //        var d = db_con.Customers.ToList();
        //        return d;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<Customer> ShowSingle(int id)
        //{
        //   var db_con = new CodeFirstContext();
        //    try
        //    {
        //        var data = db_con.Customers.Where(c => c.CustId == id).Include(o => o.Orders).ThenInclude(p => p.FkProd).ToList();
        //        return data;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }

