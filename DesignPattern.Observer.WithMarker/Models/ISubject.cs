﻿namespace DesignPattern.Observer.WithMarker.Models;

public interface ISubject
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Notify(int score);
}
