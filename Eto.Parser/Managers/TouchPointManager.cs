using DotNetNuke.Services.FileSystem;
using Eto.Parser.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Eto.Parser.Managers
{
    public interface ITouchPointManager
    {
        string GetAllParticipantDocs(string clientGuid);

        string GetDocumentListAsHtml(string clientGuid);

        TouchPointResponse GetTouchPointResponse(int touchPointId, int touchPointResponseID);

        string SaveFile(int touchPointId, int touchPointResponseId, int elementId, int elementType);
    }

    public class TouchPointManager : ITouchPointManager
    {
        private readonly string _domainRoot;
        private readonly Dictionary<string, string> _fileExtensionIcons;

        public TouchPointManager(string domainRoot)
        {
            _domainRoot = domainRoot;
            _fileExtensionIcons = new Dictionary<string, string>
            {
                { "pdf", "<i class='far fa-file-pdf'></i>" },
                { "xlsx", "<i class='far fa-file-excel'></i>" },
                { "docx", "<i class='far fa-file-word'></i>" }
            };
        }


        /// <summary>
        /// Gets all the documents for a specific participant
        /// </summary>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public string GetAllParticipantDocs(string subjectId)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(_domainRoot);
            const int _touchPointId = 16;

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=ParticipantDocs-GetAll&subjectId={subjectId}&touchPointId={_touchPointId}");

            var responseJson = Common.ExecuteApiCall(apiUrl);
            return responseJson;
        }

        /// <summary>
        /// Gets a specific TouchPointResponse
        /// </summary>
        /// <param name="touchPointId"></param>
        /// <param name="touchPointResponseID"></param>
        /// <returns></returns>
        public TouchPointResponse GetTouchPointResponse(int touchPointId, int touchPointResponseID)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(_domainRoot);
            Uri apiUrl = new Uri($"{apiBaseUrl}?method=ParticipantDocs-GetTouchPoint&touchPointId={touchPointId}&touchPointResponseID={touchPointResponseID}");
            var responseJson = Common.ExecuteApiCall(apiUrl);

            return JsonConvert.DeserializeObject<TouchPointResponse>(responseJson);
        }

        /// <summary>
        /// Lists the TouchPoints in Descending order by TouchPointReponseId
        /// </summary>
        /// <param name="touchPointId"></param>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public string ListTouchPointResponsesDescending(int touchPointId, int subjectId)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(_domainRoot);
            Uri apiUrl = new Uri($"{apiBaseUrl}?method=ListTouchPointResponses&touchPointId={touchPointId}&subjectId={subjectId}");
            var responseJson = Common.ExecuteApiCall(apiUrl);

            var list = JsonConvert.DeserializeObject<List<TouchPointResponse>>(responseJson).OrderByDescending(x => x.TouchPointResponseID);
            return JsonConvert.SerializeObject(list);
        }

        /// <summary>
        /// Retrieves the TouchPointResponse to find the File Attachment and saves the file to the filesystem
        /// </summary>
        /// <param name="touchPointId"></param>
        /// <param name="touchPointResponseId"></param>
        /// <param name="elementId">ResponseElement Id</param>
        /// <param name="elementType">ResponseElement ElementType enumeration</param>
        /// <returns>The filename of the newly saved file</returns>
        public string SaveFile(int touchPointId, int touchPointResponseId, int elementId, int elementType)
        {
            var touchPointResponse = GetTouchPointResponse(touchPointId, touchPointResponseId);
            ResponseElement responseElement = touchPointResponse.ResponseElements.Find(e => e.ElementID == elementId && e.ElementType == elementType);
            ResponseFileAttachment attachment = responseElement.ResponseFileAttachments[0];

            byte[] buffer = attachment.FileContent.Select(x => (byte)x).ToArray();
            Stream stream = new MemoryStream(buffer);

            var folder = FolderManager.Instance.GetFolder(0, "Temp/");
            string fileName = $"{touchPointResponse.SubjectID}-{attachment.FileName.Replace($"{elementId}~", String.Empty)}";
            FileManager.Instance.AddFile(folder, fileName, stream, true);

            return fileName;
        }

        /// <summary>
        /// Gets the list of Documents as HTML
        /// </summary>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public string GetDocumentListAsHtml(string subjectId)
        {
            var docListJson = GetAllParticipantDocs(subjectId);
            var entTouchPoints = JsonConvert.DeserializeObject<List<TouchPointResponse>>(docListJson);
            var touchPointResponses = (from TouchPointResponse item in entTouchPoints
                                       select GetTouchPointResponse(item.TouchPointID, item.TouchPointResponseID)).ToList();

            if (touchPointResponses.Count == 0) return "<strong>No documents found</strong>";
            var htmlDocList = new StringBuilder();
            htmlDocList.Append(@"<div class='container mx-auto px-5'>");
            htmlDocList.Append(@"<div class='shadow-heavy relative text-base flex flex-col'>");
            htmlDocList.Append(@"<div class='flex flex-row gap-6 items-center bg-cultured-blue text-base py-6 text-davys-grey font-bold font-display tracking-wider'>");
            htmlDocList.Append(@"<div class='px-6'>File name</div>");
            htmlDocList.Append("</div>");

            foreach (var touchPoint in touchPointResponses)
            {
                // check the touchPoint to see if the ResponseFileAttachments has any items
                if ((touchPoint.ResponseElements?.Count) <= 0) continue;
                foreach (var element in touchPoint.ResponseElements)
                {
                    if (element.ResponseFileAttachments?.Count <= 0) continue;
                    foreach (var fileAttachment in element.ResponseFileAttachments)
                    {
                        var fileExtension = fileAttachment.FileName.Substring(fileAttachment.FileName.LastIndexOf('.') + 1);
                        var endpoint = $"/DesktopModules/DnnSharp/DnnApiEndpoint/Api.ashx?method=DownloadFile&touchPointId={touchPoint.TouchPointID}&touchPointResponseId={touchPoint.TouchPointResponseID}&elementId={element.ElementID}&elementType={element.ElementType}";

                        htmlDocList.Append($"<div class='flex flex-col gap-2 lg:flex-row lg:gap-6 lg:items-center even:bg-white'>");
                        htmlDocList.Append(" <div class='flex items-center gap-3 pt-6 pb-3 px-6 flex-none lg:pb-6'>");
                        htmlDocList.Append("<span class='flex-shrink-0 text-slate-500'>");
                        switch (fileExtension)
                        {
                            case "pdf":
                                htmlDocList.Append("<i class='far fa-file-pdf fa-2x'></i>");
                                break;

                            case "xlsx":
                                htmlDocList.Append("<i class='far fa-file-excel fa-2x'></i>");
                                break;

                            case "docx":
                                htmlDocList.Append("<i class='far fa-file-word fa-2x'></i>");
                                break;

                            default:
                                htmlDocList.Append("<i class='far fa-file fa-2x'></i>");
                                break;
                        }
                        htmlDocList.Append("</span>");
                        htmlDocList.Append($"<span>{fileAttachment.FileName.Replace($"{element.ElementID}~", String.Empty)}</span>");
                        htmlDocList.Append("</div>");
                        htmlDocList.Append(" <div class='pb-6 px-6 flex-none lg:pt-6 lg:ml-auto'>");

                        htmlDocList.Append($"<a href='{endpoint}' class='btn btn-primary btn-sm'>Download</a>");
                        htmlDocList.Append("</div>");
                        htmlDocList.Append("</div>");
                    }
                }
            }

            htmlDocList.Append("</div>");
            htmlDocList.Append("</div>");
            return htmlDocList.ToString();
        }
    }
}