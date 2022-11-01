using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceHook.Models
{
    public class Screen
    {
    }

    public class AccountLinking
    {
    }

    public class AudioPlayer
    {
    }

    public class Interfaces
    {
        public Screen Screen { get; set; }
        public AccountLinking AccountLinking { get; set; }
        public AudioPlayer AudioPlayer { get; set; }
    }

    public class Meta
    {
        public string Locale { get; set; }
        public string Timezone { get; set; }
        public string ClientId { get; set; }
        public Interfaces Interfaces { get; set; }
    }

    public class Intents
    {
    }

    public class Nlu
    {
        public List<object> Tokens { get; set; }
        public List<object> Entities { get; set; }
        public Intents Intents { get; set; }
    }

    public class Request
    {
        public Nlu Nlu { get; set; }
        public Dictionary<string, string> Payload { get; set; }
        public string Type { get; set; }
    }

    public class User
    {
        public string UserId { get; set; }
        public string AccessToken { get; set; }
    }

    public class Application
    {
        public string ApplicationId { get; set; }
    }

    public class Session
    {
        public int MessageId { get; set; }
        public string SessionId { get; set; }
        public string SkillId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Application Application { get; set; }
        public bool New { get; set; }
    }

    public class State
    {
        public Session Session { get; set; }
        public User User { get; set; }
        public Application Application { get; set; }
    }

    public class AliceRequest
    {
        public Meta Meta { get; set; }
        public Request Request { get; set; }
        public Session Session { get; set; }
        public State State { get; set; }
        public string Version { get; set; }
    }
}
