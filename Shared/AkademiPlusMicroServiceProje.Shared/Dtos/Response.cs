using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AkademiPlusMicroServiceProje.Shared.Dtos
{
    public class Response<T>
    {
        public T Data { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        [JsonIgnore]
        public bool IsSuccesful { get; set; }
        public List<string> Errors { get; set; }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { StatusCode = statusCode, Data = default(T), IsSuccesful = true };
        }

        public static Response<T> Success(int statusCode, T data)
        {
            return new Response<T> { StatusCode = statusCode, Data = data, IsSuccesful = true };
        }
        public static Response<T> Fail(string error,int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string> { error },
                StatusCode = statusCode,
                IsSuccesful = false
            };
        }
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSuccesful = false
            };
        }
    }
}
