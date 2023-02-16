using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemoo
{
    public class ProductDal
    {
        #region Class İçerik
        //update
        //insert
        //delete
        ///işlemlerini içeren bir sınıftır.
        #endregion

        #region Verileri Listeleme 

        //method oluşturulur
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand commend = new SqlCommand("select*from Products", _connection); //komut oluşturuldu ve bağlantıya aktarıldı.
            SqlDataReader reader = commend.ExecuteReader(); // sadece select sorgularında bu çalıştırılır.

            List<Product> products = new List<Product>();
            while (reader.Read()) //reader içindeki verileri tek tek oku
            {

                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };

                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;


        }


        public DataTable GetAll2()
        {

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand commend = new SqlCommand("select*from Products", _connection); //komut oluşturuldu ve bağlantıya aktarıldı.
            SqlDataReader reader = commend.ExecuteReader(); // sadece select sorgularında bu çalıştırılır.

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            return dataTable;
            #endregion

        }

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery(); //çalıştırıldı.

            _connection.Close();

        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount WHERE Id=@Id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);

            command.ExecuteNonQuery(); //çalıştırıldı.

            _connection.Close();

        }

        public void Delete(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("delete from Products where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);

            command.ExecuteNonQuery(); //çalıştırıldı.
            _connection.Close();
        }


    }
}
