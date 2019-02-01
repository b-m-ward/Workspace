using System;
using System.Collections.Generic;
using System.Text;

namespace PatternWorkbook.Library.Factory
{
    public abstract class Actor
    {
        public virtual string Name { get; set; }
        public virtual int Health { get; set; }

        public static Actor CreateActor(ActorBuilder builder) 
        {
            switch (builder.Type)
            {
                case ActorType.Player:
                    return new Player(builder);
                case ActorType.Dwarf:
                    return new Dwarf(builder);
                case ActorType.Human:
                    return new Human(builder);
                case ActorType.Giant:
                    return new Giant(builder);
                default:
                    return new Human(builder);
            }
        }

    }

    public enum ActorType
    {
        Player, Human, Dwarf, Giant
    }

    public class Player : Actor
    {
        public Player(ActorBuilder builder)
        {
            this.Name = builder.Name;
            this.Health = builder.Health;
        }
    }

    public class Human : Actor
    {
        public Human(ActorBuilder builder)
        {
            this.Name = builder.Name;
            this.Health = builder.Health;
        }
    }

    public class Dwarf : Actor
    {
        public Dwarf(ActorBuilder builder)
        {
            this.Name = builder.Name;
            this.Health = builder.Health;
        }
    }

    public class Giant : Actor
    {
        public Giant(ActorBuilder builder)
        {
            this.Name = builder.Name;
            this.Health = builder.Health;
        }
    }

    public class ActorBuilder
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public ActorType Type { get; set; }
    }
}
