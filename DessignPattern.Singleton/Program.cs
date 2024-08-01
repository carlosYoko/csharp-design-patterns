using DessignPattern.Singleton;


var singleton = SingletonPattern.Instance;

var log = Log.Instance;

log.Save("a");
log.Save("b");
log.Save("c");