using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyRESTService
{
    [DataContract]
    public class CIDR
    {
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string IPType { get; set; }

        [DataMember]
        public string Details { get; set; }

        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string parentId { get; set; }

        [DataMember]
        public string label { get; set; }

        [DataMember]
        public string hrefDocument { get; set; }

        [DataMember]
        public bool expand { get; set; }
    }

    public partial class CIDRs
    {
        private static readonly CIDRs _instance = new CIDRs();

        private CIDRs()
        {
        }

        public static CIDRs Instance
        {
            get { return _instance; }
        }

        public List<CIDR> CIDRList
        {
            get { return cidrs; }
        }

        private List<CIDR> cidrs = new List<CIDR>()
        {
                new CIDR() {id= "1", parentId= "null", label="root",expand= true},
                new CIDR() {id= "2", parentId= "1", label="Network",expand= false,Address = "10.10.0.0/27",IPType="Network"},
                new CIDR() {id= "3", parentId= "1", label="Broadcast",expand= false,Address = "10.10.0.31",IPType="Broadcast" },
                new CIDR() {id= "4", parentId= "1", label="Subnet Mask",expand= false,Address = "255.255.255.224",IPType="Subnet Mask"},
                new CIDR() { id= "5", parentId= "4", label="10.10.0.1",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224"},

                new CIDR() { id= "35", parentId= "5", label="Documents",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "36", parentId= "35", label="Word",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224"},
                
                new CIDR() { id= "38", parentId= "36", label="Word doc 1",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224",hrefDocument="Test.docx"},
                new CIDR() { id= "39", parentId= "36", label="Word doc 2",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224",hrefDocument="Test.docx"},
                
                
                
                new CIDR() { id= "37", parentId= "35", label="Excel ",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "40", parentId= "37", label="Excel doc 1",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224",hrefDocument="Test.xlsx"},
                new CIDR() { id= "41", parentId= "37", label="Excel doc 2",expand= false,Address = "10.10.0.1",IPType="Individual Host IP",Details="255.255.255.224",hrefDocument="Test.xlsx"},



                new CIDR() { id= "6", parentId= "4", label="10.10.0.2",expand= false,Address = "10.10.0.2",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "7", parentId= "4", label="10.10.0.3",expand= false,Address = "10.10.0.3",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "8", parentId= "4", label="10.10.0.4",expand= false,Address = "10.10.0.4",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "9", parentId= "4", label="10.10.0.5",expand= false,Address = "10.10.0.5",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "10", parentId= "4", label="10.10.0.6",expand= false,Address = "10.10.0.6",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "11", parentId= "4", label="10.10.0.7",expand= false,Address = "10.10.0.7",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "12", parentId= "4", label="10.10.0.8",expand= false,Address = "10.10.0.8",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "13", parentId= "4", label="10.10.0.9",expand= false,Address = "10.10.0.9",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "14", parentId= "4", label="10.10.0.10",expand= false,Address = "10.10.0.10",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "15", parentId= "4", label="10.10.0.11",expand= false,Address = "10.10.0.11",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "16", parentId= "4", label="10.10.0.12",expand= false,Address = "10.10.0.12",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "17", parentId= "4", label="10.10.0.13",expand= false,Address = "10.10.0.13",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "18", parentId= "4", label="10.10.0.14",expand= false,Address = "10.10.0.14",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "19", parentId= "4", label="10.10.0.15",expand= false,Address = "10.10.0.15",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "20", parentId= "4", label="10.10.0.16",expand= false,Address = "10.10.0.16",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "21", parentId= "4", label="10.10.0.17",expand= false,Address = "10.10.0.17",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "22", parentId= "4", label="10.10.0.18",expand= false,Address = "10.10.0.18",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "23", parentId= "4", label="10.10.0.19",expand= false,Address = "10.10.0.19",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "24", parentId= "4", label="10.10.0.20",expand= false,Address = "10.10.0.20",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "25", parentId= "4", label="10.10.0.21",expand= false,Address = "10.10.0.21",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "26", parentId= "4", label="10.10.0.22",expand= false,Address = "10.10.0.22",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "27", parentId= "4", label="10.10.0.23",expand= false,Address = "10.10.0.23",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "28", parentId= "4", label="10.10.0.24",expand= false,Address = "10.10.0.24",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "29", parentId= "4", label="10.10.0.25",expand= false,Address = "10.10.0.25",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "30", parentId= "4", label="10.10.0.26",expand= false,Address = "10.10.0.26",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "31", parentId= "4", label="10.10.0.27",expand= false,Address = "10.10.0.27",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "32", parentId= "4", label="10.10.0.28",expand= false,Address = "10.10.0.28",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "33", parentId= "4", label="10.10.0.29",expand= false,Address = "10.10.0.29",IPType="Individual Host IP",Details="255.255.255.224"},
                new CIDR() { id= "34", parentId= "4", label="10.10.0.30",expand= false,Address = "10.10.0.30",IPType="Individual Host IP",Details="255.255.255.224"}
        };
    }
}