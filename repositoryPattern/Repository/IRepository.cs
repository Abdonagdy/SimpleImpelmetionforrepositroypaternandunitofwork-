﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositoryPattern.interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities {get;}
        void Remove(T entity);
        void Add(T entity);


    }
}
