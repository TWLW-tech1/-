using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 库存管理
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-SJM76FT; Database=超市库存;User Id =sa;Password =123456";
        private void button8_Click(object sender, EventArgs e)
        {
            // 获取文本框中的输入值
            string productID = textBox1.Text;
            string employeeID = textBox2.Text;
            string brand = textBox3.Text;
            string productName = textBox4.Text;
            decimal price = Convert.ToDecimal(textBox5.Text);
            int quantity = Convert.ToInt32(textBox6.Text);

            // 创建连接对象和 SQL 命令对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO 商品 (商品编号, 员工编号,品牌,商品名称,价格,库存) VALUES (@ProductID, @EmployeeID, @Brand, @ProductName, @Price, @Quantity)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 添加参数并设置值
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    // 打开连接并执行命令
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        MessageBox.Show("成功添加 " + rowsAffected + " 行记录。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("添加记录时出错：" + ex.Message);
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 获取文本框中的输入值
            string productID = textBox7.Text;
            string columnName = textBox8.Text;
            string newValue = textBox9.Text;

            // 创建连接对象和 SQL 命令对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE 商品 SET {columnName} = @NewValue WHERE 商品编号= @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 添加参数并设置值
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@ProductID", productID);

                    // 打开连接并执行命令
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        MessageBox.Show($"成功修改 {rowsAffected} 行记录。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"修改记录时出错：{ex.Message}");
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string productID = textBox10.Text;

            // 创建连接对象和 SQL 命令对象
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM 商品 WHERE 商品编号 = @ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 添加参数并设置值
                    command.Parameters.AddWithValue("@ProductID", productID);

                    // 打开连接并执行命令
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        textBox10.Text = "";
                        MessageBox.Show($"成功删除 {rowsAffected} 行记录。");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"删除记录时出错：{ex.Message}");
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }
    }
}
