using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult //işlem sonucu dönecek(succes ve message) bir de IDataResult içindekiler dönecek
    {
        T Data { get; }
    }
}
