using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elie.Patterns
{
    public class GameDesignPattern : ScriptableObject
    {
        public string title;
        public int id;
        public string subtitle;
        public string description;
        public string[] exemples;
        public string use;
        public string consequences;
        public GameDesignPattern[] instantiates;
        public GameDesignPattern[] modulates;
        public GameDesignPattern[] instantiatedBy;
        public GameDesignPattern[] modulatedBy;
        public GameDesignPattern[] conflict;
    }
}
