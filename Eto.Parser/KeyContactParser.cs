using Eto.Parser.Entities;
using Eto.Parser.Entities.TouchPoint;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eto.Parser
{
    public class KeyContactParser
    {
        public static string GetRelationshipsAsHtml(string subjectId, string touchpointId, string domainRoot)
        {
            var keyContactResponseJson = GetKeyContactList(subjectId, touchpointId, domainRoot);
            var participantInfoJson = GetParticipantInfo(subjectId, domainRoot);

            IEnumerable<KeyContact> keyContactsList = JsonConvert.DeserializeObject<List<KeyContact>>(keyContactResponseJson);
            var participant = JsonConvert.DeserializeObject<Participant>(participantInfoJson);

            var output = new StringBuilder();
            output.Append($"<ul class='flex flex-col gap-5 max-w-[380px]'>");
            foreach (KeyContact contact in keyContactsList)
            {
                if (contact.ResponseElements.Exists(r => r.ElementType == 4) && contact.ResponseElements.Exists(r => r.ElementType == 5))
                {
                    string relationship = contact.ResponseElements.First(r => r.ElementType == 4).Value;
                    string contactName = contact.ResponseElements.First(r => r.ElementType == 5).Value;
                    var relationshipElementChoice = contact.ResponseElements.First(r => r.ElementType == 4).ResponseElementChoices[0];

                    output.Append($"<li class=\"flex flex-wrap flex-row gap-x-6 gap-y-2 gap-6\"><span>{contactName}, {relationship} {participant.FirstName} {participant.LastName}</span>");
                    output.Append($"<span>");

                    var editUri = $"/en-ca/My-Profile/Edit-Key-Contact?n={contactName}&tpecid={relationshipElementChoice.TouchPointElementChoiceID}&tprid={contact.TouchPointResponseID}";
                    var editLinkClasses = "text-primary visited:text-primary hover:text-primary-lighter no-underline bg-cultured-blue p-2 rounded text-sm uppercase tracking-wider font-bold";

                    output.Append($"<a href=\"{editUri}\" class=\"{editLinkClasses}\">Edit</a>");
                    output.Append("</span>");
                    output.Append("</li>");
                }
            }
            output.Append($"</ul>");
            return output.ToString();
        }

        private static string GetKeyContactList(string subjectId, string touchpointId, string domainRoot)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=KeyContacts&SubjectId={subjectId}&TouchpointId={touchpointId}");

            var responseJson = Common.ExecuteApiCall(apiUrl);
            return responseJson;
        }

        private static string GetParticipantInfo(string subjectId, string domainRoot)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=ParticipantBySubjectId&id={subjectId}");

            var responseJson = Common.ExecuteApiCall(apiUrl);
            return responseJson;
        }

        public static string GetRelationshipChoices(string domainRoot)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=KeyContacts-GetRelationshipChoices");

            var responseJson = Common.ExecuteApiCall(apiUrl);
            var touchPoint = JsonConvert.DeserializeObject<TouchPoint>(responseJson);
            var choices = touchPoint.TouchPointElement.Find(t => t.ElementID == 1345).MultipleChoice.ChoiceValues.ToList();
            var output = from c in choices
                         select new { Text = c.Choice, Value = c.TouchPointElementChoiceID };
            return choices.Count > 0 ? JsonConvert.SerializeObject(output) : string.Empty;
        }

        public static string ParseForRelationshipChoices(string domainRoot)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=KeyContacts-GetRelationshipChoices");

            var responseJson = Common.ExecuteApiCall(apiUrl);
            var touchPoint = JsonConvert.DeserializeObject<TouchPoint>(responseJson);
            var choices = touchPoint.TouchPointElement.Find(t => t.ElementID == 1345).MultipleChoice.ChoiceValues.ToList();
            var output = from c in choices
                         select new { Text = c.Choice, Value = c.TouchPointElementChoiceID };
            return choices.Count > 0 ? JsonConvert.SerializeObject(output) : string.Empty;
        }
    }
}