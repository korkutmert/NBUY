﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);    // Id 'ye göre entity getirecek.
        Task<List<T>> GetAllAsync(); // İlgili tüm kayıtları getirecek
        Task CreateAsync (T entity); // Yeni kayıt yaratacak
        void Update(T entity); // Kayıt Güncelleyecek
        void Delete (T entity);// kayıt silecek ==> T olarak product yollarsam onu siler category yollarsam onu siler.
    }
}
