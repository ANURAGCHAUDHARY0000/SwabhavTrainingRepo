using System;


namespace InterfaceRepositoryApp.Model
{
    internal interface IRepository
    {
        void Create();
        void Read();
        void Update();
        void Delete();

    }
}
