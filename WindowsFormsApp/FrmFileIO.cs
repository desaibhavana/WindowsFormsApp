using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;



namespace WindowsFormsApp
{
    public partial class FrmFileIO : Form
    {
        public FrmFileIO()
        {
            InitializeComponent();
            
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\data.txt", FileMode.Create);

            StreamWriter writer = new StreamWriter(stream);

            writer.Write(txtArea.Text);

            writer.Flush();
            stream.Close();

            txtArea.Clear();
            MessageBox.Show("File Created");
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "E:\\TrainingFiles\\GodrejJuly24;";
         
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;


            FileStream stream = new FileStream(path, FileMode.Open);

            StreamReader reader = new StreamReader(stream);

            txtArea.Clear();

            txtArea.Text = reader.ReadToEnd();

            reader.Close();
            stream.Close();


        }

        private void btnReadWrite_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\city.txt", FileMode.OpenOrCreate);

            StreamWriter writer = new StreamWriter(stream);
            StreamReader reader = new StreamReader(stream);

           writer.BaseStream.Seek(0,SeekOrigin.End);    
            writer.Write(txtArea.Text);

            writer.Flush();

            txtArea.Clear();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            txtArea.Text= reader.ReadToEnd();

            writer.Close();
            reader.Close();
            stream.Close();


            //Object initializer
            //Product product = new Product();
            //product.ProdId = 101;
            //product.ProductName = "mobile";
            //product.Price = 20000;

           


        }

        private void btnWriteObject_Click(object sender, EventArgs e)
        {
            Product product = new Product() { ProdId = 101, ProductName = "tea" };

            //Collecyion initializer
            //List<Product> products = new List<Product>()
            //{
            //    product,
            //    new Product() {ProdId=2,ProductName="juice",Price=300}, new Product()
            //};

            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\productdata.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(product);  //ToString()
            writer.Flush();
            stream.Close();
        }

        private void btnWriteBinary_Click(object sender, EventArgs e)
        {
            Product product = new Product() { ProdId = 101, ProductName = "tea" };
            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\productdata.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, product);
            stream.Close();         
        }

        private void btnReadBinary_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\productdata.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Product product = formatter.Deserialize(stream) as Product;
            stream.Close(); 
            txtArea.AppendText("\n");
            txtArea.AppendText(product.ProdId + " " + product.ProductName + " " + product.Price);
        }

        private void btnWriteJSON_Click(object sender, EventArgs e)
        {
            Product product = new Product() { ProdId = 101, ProductName = "tea" };
            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\productjson.txt", FileMode.Create);
            //System.Text.JSON
            JsonSerializer.Serialize(stream, product);
            stream.Close();
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"E:\TrainingFiles\GodrejJuly24\productjson.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string jsondata = reader.ReadToEnd();
            stream.Close();
            txtArea.Clear();
            txtArea.AppendText(jsondata);

            Product product = JsonSerializer.Deserialize<Product>(jsondata);
            txtArea.AppendText("\n");
            txtArea.AppendText(product.ProdId + " " + product.ProductName + " " + product.Price);
        }
    }
}
