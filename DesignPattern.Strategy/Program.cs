using DesignPattern.Strategy;
using DesignPattern.Strategy.Contracts;

var context = new Context(new Car());
context.Run();

context.Strategy = new Moto();
context.Run();

context.Strategy = new Bicycle();
context.Run();