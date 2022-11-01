using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceHook.Models
{
    public class Card
    {
        public string Type { get; set; }
    }

    public class Button
    {
        public string Title { get; set; }
        public Dictionary<string, string> Payload { get; set; }
        public string Url { get; set; }
        public bool Hide { get; set; }
    }

    public class Directives
    {
    }

    public class Response
    {
        public string Text { get; set; }
        public string Tts { get; set; }
        public Card Card { get; set; }
        public List<Button> Buttons { get; set; }
        public bool EndSession { get; set; }
        public Directives Directives { get; set; }
    }

    public class SessionState
    {
        public int Value { get; set; }
    }

    public class UserStateUpdate
    {
        public int Value { get; set; }
    }

    public class ApplicationState
    {
        public int Value { get; set; }
    }

    public class SecondField
    {
        public string ThirdField { get; set; }
    }

    public class Value
    {
        public string Field { get; set; }
        public SecondField SecondField { get; set; }
    }

    public class Event
    {
        public string Name { get; set; }
        public Value Value { get; set; }
    }

    public class Analytics
    {
        public List<Event> Events { get; set; }
    }

    public class AliceRespons
    {
        public Response Response { get; set; }
        public SessionState SessionState { get; set; }
        public UserStateUpdate UserStateUpdate { get; set; }
        public ApplicationState ApplicationState { get; set; }
        public Analytics Analytics { get; set; }
        public string Version { get; set; }
    }
}
