using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Xml.Serialization;
using log4net;
using SoapService.Logic;
using static SoapService.Models.models;
//using SoapService.Models;

namespace SoapService
{
    /// <summary>
    /// Summary description for SoapWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapWebService : System.Web.Services.WebService
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SoapWebService));


        [WebMethod]
        public Response GetResponse(Person Person2)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                string xmlOutput = "";
                using (StringWriter writer = new StringWriter())
                {
                    serializer.Serialize(writer, Person2);
                    xmlOutput = writer.ToString();
                }
                logger.Debug($"ЗАПРОС: {xmlOutput}");

                if (Person2 == null)
                {
                    logger.Error($"Person is empty || {xmlOutput}");
                    throw new Exception("Person is empty");
                }
                var request = Person2;

                logger.Debug("Start adding process");
                Insert insertRepo = new Insert();
                var save = insertRepo.AddNotaryRequest(request);
                if (save <= 0)
                    throw new Exception($"Ошибка сохранения запроса: {xmlOutput}");

            }
            catch
            {

            }
            // Sample response object with dummy data
            var response = new Response
            {
                messageId = "12345",
                messageDate = DateTime.Now,
                requestId = "67890",
                sender = new Participant { nameKz = "SenderName" },
                receiver = new Participant { nameKz = "ReceiverName" },
                messageResult = new MessageResult { nameKz = "Success" },
                persons = new[]
                {
                Person2,
            }
            };

            return response;
        }
       
    }
    

}
