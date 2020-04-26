namespace JUDAKE.WebApi.Utility
{
    public class Constants
    {
        public static class RespuestasResponse
        {
            public const int OK = 200;
            public const int DEBE_LLENAR_DETALLE_MOV = 501;
        }

        public static class RoutesApi
        {
            public const string INSERTAR_VENTA_RAPIDA = "api/Movimiento/InsertarVentaRapida";
        }
    }
}