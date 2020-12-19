using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.NetworkInformation;
//------------------------------------KLASA ABSTRAKCYJNA Z NARZĘDZIAMI SIECIOWYMI
namespace FormsNetworkTools
{   
    static class BasicNettworkTools
    {
        public static string GetHostName()  //Metdoa zwracająca nazwę hosta i domeny
        {
            string newLine = Environment.NewLine; // Definicja zmiennej pozwalającej na przejście do drugiej lini w tekście
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            return (computerProperties.HostName + " " + computerProperties.DomainName + newLine); //zwraca nazwe hosta i domeny
        }
        public static string GetInterfacesInfo() //Metoda zwracająca uporządkowane w blok informacje o interfejsach sieciowych
        {
            var numList = 0;
            string newLine = Environment.NewLine; // Definicja zmiennej pozwalającej na przejście do drugiej lini w tekście
            string result = "";
            NetworkInterface[] netInterfaces = NetworkInterface.GetAllNetworkInterfaces(); //Stworzenie tablicy z interfejsami sieciowymi
            if (netInterfaces == null || netInterfaces.Length < 1) //Wykonanie If gdy tablica jest pusta
            {
                return "No network interfaces found.";
            }
            foreach (NetworkInterface adapter in netInterfaces) //Tworzenie listy z interfejsami i przypisanie do nich wartości
            {
                numList++;
                result += (numList + ". " + adapter.Description + newLine + "Interface type: " + adapter.NetworkInterfaceType + newLine + "Physical address: " + 
                    adapter.GetPhysicalAddress().ToString() + newLine + "Operational status: " + adapter.OperationalStatus + newLine);

                IPInterfaceProperties ipProp = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection gatewayAddresses = ipProp.GatewayAddresses;
                
                foreach (UnicastIPAddressInformation ip in ipProp.UnicastAddresses) //Przypisanie adresów IP do interfejsów
                {
                    if (ip.Address.AddressFamily.ToString() == "InterNetworkV6") //Rozdzielenie adresów IPv4 od IPv6
                    {
                        result += "IPv6 address: " + ip.Address.ToString() + newLine;
                    }
                    else
                    {
                        result += "IPv4 address: " + ip.Address.ToString() + newLine;
                    } 
                }
                foreach (GatewayIPAddressInformation gatewayAddress in gatewayAddresses) //Przypisanie bram sieciowych do interfejsów
                {
                    result += "Gateway address: " + gatewayAddress.Address.ToString() + newLine;
                }
                result += newLine;
                
            }
            return result;
        }
        public static string RunSynchPing(string address) // Metoda zwracająca wynik ping, jako argument przyjmuje adres sieciowy bądź nazwę domeny
        {
            Ping ping1 = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";   // Określenie wielkości danych jako 32 bajty
            byte[] buffer = Encoding.ASCII.GetBytes(data);      // Określenie wielkości danych jako 32 bajty
            int timeout = 1000;                                 // Określenie czasu oczekiwania
            string newLine = Environment.NewLine;               // Definicja zmiennej pozwalającej na przejście do drugiej lini w tekście
            string result;
            Regex rgxIp = new Regex("^\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}$");     //Definicja warunków Regex zapobiegająca wpisywaniu nieprawidłowego adresu
            Regex rgxDomain = new Regex("^[w]{3}\\.[a-z0-9]+\\.[a-z]+$");               //-=-
            Regex rgxDomain2 = new Regex("^[a-z0-9]+\\.[a-z]+$");                       //-=-
            Regex rgxDomain3 = new Regex("^[w]{3}\\.[a-z0-9]+\\.[a-z]+\\.[a-z]+$");     //-=-
            Regex rgxDomain4 = new Regex("^[a-z0-9]+\\.[a-z]+\\.[a-z]+$");              //-=-

            if (rgxDomain.IsMatch(address) || rgxDomain2.IsMatch(address) || rgxDomain3.IsMatch(address) //Instrukcja wykorzystująca Definicje Regex
                || rgxDomain4.IsMatch(address) || rgxIp.IsMatch(address))
            {
                try
                {   
                    PingReply reply = ping1.Send(address, timeout, buffer, options); //Przypisanie wyniku pingu do zmiennej reply
                    if (reply.Status == IPStatus.Success && reply != null)
                    { //Przypisanie gotowego wyniku pingu do zmiennej result
                        result = ("Reply from " + reply.Address.ToString() + ": bytes=" + reply.Buffer.Length.ToString() +
                            " time=" + reply.RoundtripTime.ToString() + "ms" + " TTL=" + reply.Options.Ttl.ToString() + newLine);
                        return result;
                    }
                    else
                    {
                        result = ("Request timeout" + newLine);
                        return result;
                    }
                }
                catch (Exception)
                {
                    result = ("Request timeout" + newLine);
                    return result;
                }
            }
            else
            {
                result = "wrong";
                return result;
            }   
        }
    }
}
