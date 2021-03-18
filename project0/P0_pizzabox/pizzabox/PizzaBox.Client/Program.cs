using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;
using System.Linq;


namespace PizzaBox.Client
{
  /// <summary>
  /// 
  /// </summary>
  class Program
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    /// 
    
     
     
       
        static void Main(string[] args)
        {
           
                                  
             // print  hi custmor         
            Console.WriteLine();
            Console.WriteLine("Hi Customer enter 1");
            
           //read the user input
            var userIn = Console.ReadLine();
             //user enters 1 will 
            if (userIn == "1")
            {
               AsACustomer();
            }
           
            

           // For seeding.
            //  var store = StoreSingleton.Instance;
            //  store.Seeding();

           

              var pizzaS = PizzaSingleton.Instance;
             pizzaS.Seeding();

        }

        /// <summary>
        /// 
        /// </summary>

        public static void AsACustomer()
        {
            Program p = new Program();


            
            int input;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Select your Store ");

                int n = 0;

                foreach (var store in StoreSingleton.Instance.Stores)
                {
                    Console.WriteLine(++n + ": " + store);
                }

                // select a store
                input = Convert.ToInt32(Console.ReadLine());
                
            }while(input != 1 && input != 2);
            
            int input2 = 3;
            do
            {
                // select the options
                System.Console.WriteLine();
                System.Console.WriteLine("1. Place Order");
                 System.Console.WriteLine("2. View Your History");
                System.Console.WriteLine("3. Exit");

                // select a menu option
                input2 = Convert.ToInt32(Console.ReadLine());

               
               
                switch (input2)
                {
                    case 1:
                        p.placeOrder();
                        break;
                   
                    case 2:
                        p.orderHistory();
                        break;
                    case 3:
                        Console.WriteLine(" Bye! ");
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Option");
                        break;
                }

            } while (input2 != 3);
        }

        public void placeOrder()
        {
          var d = PizzaSingleton.Instance;
                d.Seeding();
            Console.WriteLine();
            int i = 0;
            foreach (var pizza in d.Pizzas)
            {
                Console.WriteLine(++i + ": " + pizza);
            }

            // select a type of pizza
            var input1 = Console.ReadLine();
          
             switch (input1)
             {
                 case "1":
                     customPizza();
                   break;
                         
                 default:
                     Console.WriteLine("Please Select A Valid Option");
                     break;
            }

        

        }
        void customPizza()
        {

            var cPizza = new CustomPizza();

                
        }
        
       
       
        void orderHistory(){
             Console.WriteLine("Plese Enter your Email ");
            var email = Console.ReadLine();

            var sinOrd = OrderSingleton.Instance;

            var order = sinOrd.readOrderList();

            if(email.Equals(order.customerEmail)){
                 Console.WriteLine("Store: " + order.StoreName);
                 foreach(var p in order.Pizzas){
                    
                     Console.WriteLine(" p.Name");
                    
                     }
               }
                 var mytotal = order.calcTotal();
                 Console.WriteLine("Total: $ " + mytotal);
             }
            
        }
}



























       
   /*    List<APizza> pizzas = PizzaSingleton.Instance.Pizzas;
        List<APizza> myOrder = new List<APizza>();

   public static void Main(string[] args)
   {

   Console.WriteLine();

   
   Console.WriteLine("If You are acustomer please enter 1 ");
   Console.WriteLine("If You are a manager please enter 2 ");
   Console.WriteLine(" to close enter 0 ");
   var userIn = Console.ReadLine();
   if (userIn =="1")
    {
      //PlayWithStore();
      AsACustomer();
    }
    if (userIn == "2"){
// manager
    }
    if (userIn != "0"){

      Console.WriteLine("enter a valid option");
    }


    /// <summary>
    /// 
    /// </summary>
    
    }

    public static void AsACustomer()
    {
      Program P =new Program();
     // var ss = StoreSingleton.Instance;

      //ss.Seeding();

      // print all the stores available, must be from file or db
      //foreach (var item in ss.Stores)
      //{
       // System.Console.WriteLine(item);
     // }
     int input;
     do{
     System.Console.WriteLine();
     System.Console.WriteLine("Select your Store");
     //PlayWithStore();
      int n = 0;
     foreach (var store in StoreSingleton.Instance.Stores)
      {
        Console.WriteLine(++n + ":" + store);
      }
      // select a store
        input = Convert.ToInt32(Console.ReadLine());
      if(input != 1 && input != 2){
        Console.WriteLine("Enter a valid option");
      }
     }while(input ! = 1&& input ! = 2);
     int input2 = 3;

      do{

      // print the customer menu
      System.Console.WriteLine();
      System.Console.WriteLine("1. Place Order");
      System.Console.WriteLine("2. View Order List");
      System.Console.WriteLine("3. Checkout");
      System.Console.WriteLine("4. Exit");

      // select a menu option
       input2 = Convert.ToInt32(Console.ReadLine());
     
      switch (input2)
      {
        case 1:
          P.placeOrder();
          // run the code dor placing order
          break;
        case 2:
        P.orderList();

          // run the code for view order history
          break;
       case 3:
        P.checkOut(StoreSingleton.Instance.Stores[input-1].Name);
          break;
          default:
          Console.WriteLine("please select one");
          break;
      }


      }
         while (input2 ! = 3);

    }

        

      public void placeOrder(){

       Console.WriteLine();
       int i = 0;
       foreach(var pizza in pizzas){
         Console.WriteLine( ++i + ":" + pizza);
       }

      // select a menu option
      var input3 = Console.ReadLine();
     
      switch (input3)
      {
        case "1":
        customPizza();
          // run the code dor placing order
          break;
        case "2":
        
          // run the code for view order history
          break;
      }
      myOrder.Add(cpizza);
  
    }
    void customPizza(){
      var cPizza = new CustomPizza();

       
       Options(cPizza);

      void Options(APizza cPizza){

       System.Console.WriteLine();
      Console.WriteLine("Choose a Crust: ");
      Console.WriteLine("1: Thick ------- $ 0.5 ");
      Console.WriteLine("2: Thin ------$ 0.3 ");
      
      int c = Convert.ToInt32(Console.ReadLine());
      switch (c)
      {
        case 1:
        cPizza.Crust.Name = "Thick";
        cPizza.Crust.Price = 0.5;
        break;
          case 2:
        cPizza.Crust.Name = "Thin";
        cPizza.Crust.Price = 0.2;
        break;
          
          default:
           case 3:
        cPizza.Crust.Name = "Thick";
        cPizza.Crust.Price = 0.5;
        break;
      }
      System.Console.WriteLine();
      Console.WriteLine("Choose a Size: ");
      Console.WriteLine("1: Small ------- $ 7.00 ");
      Console.WriteLine("2: Medium ------$ 9.99 ");
      Console.WriteLine("3: Large ------$ 12.95 ");
      int s = Convert.ToInt32(Console.ReadLine());
      switch (s)
      {
        case 1:
        cPizza.Size.Name = "Small";
        cPizza.Size.Price = 7.00;
        break;
         case 2:
        cPizza.Size.Name = "Medium";
        cPizza.Size.Price = 9.99;
        break;
         case 3:
        cPizza.Size.Name = "Large";
        cPizza.Size.Price = 12.95;
        break;
          
          default:
           case 4:
        cPizza.Size.Name = "Medium";
        cPizza.Size.Price = 9.99;
        break;
      }
      //while (s != 0);

      //myOrder.Add(cPizza);
      //Console.WriteLine(myOrder[0].Name);
      //Console.WriteLine(myOrder[0].Crust.Name);
    }


     void checkOut(string StoreName)
     {

      Customer customer = new Customer();
      Order order = new Order(myOrder);
      var total = order.calcTotal();
      Console.WriteLine();
      Console.WriteLine("List of Pizza that you ordered: ");
      foreach (var p in  myOrder)
      {
        Console.WriteLine(p.Name);
      }
      Console.WriteLine(total);

      Console.WriteLine();
      Console.WriteLine("Please Enter your Name: ");
      customer.Name = Console.ReadLine();

      Console.WriteLine("Please Enter your Email: ");
       customer.Email = Console.ReadLine();

       order.StoreName = StoreName;
       order.customerEmail = customer.Email;
  //Console.WriteLine("order.Pizzas[0].Name + " " + order.customerEmail);
      var os = OrderSingleton.Instance;
      os.Seeding(order);
      
    }
    void orderList(){

      Order order = new Order(myOrder);
      var total = order.calcTotal();
      Console.WriteLine();
      Console.WriteLine("List your order:");
      foreach(var p in myOrder){

        Console.WriteLine(p.Name);
      }
      Console.WriteLine("your tolal: $" + total);
    }

}*/

    


