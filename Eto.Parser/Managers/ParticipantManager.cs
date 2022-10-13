using Eto.Parser.Entities;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Eto.Parser.Managers
{
    public interface IParticipantManager
    {
        Participant GetParticipant(string clId, string domainRoot);

        Task<string> GetParticipantBySubjectId(string subjectId, string domainRoot);
    }

    public class ParticipantManager : IParticipantManager
    {
       
        /// <summary>
        /// Gets the Participant based on the SubjectId
        /// </summary>
        /// <param name="subjectId"></param>
        /// <param name="domainRoot"></param>
        /// <returns></returns>
        public Task<string> GetParticipantBySubjectId(string subjectId, string domainRoot)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=ParticipantBySubjectId&id={subjectId}");

            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            var response = httpClient.GetAsync(apiUrl);
            response.Result.EnsureSuccessStatusCode();

            var strRespone = response.Result.Content.ReadAsStringAsync();
            return strRespone;
        }

        /// <summary>
        /// Gets the details of the specified Particpant
        /// </summary>
        /// <param name="clId"></param>
        /// <param name="domainRoot"></param>
        /// <returns></returns>
        public Participant GetParticipant(string clId, string domainRoot)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=Participant&id={clId}");

            var responseJson = Common.ExecuteApiCall(apiUrl);

            return JsonConvert.DeserializeObject<Participant>(responseJson);
        }
    }
}