
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ITTSpeechF.Util.Requesting
{
    class IttRequest
    {
        public static  async Task<System.IO.Stream> Upload(string actionUrl, string paramString, Stream paramFileStream, byte[] paramFileBytes)
        {
            //HttpContent stringContent = new StringContent(paramString);
            HttpContent fileStreamContent = new StreamContent(paramFileStream);
           
            //HttpContent bytesContent = new ByteArrayContent(paramFileBytes);
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                //formData.Add(stringContent, "param1", "param1");
                formData.Add(fileStreamContent, "file", "file.wav");
                //client.DefaultRequestHeaders.Add("Content-Type", "multipart/form-data");
    
                //formData.Add(bytesContent, "file2", "file2");
                var response = await client.PostAsync(actionUrl, formData);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var a = await response.Content.ReadAsStringAsync();
                return await response.Content.ReadAsStreamAsync();
               
            }
        }
    }
}
