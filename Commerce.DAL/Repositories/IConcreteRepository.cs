﻿using System.Collections.Generic;

namespace Commerce.DAL.Repositories
{

    public interface IConcreteRepository<T>
    {
        bool Insert(T toInsert);
        bool Update(T toUpdate);
        bool Delete(T toDelete);
        List<T> Get();

        T GetOne(int PK);
    }

}