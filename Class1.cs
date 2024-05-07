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
using progetto_scuola;

namespace Helper
{
    internal class Class1
    {
        public static string datiFake()
        {
            var random = new Bogus.Randomizer();
            string parola = random.Word();

            


            return parola;
        }
        public static int winPoints(int finalTries, int parolaLength)
        {
            int addPoints = 50 * finalTries + 15 * parolaLength;
            return addPoints;
        }

        public static void saveGamescore(int totalPoints) //SALVA PUNTEGGIO
        {
            string[] Lines = File.ReadAllLines(Path.Combine(@"data", "playerinfo.dat"));

            StreamReader reader = new StreamReader(Path.Combine(@"data", "playerinfo.dat"));
            int LineIndex = 0;
            while (!reader.EndOfStream)
            {
                if (reader.ReadLine().Split('=')[0] == "score")
                {
                    break;
                }
                LineIndex++;
            }
            reader.Close();
            Lines[LineIndex] = $"score={totalPoints}";
            File.WriteAllLines(Path.Combine(@"data", "playerinfo.dat"), Lines);
        }

        public static void saveStreak(int streak) //SALVA STREAK
        {
            string[] Lines = File.ReadAllLines(Path.Combine(@"data", "playerinfo.dat"));

            StreamReader reader = new StreamReader(Path.Combine(@"data", "playerinfo.dat"));
            int LineIndex = 0;
            while (!reader.EndOfStream)
            {
                if (reader.ReadLine().Split('=')[0] == "winstreak")
                {
                    break;
                }
                LineIndex++;
            }
            reader.Close();
            Lines[LineIndex] = $"winstreak={streak}";
            File.WriteAllLines(Path.Combine(@"data", "playerinfo.dat"), Lines);
        }

        public static void saveVolume(int volume) //SALVA VOLUME
        {
            string[] Lines = File.ReadAllLines(Path.Combine(@"data", "playerinfo.dat"));

            StreamReader reader = new StreamReader(Path.Combine(@"data", "playerinfo.dat"));
            int LineIndex = 0;
            while (!reader.EndOfStream)
            {
                if (reader.ReadLine().Split('=')[0] == "volume")
                {
                    break;
                }
                LineIndex++;
            }
            reader.Close();
            Lines[LineIndex] = $"volume={volume}";
            File.WriteAllLines(Path.Combine(@"data", "playerinfo.dat"), Lines);
        }
        public static void Speaker(string parola, int vol)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Volume = vol;
            sp.Speak(parola);
        }
        

    }
}
