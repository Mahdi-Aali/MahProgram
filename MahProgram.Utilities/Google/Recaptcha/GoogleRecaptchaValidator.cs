using Newtonsoft.Json;

namespace MahProgram.Utilities.Google.Recaptcha;

public static class GoogleRecaptchaValidator
{
    public static async Task<bool> IsValidAsync(string recaptchaResponse, string secretKey)
    {
        using (HttpClient client = new())
        {
            HttpResponseMessage message = await client.PostAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={recaptchaResponse}", null);

            GoogleRecaptchaResult result = JsonConvert.DeserializeObject<GoogleRecaptchaResult>(await message.Content.ReadAsStringAsync());

            return result.Success;
        }
    }
}
