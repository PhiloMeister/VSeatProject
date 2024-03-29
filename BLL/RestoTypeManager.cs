﻿using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BLL
{
    class RestoTypeManager
    {
        private IRestoTypeDB restoTypeDB { get; }

        public RestoTypeManager(IConfiguration conf)
        {
            restoTypeDB = new RestoTypeDB(conf);
        }


        public List<RestoType> GetRestoTypes()
        {
            return restoTypeDB.GetRestoTypes();
        }
        public RestoType GetRestoType(string typeName)
        {
            return restoTypeDB.GetRestoType(typeName);
        }

        public RestoType addRestoType(RestoType restoType)
        {
            return restoTypeDB.addRestoType(restoType);
        }

    }
}
