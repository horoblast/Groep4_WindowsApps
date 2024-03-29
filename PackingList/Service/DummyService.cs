﻿using PackingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Service
{
    class DummyService
    {
        List<Reis> reizen;

        public DummyService()
        {
            reizen = new List<Reis>();
            reizen.Add(new Reis() { Title = "New York", DepartureDate = new DateTime(2015, 12, 6) });
            reizen.Add(new Reis() { Title = "California", DepartureDate = new DateTime(2015, 12, 15) });
            reizen.Add(new Reis() { Title = "Gent", DepartureDate = new DateTime(2015, 12, 20) });
        }

        public List<Reis> haalReizenOp()
        {
            return reizen;
        }
    }
}
