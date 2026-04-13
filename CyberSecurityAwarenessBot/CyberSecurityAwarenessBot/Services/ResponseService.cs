namespace CyberSecurityAwarenessBot.Services
{
    public class ResponseService
    {
        public string GetResponse(string userInput, string userName)
        {
            string input = userInput.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return "You entered nothing. Please type a question so I can help you.";
            }

            if (input.Contains("how's it going"))
            {
                return $"i'm functioning optimally {userName}. i am ready to assist you with your cybersecurity queries. How can i help you today ?. ";
            }

            if (input.Contains("what's your goal") || input.Contains("what is your goal"))
            {
                return "My goal is to provide you with guidance and support on cybersecurity matters, helping you stay safe online and protect your digital presence.";
            }

            if (input.Contains("what can i cover for you?"))
            {
                return "You can ask me about password safety, phishing, online browsing security, data protection, and more. I'm here to help with your cybersecurity concerns.";
            }

            if (input.Contains("password"))
            {
                return "Password safety is crucial! Use unique, complex passwords for each account, and consider using a password manager. Avoid common patterns and update your passwords regularly.";
            }

            if (input.Contains("phishing"))
            {
                return "Phishing is a type of cyber attack where attackers disguise themselves as trusted entities to steal sensitive information. Be cautious with suspicious emails, links, and attachments, and never share personal data without verifying the source.";
            }

            if (input.Contains("safe browsing") || input.Contains("browse safely") || input.Contains("browsing"))
            {
                return "o browse safely, use HTTPS connections, keep your browser and plugins updated, and avoid suspicious links or downloads. Use strong antivirus software and be mindful of public Wi-Fi networks.";
            }

            if (input.Contains("suspicious link") || input.Contains("link"))
            {
                return "Before clicking a link, hover over it to inspect the URL. If it looks strange, shortened, or unrelated to the sender, do not click it.";
            }

            if (input.Contains("scam"))
            {
                return "Online scams often create urgency or fear. Be cautious of messages asking for money, OTPs, passwords, or banking details.";
            }

            if (input == "exit")
            {
                return $"Goodbye, {userName}. Stay safe online!";
            }

            return "I didn’t quite understand that. Could you rephrase? You can ask about passwords, phishing, or safe browsing.";
        }
    }
}