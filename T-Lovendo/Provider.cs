using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace T_Lovendo
{
    class Provider
    {
        public int rut;
        public char dv;
        public string name;
        public string lastname;
        public string description;
        public string address;
        public string phone;

        //Constructor: Empty
        public Provider()
        {   
        }

        //Constructor: Full
        public Provider(int rut, char dv, string name, string lastname, string description, string address, string phone)
        {
            this.rut = rut;
            this.dv = dv;
            this.name = name;
            this.lastname = lastname;
            this.description = description;
            this.address = address;
            this.phone = phone;
        }

        //-------------------- CRUD Methods --------------------//
        //#### SELECT *
        public DataTable GetAll()
        {
            string query = "SELECT * FROM PROVEEDOR";
            ConexionBD cnn = new ConexionBD();
            return cnn.traerDatosBD(query);
        }

        public DataTable GetAll_ID()
        {
            string query = "SELECT rut FROM PROVEEDOR";
            ConexionBD cnn = new ConexionBD();
            return cnn.traerDatosBD(query);
        }

        //#### Update ior Insert
        public bool UpdateOrInsert()
        {
            string query = "UPDATE PROVEEDOR SET rut=" + this.rut + ", dv='" + this.dv + "', nombres='" + this.name + "', apellidos='" + this.lastname +
                                                   "', descripcion='" + this.description + "', direccion='" + this.address + "', nroContacto='" + this.phone +
                                                   "' WHERE rut = " + this.rut +
                                                   " IF @@ROWCOUNT=0 " +
                                                   "INSERT INTO PROVEEDOR VALUES (" + this.rut + ",'" + this.dv + "','" + this.name + "','" + this.lastname + "','" +
                                                           this.description + "','" + this.address + "','" + this.phone + "')";
            ConexionBD cnn = new ConexionBD();
            if (cnn.manipularDatosBD(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //#### DELETE
        public bool Delete(string rut)
        {
            int intRut = int.Parse(rut);
            string query = "DELETE FROM PROVEEDOR WHERE rut=" + intRut + ";";
            ConexionBD cnn = new ConexionBD();
            if (cnn.manipularDatosBD(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //-------------------- Search Methods --------------------//
        public DataTable Search(string value) //TODO catch e
        {

            string query = "SELECT * FROM PROVEEDOR WHERE rut LIKE '%" + value +
                                                    "%' OR nombres LIKE '%" + value +
                                                    "%' OR apellidos LIKE '%" + value +
                                                    "%' OR descripcion LIKE '%" + value +
                                                    "%' OR direccion LIKE '%" + value +
                                                    "%' OR nroContacto LIKE '%" + value + 
                                                    "%';";
            Console.WriteLine(query);
            ConexionBD cnn = new ConexionBD();
            return cnn.traerDatosBD(query);
        }

        //-------------------- Custom Methods --------------------//

        //#### Calculate digito verificador
        //protected bool validarRut(string rut ) 
        //{
            
        //    bool validacion = false;
             
        //    try 
        //     {
        //        rut =  rut.ToUpper();
        //        rut = rut.Replace(".", "");
        //        rut = rut.Replace("-", "");
        //        int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
 
        //        char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
 
        //        int m = 0, s = 1;
        //        for (; rutAux != 0; rutAux /= 10) {
        //           s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
        //        }
        //        if (dv == (char) (s != 0 ? s + 47 : 75)) {
        //           validacion = true;
        //        }
        //     } catch (Exception) 
        //     {

        //     }
        //    return validacion;
        //}



    }
}
