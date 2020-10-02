//-----------------------------------------------------------------------
// <copyright file="JsonReader.cs" company="BridgeLabz">
// Copyright (c) 2020 All Rights Reserved
// </copyright>
//-----------------------------------------------------------------------

using Newtonsoft.Json;
using System;
using System.IO;

namespace AzureBookWagon.Reader
{
    /// <summary>
    /// Json file reader
    /// </summary>
    public class JsonReader
    {
        public string email;
        public string password;
        public string json;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonReader"/> class
        /// </summary>
        public JsonReader()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string uptobinpath = path.Substring(0, path.LastIndexOf("bin")) + "credentials.json";
            string localPath = new Uri(uptobinpath).LocalPath;
            using (StreamReader reader = new StreamReader(localPath))
            {
                json = reader.ReadToEnd();
            }
            dynamic array = JsonConvert.DeserializeObject(json);
            email = array["email"];
            password = array["password"];
        }
    }
}