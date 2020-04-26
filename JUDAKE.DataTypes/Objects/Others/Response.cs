using System;

namespace JUDAKE.DataTypes.Objects.Others
{
    public class Response<T>
    {
        public bool IsCorrect { get; set; }
        public string Status { get; set; }
        public T Value { set; get; }
        public Response() { }
        public Response(bool isCorrect) { IsCorrect = isCorrect; }
        public Response(bool isCorrect, T valor) : this(isCorrect) { Value = valor; }
        public Response(bool isCorrect, T valor, string status) : this(isCorrect) { Value = valor; Status = status; }
        public Response(bool isCorrect, T valor, string status, int estado) : this(isCorrect) { Value = valor; Status = status; }

        public static implicit operator Response<T>(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
