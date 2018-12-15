﻿using CCPhus.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCPhus.API.Data
{
    interface IEntityRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);

        Task<IEnumerable<Photo>> GetPhotos();
        Task<Photo> GetPhoto(int id);

        Task<IEnumerable<Script>> GetScripts();
        Task<Script> GetScript(int id);
    }
}