﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void dodajGatunek(Gatunek g);

        [OperationContract]
        void edytujGatunek(Gatunek g);

        [OperationContract]
        void usunGatunek(int id);

        [OperationContract]
        void dodajProducenta(Producent p);

        [OperationContract]
        void edytujProducenta(Producent p);

        [OperationContract]
        void usunProducenta(int id);

        [OperationContract]
        void dodajGre(Gry g);

        [OperationContract]
        void edytujGre(Gry g);

        [OperationContract]
        void usunGre(int id);

        [OperationContract]
        List<GryProdGatOc> wyswietlGry(int i, string tytul, int p, int g);

        [OperationContract]
        void dodajOcene(Oceny o);

        [OperationContract]
        void edytujOcene(Oceny o);

        [OperationContract]
        void usunOcene(int id);

        [OperationContract]
        List<GryProdGatOc> wyswietlGre(int id);

        [OperationContract]
        void ustawPlatforme(List<GryProdGatOc> lst);

        [OperationContract]
        List<Producent> wyswietlProducentow();

        [OperationContract]
        List<Gatunek> wyswietlGatunki();

        [OperationContract]
        int pobierzOcenaId();

        [OperationContract]
        List<Producent> wyswietlProducent(int id);

        [OperationContract]
        List<Gatunek> wyswietlGatunek(int id);

        [OperationContract]
        double sredniaocena(double a, double b, double c);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
