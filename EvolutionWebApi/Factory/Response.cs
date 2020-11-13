using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace EvolutionWebApi.Factory
{

    public class category
    {
        public string ID { get; set; }
        public string Category { get; set; }
       
    }

    public class CategoryList
    {
        [XmlArray("category")]
        [XmlArrayItem("category")]
        public List<category> categoryLists { get; set; }
        public CategoryList()
        {
            categoryLists = new List<category>();
        }
    }





    public class productCertificate
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string HttpPathName { get; set; }
        public string PathName { get; set; }
        public string ShortName { get; set; }
        public string Search { get; set; }
        public string Category { get; set; }
        public string PartOfAlbum { get; set; }
        public string Albumjpg { get; set; }
        public string Albumpdf { get; set; }
        public string Theme { get; set; }
        public string ThemeName { get; set; }


    }

    public class ProductCertificatesList
    {
        [XmlArray("productCertificate")]
        [XmlArrayItem("productCertificate")]
        public List<productCertificate> productCertificates { get; set; }
        public ProductCertificatesList()
        {
            productCertificates = new List<productCertificate>();
        }
    }



    ////We have to include any custom derived classes using XmlInclude
    [XmlRoot("response")]
    [XmlInclude(typeof(ProductCertificatesList))]
    [XmlInclude(typeof(CategoryList))]
    public class response
    {
        [XmlElement("result")]
        public int result;
        [XmlElement("xmlData")]
        public XmlDocument xmlData;
        //data will accept any type of primitive or strictly typed class object
        [XmlElement("data")]
        public List<object> data;
        [XmlArray("log")]
        [XmlArrayItem("entry")]
        public List<string> log;
        //Constructor (even if empty) is required for XmlSerializer to work as it needs to instantiate the class in order to serialize it
        public response()
        {
            result = -1;
            data = new List<object>();
            log = new List<string>();
        }
        //Simply
        public IList AddProductCertificatesList(ProductCertificatesList list)
        {
            data.Add(list);
            return data;
        }

        public IList AddCategoryList(CategoryList list)
        {
            data.Add(list);
            return data;
        }


        public IList AddStringData(string strData)
        {
            data.Add(strData);
            return data;
        }
    }
}
