 public class BdComun
    {
        
       public static MySqlConnection ObtenerConexion()
       {
           MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Tutorial; Uid=root; pwd=;");
           
               conectar.Open();
               return conectar;        
       }
                     
    }