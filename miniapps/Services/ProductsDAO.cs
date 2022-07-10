using miniapps.Models;
using System.Data.SqlClient;

namespace miniapps.Services
{
    public class ProductsDAO : IProductDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int Delete(ProductModel product)
        {
            int newIdNumber = -1;

            string sqlStatement = "DELETE FROM dbo.products WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.AddWithValue("@Id", product.Id);

                try
                {
                    connection.Open();
                    newIdNumber = (int)cmd.ExecuteScalar();
                    SqlDataReader reader = cmd.ExecuteReader();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return newIdNumber;
            }
        }

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> foundProducts = new List<ProductModel>();

            string sqlStatement = "SELECT * FROM dbo.products";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        foundProducts.Add(new ProductModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return foundProducts;
        }

        public ProductModel GetProductById(int id)
        {
            ProductModel foundProduct = null;

            string sqlStatement = "SELECT * FROM dbo.products WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProduct = new ProductModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] }; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return foundProduct;
        }

        public int Insert(ProductModel product)
        {
            int newIdNumber = -1;

            string sqlStatement = "INSERT INTO dbo.products (Name, Price, Description) VALUES (@Name, @Price, @Description)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);

                try
                {
                    connection.Open();
                    newIdNumber = (int)cmd.ExecuteScalar();
                    SqlDataReader reader = cmd.ExecuteReader();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return newIdNumber;
            }
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            List<ProductModel> foundProducts = new List<ProductModel>();

            string sqlStatement = "SELECT * FROM dbo.products WHERE name LIKE @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.AddWithValue("@Name", "%" + searchTerm + "%");

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return foundProducts;
            }
        }

        public int Update(ProductModel product)
        {
            int newIdNumber = -1;

            string sqlStatement = "UPDATE dbo.products SET Name = @Name, Price = @Price, Description = @Description WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Id", product.Id);

                try
                {
                    connection.Open();
                    newIdNumber = (int)cmd.ExecuteScalar();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return newIdNumber;
            }
        }
    }
}
