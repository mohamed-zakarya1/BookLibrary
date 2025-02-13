﻿using basel.Dto;

namespace basel.Repo
{
    public interface IGenreRepo
    {
        IEnumerable<Genre_Dto> Get();
        Genre_Dto? Get(int id);
        void Update(Genre_Dto Genre, int id);
        void UpdateAll(Genre_Dto Genre, int id);
        void Delete(int id);
        void Add(Genre_Dto Genre);
        void AddAll(Genre_Dto Genre);
    };
}
