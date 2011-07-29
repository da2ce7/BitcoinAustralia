﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.ausbit.org.Models
{
    /// <summary>
    /// Basic Cert Database
    /// </summary>
    public class Certs
    {
        public Certificate root;
        public List<Certificate> certs { get; set; }


        public Certs()
        {
            certs = new List<Certificate>();

            root = new Certificate();
            root.Name = "Bitcoin Australia Root Certificate";
            root.Level = "Root";
            root.Data = @"-----BEGIN CERTIFICATE-----
MIIC3jCCAoSgAwIBAgIJANIRH55D3ypEMAoGCCqGSM49BAMCMH0xGjAYBgNVBAoM
EUJpdGNvaW4gQXVzdHJhbGlhMSswKQYDVQQLDCJTZWN1cmUgRGlnaXRhbCBDZXJ0
aWZpY2F0ZSBTaWduaW5nMTIwMAYDVQQDDClCaXRjb2luIEF1c3RyYWxpYSBDZXJ0
aWZpY2F0aW9uIEF1dGhvcml0eTAeFw0xMTA3MTcyMTU1MDdaFw0yMTA3MTQyMTU1
MDdaMH0xGjAYBgNVBAoMEUJpdGNvaW4gQXVzdHJhbGlhMSswKQYDVQQLDCJTZWN1
cmUgRGlnaXRhbCBDZXJ0aWZpY2F0ZSBTaWduaW5nMTIwMAYDVQQDDClCaXRjb2lu
IEF1c3RyYWxpYSBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eTBZMBMGByqGSM49AgEG
CCqGSM49AwEHA0IABGJvp+pSPc5TBBoa4ZvftEOByqkS0M/rH0mqi7S1Vyq5YSX0
bgD3R1XGVAx1HrM6bfGUmHxxsUOt2hAZJVVINK+jgewwgekwDAYDVR0TBAUwAwEB
/zALBgNVHQ8EBAMCAa4wHQYDVR0OBBYEFIoLYp5NhYWsSrqI/g6oMvnyjE+NMDsG
A1UdJQQ0MDIGCCsGAQUFBwMBBggrBgEFBQcDAgYIKwYBBQUHAwQGCCsGAQUFBwMD
BggrBgEFBQcDCDBwBgNVHR8EaTBnMDKgMKAuhixodHRwOi8vY2VydC5iaXRjb2lu
LmNvbS5hdS9iYV9jYWNlcnQtY3JsLmNybDAxoC+gLYYraHR0cDovL2NybC5iaXRj
b2luLmNvbS5hdS9iYV9jYWNlcnQtY3JsLmNybDAKBggqhkjOPQQDAgNIADBFAiEA
x1JM3F0AoTlZ2fEi79hXU0CFCtGtQfjCRVqtl/HBM38CIGdvDiFtCv65tCk5i6hf
rBVloAyq84/hiVz5GIo2PVI8    
-----END CERTIFICATE-----";
            root.Thingerprint = "fa5fdf7e7f7d70414d20716ebb97bc48d14ec71d";


            certs.Add(root);
            
        }
    }

    public struct Certificate
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Data { get; set; }
        public string Thingerprint { get; set; }
    }
}