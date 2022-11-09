﻿using CashRegister.DAL;
using CashRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CashRegister_DAL.DataAccessLayer
{
    public class EinkaufsPositionDAL
    {
        CashRegisterContextDB context = new CashRegisterContextDB();
        public EinkaufsPositionDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }
        public void Create(int anzahl, Produkt produkt, List<EinkaufsPosition> einkaufsPositionAktuell)
        {
            EinkaufsPosition einkaufsPosition = new EinkaufsPosition
            {
                Anzahl = anzahl,
                Produkt = produkt,
            };
            einkaufsPositionAktuell.Add(einkaufsPosition);
            context.Add(einkaufsPosition);
        }
        public bool CheckIfAdded (Produkt newProdukt, List<EinkaufsPosition> OldProdukte)
        {
            foreach (var produkt in OldProdukte)
            {
                if (newProdukt.Id == produkt.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}