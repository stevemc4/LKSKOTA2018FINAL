using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LKS2._0.DataSet1TableAdapters;

namespace LKS2._0
{
    static class Database
    {
        public static DataSet1 Data = new DataSet1();
        static EmployeeTableAdapter Employee = new EmployeeTableAdapter();
        static MenuTableAdapter Menu = new MenuTableAdapter();
        static MemberTableAdapter Member = new MemberTableAdapter();
        static OrderTableAdapter Order = new OrderTableAdapter();
        static OrderDetailTableAdapter OrderDetail = new OrderDetailTableAdapter();
        static ReviewTableAdapter Review = new ReviewTableAdapter();
        static PackageTableAdapter Package = new PackageTableAdapter();
        static PackageItemTableAdapter PackageItem = new PackageItemTableAdapter();
        static OdbcCommandBuilder EmployeeBuilder = new OdbcCommandBuilder(Employee.Adapter);
        static OdbcCommandBuilder MenuBuilder = new OdbcCommandBuilder(Menu.Adapter);
        static OdbcCommandBuilder MemberBuilder = new OdbcCommandBuilder(Member.Adapter);
        static OdbcCommandBuilder OrderBuilder = new OdbcCommandBuilder(Order.Adapter);
        static OdbcCommandBuilder OrderDetailBuilder = new OdbcCommandBuilder(OrderDetail.Adapter);
        static OdbcCommandBuilder ReviewBuilder = new OdbcCommandBuilder(Review.Adapter);
        static OdbcCommandBuilder PackageBuilder = new OdbcCommandBuilder(Package.Adapter);
        static OdbcCommandBuilder PackageItemBuilder = new OdbcCommandBuilder(PackageItem.Adapter);

        public static void Init()
        {
            Employee.Fill(Data.Employee);
            Menu.Fill(Data.Menu);
            Member.Fill(Data.Member);
            Order.Fill(Data.Order);
            OrderDetail.Fill(Data.OrderDetail);
            Review.Fill(Data.Review);
            Package.Fill(Data.Package);
            PackageItem.Fill(Data.PackageItem);
            GenerateCommands(EmployeeBuilder);
            GenerateCommands(MenuBuilder);
            GenerateCommands(MemberBuilder);
            GenerateCommands(OrderBuilder);
            GenerateCommands(OrderDetailBuilder);
            GenerateCommands(ReviewBuilder);
            GenerateCommands(PackageBuilder);
            GenerateCommands(PackageItemBuilder);
        }

        static void GenerateCommands(OdbcCommandBuilder builder)
        {
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
        }

        public static void Transact(DataTable table)
        {
            switch(table.TableName)
            {
                case "Employee": Employee.Adapter.Update(Data.Employee); break;
                case "Menu": Menu.Adapter.Update(Data.Menu); break;
                case "Member": Member.Adapter.Update(Data.Member); break;
                case "Order": Order.Adapter.Update(Data.Order); break;
                case "OrderDetail": OrderDetail.Adapter.Update(Data.OrderDetail); break;
                case "Review": Review.Adapter.Update(Data.Review); break;
            }
        }
        public static void Commit()
        {
            Data.AcceptChanges();
        }
    }
}
