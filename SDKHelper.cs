/*
Copyright 2015 ReachPlus Alerts

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Reflection;

namespace ReachPlus.SDK.Samples.ReachPlusHotKey
{
    class SDKHelper
    {
        public static Boolean sendAlert()
        {
            System.Configuration.AppSettingsReader reader = new AppSettingsReader();
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string postData = File.ReadAllText(Path.Combine(path,reader.GetValue("alertfile", typeof(string)).ToString()));

            var uri = reader.GetValue("url", typeof(string)).ToString();

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(reader.GetValue("user", typeof(string)).ToString(), reader.GetValue("password", typeof(string)).ToString());

            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/xml";

            request.ContentLength = postData.Length;
            try
            {
                
                StreamWriter postStream = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
                postStream.Write(postData);
                postStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                
            }
            catch (Exception ex)
            {
                //use some logger to log this
                return false;
            }
            return true;
        }
    }
}
