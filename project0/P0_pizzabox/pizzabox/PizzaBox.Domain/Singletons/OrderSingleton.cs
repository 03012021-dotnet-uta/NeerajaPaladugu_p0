using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System.Xml.Serialization;
using System.IO;
using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PizzaBox.Domain.Singletons
{
    public class OrderSingleton
    {
              private static OrderSingleton _orderSingleton;
   public List<Order> myOrders { get; set; } // print job
    private readonly string _path = @"order.xml";
    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton(); // printer
        }

        return  _orderSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private OrderSingleton()//getting from Xll
    {
        //  var fs = new FileStorage();
      
        // if(myOrders == null){
        //   myOrders = fs.ReadFromXml<Order>(_path).ToList();

      
        // }
    }
    public Order readOrderList(){
        System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Order));
        System.IO.StreamReader file = new StreamReader( _path);
        Order view = (Order)reader.Deserialize(file);
        file.Close(); 
        return view;
        
    }

    public void Seeding(Order order)//writing to xml
    {
       System.Xml.Serialization.XmlSerializer writer = new XmlSerializer(typeof(Order));
        System.IO.FileStream file =  System.IO.File.Create(_path);
        System.Console.WriteLine(_orderSingleton);
        writer.Serialize(file, order);
        file.Close();


        // var orders = new List<Order>();
        // foreach(var ord in myOrders){
        //   orders.Add(ord);
        // }
        // orders.Add(order);

        // var fs = new FileStorage();
        // fs.WriteToXml<Order>(orders, _path);
        // myOrders = fs.ReadFromXml<Order>(_path).ToList();



    }

        // ublic object readOrderList()
        // {p
        //     throw new NotImplementedException();
        // }
    }
}