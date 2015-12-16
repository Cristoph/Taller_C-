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
        public int _code;
        public string _description;
        public int _buyValue;
        public int _stock;
        public int _stockMin;
        public int _stockMax;
        public bool _status;
        public int _provider; // esta pordria ser referencial Provider Provider

        //Constructor: Empty
        public Product()
        {
        }

        //Constructor: Full
        public Product(int code, string description, int buyValue, int stock, int stockMin, int stockMax, bool status, int provider)
        {
            this._code = code;
            this._description = description;
            this._buyValue = buyValue;
            this._stock = stock;
            this._stockMin = stockMin;
            this._stockMax = stockMax;
            this._status = status;
            this._provider = provider;
        }


        // Methods

        public DataTable get_all()
        {
            string query = "SELECT * FROM PRODUCTOS";
            ConexionBD cnn = new ConexionBD();
            return cnn.traerDatosBD(query);
        }


        


    }
}
