using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using Syncfusion.Maui.Inputs;
using System.Collections.ObjectModel;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void dataGrid_Loaded(object sender, EventArgs e)
        {
            dataGrid.MinimumHeightRequest = 0;
            dataGrid.HeightRequest = dataGrid.HeaderRowHeight + dataGrid.RowHeight * 5;
        }
    }

    public class OrderInfo
    {
        private int orderID;
        private string customerID;
        private string customer;
        private string shipCountry;
        private int? qty;

        public int OrderID
        {
            get { return orderID; }
            set { this.orderID = value; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { this.customerID = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; }
        }

        public string Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public int? Qty
        {
            get { return qty; }
            set { qty = value; }
        }


        public OrderInfo(int orderId, string customerId, string country, string customer, int? qty)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.Qty = qty;
            this.ShipCountry = country;
        }
    }

    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "ALFKI", "Berlin", "Laura King", 14));
            orderInfo.Add(new OrderInfo(1002, "ANATR", "Mexico", "Ana Trujillo", 15));
            orderInfo.Add(new OrderInfo(1003, "ANTON", "Berlin", "Ant Fuller", 20));
            orderInfo.Add(new OrderInfo(1004, "AROUT", "London", "Thomas Lin", 25));
            orderInfo.Add(new OrderInfo(1005, "BERGS", "Strasbourg", "Tim Adams", 30));
            orderInfo.Add(new OrderInfo(1006, "BLAUS", "Mannheim", "Hanna Moos", 12));
            orderInfo.Add(new OrderInfo(1007, "BLONP", "Strasbourg", "Andrew Fuller", 18));
            orderInfo.Add(new OrderInfo(1008, "BOLID", "Madrid", "Martin King", 22));
            orderInfo.Add(new OrderInfo(1009, "BONAP", "Marsiella", "Lenny Lin", 16));
            orderInfo.Add(new OrderInfo(1010, "BOTTM", "Canada", "John Carter", 14));
            orderInfo.Add(new OrderInfo(1011, "AROUT", "Paris", "Laura King", 19));
            orderInfo.Add(new OrderInfo(1012, "BLAUS", "Germany", "Anne Wilson", 17));
            orderInfo.Add(new OrderInfo(1013, "BLONP", "London", "Martin King", 21));
            orderInfo.Add(new OrderInfo(1014, "AROUT", "London", "Gina Irene", 13));
            orderInfo.Add(new OrderInfo(1015, "AROUT", "Manhiem", "Laura King", 12));
            orderInfo.Add(new OrderInfo(1016, "BLAUS", "Berlin", "Anne Wilson", 14));

        }

    }
}
