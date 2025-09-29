﻿namespace DesignPattern.Memento.MementoPattern
{
    public class Memento
    {
        public string State { get; }
        public Memento(string state) => State = state;
    } 
}
