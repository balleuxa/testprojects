using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class OpenAI
{
    private static readonly HttpClient client = new HttpClient();

    // It's best practice not to expose your API key in your code. Secure it using environment variables, secure Azure vaults, or app settings.
    public string apiKey = "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"; // Ensure to secure your API key

    public OpenAI(string apiKey)
    {
        this.apiKey = apiKey;
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.apiKey);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<string> GenerateText(string prompt, int maxTokens = 100)
    {
        // Ensure the endpoint corresponds to the latest API version and available model
        string endpoint = "https://api.openai.com/v1/engines/gpt-3.5-turbo-instruct/completions";

        // The JSON payload to send to the API
        var requestBody = new
        {
            prompt,
            max_tokens = maxTokens
        };

        string jsonString = JsonConvert.SerializeObject(requestBody);

        try
        {
            HttpResponseMessage response = await client.PostAsync(
                endpoint,
                new StringContent(jsonString, Encoding.UTF8, "application/json")
            );

            string responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                dynamic json = JsonConvert.DeserializeObject(responseString);
                var choices = json.choices;
                if (choices.Count > 0)
                {
                    string text = choices[0].text;
                    return text.ToString().TrimStart().Trim('\"');
                }
                else
                {
                    throw new Exception("No choices found in the OpenAI API response.");
                }
            }
            else
            {
                throw new HttpRequestException($"Error calling the OpenAI API: HTTP {(int)response.StatusCode} - {response.ReasonPhrase}\nResponse content: {responseString}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new HttpRequestException($"Request exception: {e.Message}", e);
        }
    }
}
