using DesignPattern.Strategy;

var context = new Context(new Car());
context.Run();

context.Strategy = new Moto();
context.Run();