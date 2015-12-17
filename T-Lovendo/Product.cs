using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace T_Lovendo
{
    class Product
    {
        public int code;
        public string description;
        public int buyValue;
        public int stock;
        public int stockMin;
        public int stockMax;
        public bool status;
        public int provider; // esta pordria ser referencial Provider Provider

        //Constructor: Empty
        public Product()
        {
        }

        //Constructor: Full
        public Product(int code, string description, int buyValue, int stock, int stockMin, int stockMax, bool status, int provider)
        {
            this.code = code;
            this.description = description;
            this.buyValue = buyValue;
            this.stock = stock;
            this.stockMin = stockMin;
            this.stockMax = stockMax;
            this.status = status;
            this.provider = provider;
        }

        //-------------------- CRUD Methods --------------------//
        //#### SELECT *
        public DataTable GetAll()
        {
            string query = "SELECT * FROM PRODUCTOS";
            ConexionBD cnn = new ConexionBD();
            return cnn.traerDatosBD(query);
        }
        //#### INSTERT
        public bool Insert()
        {
          // Se deben validar los datos antes, este metodo se utiliza solo si se encuentra todo validado.
            string query = "INSERT INTO PRODUCTOS VALUES ("+ this.code +",'"+ this.description +"',"+ this.buyValue +","+ 
                                                           this.stock +","+ this.stockMin +","+ this.stockMax +","+ this.status +","+ this.provider +")";
            ConexionBD cnn = new ConexionBD();
            if (cnn.manipularDatosBD(query)){
                return true;
            }else{
            return false;
            }
        }
        //#### UPDATE
        public bool Update()
        {
            // Se deben validar los datos antes, este metodo se utiliza solo si se encuentra todo validado.
            string query = "UPDATE TRABAJADOR SET descripcion='"+ this.description +"',valorCompra="+ this.buyValue +",cantidadStock="+ this.stock +
                                                   ",stockMinimo="+ this.stockMin +",stockMaximo="+ this.stockMax +",estado="+ this.status +",rutProveedor="+ this.provider +  
                                                   " WHERE codigo = " + this.code + ";";
            ConexionBD cnn = new ConexionBD();
            if (cnn.manipularDatosBD(query)){
                return true;
            }else{
                return false;
            }
        }
        //#### DELETE
        public bool Delete()
        {
            string query = "DELETE FROM PRODUCTOS WHERE codigo=" + this.code + ";";
            ConexionBD cnn = new ConexionBD();
            if (cnn.manipularDatosBD(query)){
                return true;
            }else{
                return false;
            }
        }
        //-------------------- Search Methods --------------------//
        public DataTable Search(string value) //TODO catch e
        {

            string query = "SELECT * FROM PRODUCTOS WHERE codigo LIKE '%" + value + 
                                                    "%' OR descripcion LIKE '%" + value +
                                                    "%' OR valorCompra LIKE '%" + value +
                                                    "%' OR cantidadStock LIKE '%" + value +
                                                    "%' OR stockMinimo LIKE '%" + value +
                                                    "%' OR stockMaximo LIKE '%" + value +
                                                    "%' OR rutProveedor LIKE '%" + value + "%';";
            Console.WriteLine(query);
            ConexionBD cnn = new ConexionBD();
            return cnn.traerDatosBD(query);
        }

        //-------------------- Custom Methods --------------------//
        
        //#### Calculate sellValue: 30% plus buyValue
        public double sellValue_calculate(int buyValue){
            double sellValue = (buyValue * 0.3) + buyValue; 
            return sellValue;
        }











        
    }
}
