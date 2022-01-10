using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BibliotecaDatos
{
    public static class Persona
    {

        private static string cadenaCon = @"server=DESKTOP-83B08MV\SQLEXPRESS; database=TI2021 ; integrated security = true";
        public static DataTable getDatos()
        {

            string sql = " select cedula, apellidos,nombres, fechaNacimiento, peso" + " from personas orden by apellidos, nombres";
            SqlConnection conexion = new SqlConnection(cadenaCon);
            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataAdapter ad = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt; 
        }
        public static int insertar(string cedula, string apellidos, string nombres, DateTime fechaNac, double peso)
        {
            SqlConnection conexion = new SqlConnection(cadenaCon);

            //2. Definir una operacion 
            string sql = "insert into personas(cedula,apellidos,nombres,fechaNacimiento,peso) ";
            sql += "values (@cedula,@apellidos,@nombres,@fechaNacimiento,@peso)";

            //3. Ejecutar la operacion 
            SqlCommand comando = new SqlCommand(sql, conexion);

            //3.1 configurar los parametros:@cedula,@apellidos,@nombres,@fechaNacimiento,@peso

            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            comando.Parameters.Add(new SqlParameter("@apellidos", apellidos));
            comando.Parameters.Add(new SqlParameter("@nombres", nombres));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento", fechaNac));
            comando.Parameters.Add(new SqlParameter("@peso", peso));

            //3.2 Abrir conexion 

            conexion.Open();

            //3.3 Insertar el registro en la base de datos BDD

            int res = comando.ExecuteNonQuery();

            //4. Cerrar la conexion 
            conexion.Close();

            return res;
        }

        public static int borrar(string cedula)
        {
            SqlConnection conexion = new SqlConnection(cadenaCon);

            //2. Definir una operacion 
            string sql = "delete from personas ";
            sql += "where cedula=@cedula";

            //3. Ejecutar la operacion 
            SqlCommand comando = new SqlCommand(sql, conexion);

            //3.1 configurar el parametro:@cedula

            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            //3.2 Abrir conexion 

            conexion.Open();

            //3.3 Borra el registro en la base de datos BDD

            int res = comando.ExecuteNonQuery();

            //4. Cerrar la conexion 
            conexion.Close();

            return res;
        }


    }
}
