using System;

namespace isgood.Configuration;

public class NotificationConfiguration
{
    public bool? Enabled { get; set; }
    public double IntervalInHours { get; set; }
    public double NotificationIntervalInHours { get; set; }
    public string? SmtpServerAddress { get; set; }
    public int SmtpServerPort { get; set; }
    public bool SmtpUseSSL { get; set; }
    public string? SmtpUsername { get; set; }
    public string? SmtpPassword { get; set; }
    public string? SmtpFromAddress { get; set; }
    public string? ToAddress { get; set; }

    public NotificationConfiguration()
    {
        IntervalInHours = 8;
        NotificationIntervalInHours = 12;
        SmtpUseSSL = true;
        SmtpServerPort = 587;
    }

    public bool IsValid()
    {
        if (Enabled == null)
        {
            throw new ArgumentException("Property 'Enabled' is missing but has to be true or false");
        }
        else if (Enabled == false)
        {
            return true;
        }

        if (SmtpServerAddress == null || SmtpServerAddress == string.Empty)
        {
            throw new ArgumentException("Property 'SmtpServerAddress' is not specified or empty");
        }

        if (SmtpUsername == null || SmtpUsername == string.Empty)
        {
            throw new ArgumentException("Property 'SmtpUsername' is not specified or empty");
        }

        if (SmtpPassword == null || SmtpPassword == string.Empty)
        {
            throw new ArgumentException("Property 'SmtpPassword' is not specified or empty");
        }

        if (SmtpFromAddress == null || SmtpFromAddress == string.Empty)
        {
            throw new ArgumentException("Property 'SmtpFromAddress' is not specified or empty");
        }
        
        return true;
    }
}