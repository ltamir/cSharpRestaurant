using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace finalProject
{
    class RestaurantBL
    {
        private const String RES_CAPTION = "caption";
        private const String RES_DB_ROOT = "dataSource";
        private const String RES_DB_URL_SUFF = "urlSuffix";
        private const String RES_DB_URL_PREF = "urlPrefix";
        private const String RES_DB_URL_PATH = "dbPath";
        private const String RES_MESSAGE_ROOT = "messages";
        private const String RES_MESSAGE = "message";
        private const String RES_ID = "id";

        //Server=.\(LocalDB)\v11.0;AttachDbFilename=C:\Users\liort\Google Drive\Ariel_Practical_Engineer\cSharp\Final Project\Restaurant.mdf;Database=Restaurant;Trusted_Connection=Yes;
        //Server=(localdb)\\mssqllocaldb;Database=Restaurant;Trusted_Connection=True;MultipleActiveResultSets=true
        //Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        //(LocalDB)\v11.0"
        //https://msdn.microsoft.com/en-us/library/bb399375(v=vs.100).aspx
        private String conn = "Data Source=LIORTAMIRNT\\SQLEXPRESS;Initial Catalog=RestMyOrder;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private RestMyOrder dbHandler = null;
        private double orderSum = 0.00;
        private Order_t _Order;

        private XDocument res = XDocument.Load("DataResource.xml");

        public double OrderSum { get => orderSum; set => orderSum = value; }

        private struct Order_t
        {
            public Cs_appetizer     appetizer;
            public Cs_mainCourse    mainCourse;
            public Cs_sideDish      sideDishOne;
            public Cs_sideDish      sideDishTwo;
            public Cs_dessert       dessertOne;
            public Cs_dessert       dessertTwo;
        };

        public enum DishTypeEnum
        {
            APPETIZER = 1,
            MAIN_COURSE = 2,
            SIDE_DISH = 3,
            DESSERT = 4
        };

        public RestaurantBL()
        {
            
            IEnumerable<XElement> dbElem = (from dbConnPref in res.Root.Elements(RES_DB_ROOT).Elements(RES_DB_URL_PREF)
                                             select dbConnPref);
            conn = dbElem.First().Value.ToString();
            dbElem = (from dbConnPath in res.Root.Elements(RES_DB_ROOT).Elements(RES_DB_URL_PATH)
                      select dbConnPath);
            //String dbPath = dbElem.First().Value.ToString();
            String dbPath = "Restaurant.mdf";
            if (!dbPath.Contains("\\")){
                String startPath = Environment.GetCommandLineArgs()[0];
                String[] arr = startPath.Split('\\');
                arr[arr.Length - 1] = dbPath;
                dbPath = String.Join("\\", arr);
            }
            conn += dbPath;

            dbElem = (from dbConnSuff in res.Root.Elements(RES_DB_ROOT).Elements(RES_DB_URL_SUFF)
                      select dbConnSuff);

            

            conn += dbElem.First().Value.ToString();
            dbHandler = new RestMyOrder(conn);

            // load dummy records equivallent to DB 'not seleted' records
            CreateOrder_t();
        }

        private void CreateOrder_t()
        {
            _Order = new Order_t
            {
                appetizer = new Cs_appetizer() { AppetizerId = 1, DishPrice = 0.00 },
                mainCourse = new Cs_mainCourse() { MainCourseId = 1, DishPrice = 0.00 },
                sideDishOne = new Cs_sideDish() { SideDishId = 1, DishPrice = 0.00 },
                sideDishTwo = new Cs_sideDish() { SideDishId = 1, DishPrice = 0.00 },
                dessertOne = new Cs_dessert() { DesertId = 1, DishPrice = 0.00 },
                dessertTwo = new Cs_dessert() { DesertId = 1, DishPrice = 0.00 }
            };
        }

        // ***** resource handling ***** //

        public string GetCaption(int pos)
        {
            IEnumerable<XElement> caption = (from cap in res.Root.Elements(RES_CAPTION)
                                             where (string)cap.Attribute(RES_ID) == (pos.ToString())
                                             select cap);
            return caption.First().Value.ToString();
        }

        public void GetMessage(int num, ref string title,ref string data)
        {
            IEnumerable<XElement> message = (from msg in res.Root.Element(RES_MESSAGE_ROOT).Elements(RES_MESSAGE)
                                             where (string)msg.Attribute(RES_ID) == (num.ToString())
                                             select msg);
            title = message.First().Element("title").Value;
            data = message.First().Element("data").Value;
        }


        // ***** dish addition to order ***** //


        private void AdjustSum(IDishBean dishToAdd, IDishBean dishToRemove)
        {
            orderSum -= dishToRemove.GetDishPrice();
            orderSum += dishToAdd.GetDishPrice();
        }

        public void AddAppetizerOrder(Cs_appetizer dish)
        {
            if (!(dish is Cs_appetizer))
                return;

            IDishBean dishToRemove = _Order.appetizer;
            _Order.appetizer = dish;
            AdjustSum(dish, dishToRemove);
        }

        public void AddMainCourseOrder(Cs_mainCourse dish)
        {
            if (!(dish is Cs_mainCourse))
                return;

            IDishBean dishToRemove = _Order.mainCourse;
            _Order.mainCourse = dish;
            AdjustSum(dish, dishToRemove);
        }

        public void AddSideDishOrder(Cs_sideDish dish1, Cs_sideDish dish2)
        {
            IDishBean dishToRemove = null;

            if (!(dish1 is Cs_sideDish) || !(dish2 is Cs_sideDish))
                return;

            dishToRemove = _Order.sideDishOne;
            _Order.sideDishOne = dish1;
            AdjustSum(dish1, dishToRemove);

            dishToRemove = _Order.sideDishTwo;
            _Order.sideDishTwo = dish2;
            AdjustSum(dish2, dishToRemove);
        }

        public void AddDessertOrder(Cs_dessert dish1, Cs_dessert dish2)
        {
            IDishBean dishToRemove = null;


            if (!(dish1 is Cs_dessert) || !(dish2 is Cs_dessert))
                return;

            dishToRemove = _Order.dessertOne;
            _Order.dessertOne = dish1;
            AdjustSum(dish1, dishToRemove);

            dishToRemove = _Order.dessertTwo;
            _Order.dessertTwo = dish2;
            AdjustSum(dish2, dishToRemove);

        }

        // ***** Data Insert and Update ***** //

        public Cs_order GetOrder(Cs_diningTable tbl)
        {
            Cs_order order = null;
            OrderSum = 0.00;
            CreateOrder_t();

            order = dbHandler.Cs_order.Where(o => o.DiningTableId == tbl.DiningTableId).FirstOrDefault();

            if (order == null)
            {
                CreateOrder_t();
            }
            else
            {
                AddAppetizerOrder(order.Cs_appetizer);
                AddMainCourseOrder(order.Cs_mainCourse);
                AddSideDishOrder(order.Cs_sideDish, order.SideDishTwo);
                AddDessertOrder(order.Cs_dessert, order.DessertTwo);
            }
            return order;
        }

        public void AddOrder(Cs_diningTable tbl)
        {
            bool isNewOrder = false;
            Cs_order order = null;

            if (tbl.DiningTableId == 0)
            {
                return;
            }
            
            order = dbHandler.Cs_order.Where(o => o.DiningTableId == tbl.DiningTableId).FirstOrDefault();

            if(order == null)
            {
                order = new Cs_order();
                isNewOrder = true;
            }

            order.Cs_appetizer = _Order.appetizer;
            order.Cs_mainCourse = _Order.mainCourse;
            order.Cs_sideDish = _Order.sideDishOne;
            order.SideDishTwo = _Order.sideDishTwo;
            order.Cs_dessert = _Order.dessertOne;
            order.DessertTwo = _Order.dessertTwo;
            order.Cs_diningTable = tbl;


            if (isNewOrder)
            {
                dbHandler.Cs_order.InsertOnSubmit(order);
            }
            dbHandler.SubmitChanges();
        }


        public void AddDish(DishTypeEnum dishType, string dishName, double dishPrice)
        {
            switch (dishType)
            {
                case DishTypeEnum.APPETIZER:
                    Cs_appetizer appetizer = new Cs_appetizer(){ DishName = dishName, DishPrice = dishPrice};
                    dbHandler.Cs_appetizer.InsertOnSubmit(appetizer);
                    break;
                case DishTypeEnum.MAIN_COURSE:
                    Cs_mainCourse mainCourse = new Cs_mainCourse() { DishName = dishName, DishPrice = dishPrice};
                    dbHandler.Cs_mainCourse.InsertOnSubmit(mainCourse);
                    break;
                case DishTypeEnum.SIDE_DISH:
                    Cs_sideDish sideDish = new Cs_sideDish() { DishName = dishName, DishPrice = dishPrice};
                    dbHandler.Cs_sideDish.InsertOnSubmit(sideDish);
                    break;
                case DishTypeEnum.DESSERT:
                    Cs_dessert dessert = new Cs_dessert() { DishName = dishName, DishPrice = dishPrice};
                    dbHandler.Cs_dessert.InsertOnSubmit(dessert);
                    break;
            }

            dbHandler.SubmitChanges();

        }


        public void updateDish(DishTypeEnum dishType, IDishBean dish, string dishName, double dishPrice)
        {
            switch (dishType)
            {
                case DishTypeEnum.APPETIZER:
                    Cs_appetizer appetizer = (Cs_appetizer)dish;
                    appetizer.DishName = dishName;
                    appetizer.DishPrice = dishPrice;
                    break;
                case DishTypeEnum.MAIN_COURSE:
                    Cs_mainCourse mainCourse = (Cs_mainCourse)dish;
                    mainCourse.DishName = dishName;
                    mainCourse.DishPrice = dishPrice;
                    break;
                case DishTypeEnum.SIDE_DISH:
                    Cs_sideDish sideDish = (Cs_sideDish)dish;
                    sideDish.DishName = dishName;
                    sideDish.DishPrice = dishPrice;
                    break;
                case DishTypeEnum.DESSERT:
                    Cs_dessert dessert = (Cs_dessert)dish;
                    dessert.DishName = dishName;
                    dessert.DishPrice = dishPrice;
                    break;
            }
            dbHandler.SubmitChanges();
        }


        // *****  data access ***** //


        public List<Cs_diningTable> GetDiningTable()
        {
            List<Cs_diningTable> tableLst = null;
            try
            {
                tableLst = dbHandler.Cs_diningTable.ToList();
            }catch(System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Error accessing Database", "Application error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
            tableLst.Insert(0, new Cs_diningTable { DiningTableId = 0 });

            return tableLst;
        }

        public Table<Cs_appetizer> GetAppetizer()
        {
            return dbHandler.Cs_appetizer;
        }

        public Table<Cs_mainCourse> GetMainCourse()
        {
            return dbHandler.Cs_mainCourse;
        }

        public Table<Cs_sideDish> GetSideDish()
        {
            return dbHandler.Cs_sideDish;
        }

        public Table<Cs_dessert> GetDessert()
        {
            return dbHandler.Cs_dessert;
        }

        public Object GetOrderList()
        {
            Object res = from o in dbHandler.Cs_order
            select new {o.Cs_diningTable,
                o.Cs_appetizer,
                o.Cs_mainCourse,
                o.Cs_sideDish,
                o.SideDishTwo,
                o.Cs_dessert,
                o.DessertTwo};
            
            return res;
        }


    }


    // ***** RestaurantBL extention ***** //


    public interface IDishBean
    {
        int getDishId();
        string GetDishName();
        double GetDishPrice();
    }



    public partial class Cs_mainCourse : INotifyPropertyChanging, INotifyPropertyChanged, IDishBean
    {
        // ltamir
        public override string ToString()
        {
            return this.DishName;
        }
        
        public double GetDishPrice()
        {
            return DishPrice;
        }

        public string GetDishName()
        {
            return ToString();
        }

        public int getDishId()
        {
            return MainCourseId;
        }
    }

    public partial class Cs_sideDish : INotifyPropertyChanging, INotifyPropertyChanged, IDishBean
    {
        // ltamir
        public override string ToString()
        {
            return this.DishName;
        }

        public double GetDishPrice()
        {
            return DishPrice;
        }

        public string GetDishName()
        {
            return ToString();
        }

        public int getDishId()
        {
            return SideDishId;
        }
    }

    public partial class Cs_appetizer : INotifyPropertyChanging, INotifyPropertyChanged, IDishBean
    {
        // ltamir
        public override string ToString()
        {
            return this.DishName;
        }

        public double GetDishPrice()
        {
            return DishPrice;
        }

        public string GetDishName()
        {
            return ToString();
        }

        public int getDishId()
        {
            return AppetizerId;
        }
    }

    public partial class Cs_dessert : INotifyPropertyChanging, INotifyPropertyChanged, IDishBean
    {
        public override string ToString()
        {
            return this.DishName;
        }

        public double GetDishPrice()
        {
            return DishPrice;
        }

        public string GetDishName()
        {
            return ToString(); 
        }

        public int getDishId()
        {
            return DesertId;
        }
    }

    public partial class Cs_diningTable : INotifyPropertyChanging, INotifyPropertyChanged
    {

        public override string ToString()
        {
            if (DiningTableId == 0)
                return "בחר שולחן";

            return this.DiningTableId.ToString();
        }


    }


}
