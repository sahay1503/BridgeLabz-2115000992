using System;
using System.Reflection;
using System.Collections.Generic;

// Custom attribute for dependency injection
[AttributeUsage(AttributeTargets.Constructor)]
public class InjectAttribute : Attribute { }

// Service interface
public interface IService
{
    void Serve();
}

// Implementation of IService
public class MyService : IService
{
    public void Serve()
    {
        Console.WriteLine("Service is being executed!");
    }
}

// Class that depends on IService
public class Consumer
{
    private readonly IService _service;

    [Inject]
    public Consumer(IService service)
    {
        _service = service;
    }

    public void Execute()
    {
        _service.Serve();
    }
}

// Simple Dependency Injection container
public class DIContainer
{
    private readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();

    public void Register<TInterface, TImplementation>()
    {
        _registrations[typeof(TInterface)] = typeof(TImplementation);
    }

    public object Resolve(Type type)
    {
        ConstructorInfo constructor = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)[0];

        if (constructor.GetCustomAttribute<InjectAttribute>() != null)
        {
            ParameterInfo[] parameters = constructor.GetParameters();
            object[] dependencies = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                Type paramType = parameters[i].ParameterType;
                dependencies[i] = Resolve(paramType);
            }

            return Activator.CreateInstance(type, dependencies);
        }

        return Activator.CreateInstance(type);
    }

    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }
}

class ReflectionDIExample
{
    static void Main()
    {
        DIContainer container = new DIContainer();

        // Register dependencies
        container.Register<IService, MyService>();

        // Resolve the Consumer class with dependencies injected
        Consumer consumer = container.Resolve<Consumer>();
        consumer.Execute();
    }
}
