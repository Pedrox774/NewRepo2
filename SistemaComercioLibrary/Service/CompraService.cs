﻿using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Persistence.Context;
using SistemaComercioLibrary.Port;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Service
{
    public class CompraService : ICompraPort
    {

        private DataBaseContext _db = new DataBaseContext();

        public int Count()
        {
            return _db.Compra.Count();
        }
        public void AddCompra(Compra compra)
        {
            _db.Compra.Add(compra);
            _db.SaveChanges();
        }

        public void ConsultCompra(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void DelCompra(string id)
        {
            throw new NotImplementedException();
        }

        public Compra GetCompra()
        {
            throw new NotImplementedException();
        }

        public void IssueReportCompra(List<Compra> situacaoCompra)
        {
            throw new NotImplementedException();
        }

        public void ReadCompra(List<Compra> compra)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompra(string id)
        {
            throw new NotImplementedException();
        }
    }
}
