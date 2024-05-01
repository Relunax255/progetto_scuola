using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using System.Speech.Synthesis;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Drawing;

namespace Helper
{
    internal class Class1
    {
        public static string datiFake()
        {
            var random = new Bogus.Randomizer();
            string parola = random.Word();

            foreach (char carattere in parola)
            {
                if (carattere == Convert.ToChar(" ") || carattere == Convert.ToChar("-"))
                {
                    return datiFake();
                }
            }


            return parola;
        }
        public static int winPoints(int finalTries, int parolaLength)
        {
            int addPoints = 50 * finalTries + 15 * parolaLength;
            return addPoints;
        }

        public static void saveGamescore(int totalPoints)
        {
            string[] Lines = File.ReadAllLines(Path.Combine(@"data", "playerinfo.txt"));

            StreamReader reader = new StreamReader(Path.Combine(@"data", "playerinfo.txt"));
            int scoreIndex = 0;
            while (!reader.EndOfStream)
            {
                if (reader.ReadLine().Split('=')[0] == "score")
                {
                    break;
                }
                scoreIndex++;
            }
            reader.Close();
            Lines[scoreIndex] = $"score={totalPoints}";
            File.WriteAllLines(Path.Combine(@"data", "playerinfo.txt"), Lines);
        }
        public static void Speaker(string parola, int vol)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Volume = vol;
            sp.Speak(parola);
        }
        public async static void traduzione(string[] a, string parola)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/text"),
                Headers =
    {
        { "X-RapidAPI-Key", "1921e6c576msh950b29f0deb4610p12af99jsnf9326a2067e5" },
        { "X-RapidAPI-Host", "google-translate113.p.rapidapi.com" },
    },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "from", "en" },
        { "to", "it" },
        { "text", parola},
    }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                a[0] = body;
            }

        }

    }
}
