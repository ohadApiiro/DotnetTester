using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotnetTester
{
    public class Data
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string CreditCard { get; set; }
        public int Age { get; set; }
    }
    
    public class A
    {
        public static Data Fetch()
        {
            return new Data
            {
                Age = 1,
                Name = "Jo",
                Id = "1234",
                CreditCard = "5434364389"
            };
        }
        public static string ReturnString()
        {
            var data = Fetch();
            return data.CreditCard;
        }
    }
    
    [Route("api")]
    public class ApiClass : ControllerBase
    {
        private int? optionalField;
        
        [HttpGet("get")]
        public string Get()
        {
            return A.ReturnString();
        }
        
        [HttpPost("poster")]
        public string Poster(string s)
        {
            return Foo();
        }

        private string Foo()
        {
            return "bla";
        }
    }
}