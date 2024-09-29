
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZomatoLikeApplication
{
    public class ServiceNowIntegration
    {
        
            private static readonly HttpClient client = new HttpClient();

            public static async Task<List<Incident>> GetIncidentsAsync()
            {
                try
                {

                    var response = await client.GetStringAsync("https://instance.service-now.com/api/now/table/incident");

                    // Deserialize the JSON response into a list of incidents

                    var incidentResponse = JsonConvert.DeserializeObject<IncidentResponse>(response);
                    return incidentResponse.Result; 
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error in fetching incidents: {ex.Message}");
                    return new List<Incident>();
                }
            }
        }

        public class Incident
        {
        // The unique ID for the incident
        public string SysId { get; set; }
        // Description of the incident
        public string ShortDescription { get; set; } 
        }

        public class IncidentResponse
        {
            public List<Incident> Result { get; set; }
        }
    }

