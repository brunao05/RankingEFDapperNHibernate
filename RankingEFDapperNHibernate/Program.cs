﻿using System;
using DapperFramework.Repositories;
using Data;
using EntityFrameworkCoreFramework.Repositories;
using Models;
using NHibernateFramework.Repositories;

namespace RankingEFDapperNHibernate
{
    class Program
    {
        static void Main(string[] args)
        { 
            Execute(new NHibernateRepository());

            Execute(new DapperRepository());

            Execute(new DapperContribRepository());

            Execute(new EFRepository());

            Results.Show();
        }

        static void Execute(IRepository repository)
        {
            using (var dataRepository = new DataRepository(repository))
            {
                dataRepository.AddCustomers();

                dataRepository.AddAllCustomers();

                dataRepository.QueryCustomers();
            }

            Console.WriteLine();
        }
    }
}
