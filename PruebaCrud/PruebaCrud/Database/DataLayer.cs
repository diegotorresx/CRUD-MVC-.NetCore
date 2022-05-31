
using Dapper;
using PruebaCrud.Models;
using System.Data;
using System.Data.SqlClient;

namespace PruebaCrud.Database
{
    //Clase que permite las conexiones y las interacciones con la base de datos por mediod e estores procedures
    public class DataLayer
    {
        
        private string connection { get; set; }
        public DataLayer()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            connection = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }
        public List<PaisesModel> SelectPaises()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<PaisesModel>("sp_SelectPaises", CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public PaisesModel SelectPais(int id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<PaisesModel>("sp_SelectPais", new { id = id}, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<CiudadesModel> SelectCiudades(int id_pais)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<CiudadesModel>("sp_SelectCiudad", new { id_pais = id_pais }, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<CiudadesModel> SelectAllCiudades()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<CiudadesModel>("sp_SelectAllCiudades", commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CiudadesModel SelectAOneCity(int ciudadId)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<CiudadesModel>("sp_SelectOneCity", new { id = ciudadId},commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<GirosModel> SelectGiros (int id_ciudad)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<GirosModel>("sp_SelectGiros", new { id_ciudad = id_ciudad }, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<GirosModel> SelectAllGiros()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<GirosModel>("sp_SelectAllGiros", commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GirosModel SelectOneGiros(int id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<GirosModel>("sp_SelectOneGIRO", new { id = id}, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertPaises(PaisesModel pais)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_InsertPaises", new { nombre = pais.nombre}, commandType:CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsertCiudad(CiudadesModel ciudad)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_InsertCIUDADES", new { nombre = ciudad.nombre, id_pais = ciudad.id_pais }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsertGiros(GirosModel giro)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_InsertGiros", new { giro_recibido = giro.GIR_RECIBO, giro_Ciudad_id = giro.GIR_CIUDAD_ID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdatePaises(PaisesModel pais)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_UpdatePaises", new { nombre = pais.nombre, id = pais.id_pais }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateCiudad(CiudadesModel ciudad)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_UpdateCiudades", new { id_ciudad = ciudad.id_ciudad, nombre = ciudad.nombre, id_pais = ciudad.id_pais }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdatetGiros(GirosModel giro)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_UpdateGiros", new { GIR_GIRO_ID = giro.GIR_GIRO_ID , GIR_RECIBO = giro.GIR_RECIBO, GIR_CIUDAD_ID = giro.GIR_CIUDAD_ID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeletePaises(int pais)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_DeletePaises", new { id = pais }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteCiudad(int ciudad)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_DeleteCiudades", new { id = ciudad }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteGiros(int giro)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<int>("sp_DeleteGiros", new { id = giro }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string SelectPaisSelected()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    return db.Query<string>("sp_SelectPaisSelected", commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdatePaisSelected(string id_pais)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connection))
                {
                    db.Open();
                    db.Execute("sp_UpdatePaisSelected", new { id_pais = id_pais }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
