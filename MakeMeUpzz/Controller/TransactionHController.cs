﻿using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repositori;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionHController
    {
        TransactionHeaderHandler th = new TransactionHeaderHandler();
        public List<TransactionHeader> getAllTransactionHeaders()
        {
            return th.getAllTransactionHeaders();
        }
        public  void InsertTransactionHeader(int tid, int userid,DateTime dt,string status)
        {
            th.InsertTransactionHeader(tid, userid, dt, status);
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return th.getbyuserid(id);

        }
        public List<TransactionHeader> getunhandledtransaction(string a)
        {
            return th.getunhandledtransaction(a);
        }
        public TransactionHeader search(int tid)
        {
            return th.search(tid);
        }
        public void updatestatusbyID(int TransactionID, string statusnew)
        {
            th.updatestatusbyID(TransactionID, statusnew);
        }
        public TransactionHeader GetLastTransaction()
        {
            return th.GetLastTransaction();
        }
        public static int generatetransactionid()
        {
            return TransactionHeaderHandler.generatetransactionid();
        }
    }
}