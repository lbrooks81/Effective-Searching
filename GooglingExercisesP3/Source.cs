/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
* Link(s) Used: 
* 
* https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#typeof-operator
* https://learn.microsoft.com/en-us/dotnet/api/system.reflection.constructorinfo.invoke?view=net-9.0
* https://learn.microsoft.com/en-us/dotnet/api/system.reflection.assembly.createinstance?view=net-9.0#system-reflection-assembly-createinstance(system-string)
* https://learn.microsoft.com/en-us/dotnet/api/system.type.fullname?view=net-9.0#system-type-fullname
* https://stackoverflow.com/questions/11632816/can-i-count-properties-before-i-create-an-object-in-the-constructor
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace GooglingExercisesPt3;

public class Source
{
    /// <summary>
    /// Retrieves the Type object associated with the Calculator class.
    /// </summary>
    /// <returns>The Type of the Calculator class.</returns>
    public static Type GetCalculatorType()
    {
        return typeof(Calculator);
    }

    /// <summary>
    /// Creates an instance of the Calculator class using reflection.
    /// This method locates the parameterless constructor of the Calculator class
    /// and invokes it to create a new instance. Reflection allows for dynamic
    /// type instantiation at runtime, which can be useful for scenarios where
    /// types are not known at compile time.
    /// </summary>
    /// <returns>A new instance of the Calculator class.</returns>
    public static Calculator CreateCalculatorUsingReflection()
    {
        ConstructorInfo Constructor = typeof(Calculator).GetConstructor(Type.EmptyTypes)!;
        return Constructor.Invoke(new Calculator[] { }) as Calculator;
    }

    /// <summary>
    /// Creates an instance of the Calculator class using Assembly.CreateInstance.
    /// </summary>
    /// <returns>A new instance of the Calculator class.</returns>
    /// <exception cref="NullReferenceException">Thrown when the instance creation fails.</exception>
    public static Calculator CreateCalculatorUsingReflection2()
    {
        Calculator calc = typeof(Calculator).Assembly.CreateInstance(typeof(Calculator).FullName) as Calculator;

        if(calc == null)
        {
            throw new NullReferenceException("calc is null!");
        }

        return calc;
    }
    
    /// <summary>
    /// Gets the number of properties in the Calculator class using reflection.
    /// </summary>
    /// <returns>The number of properties in the Calculator class.</returns>
    public static int GetNumberOfPropertiesInCalculator()
    {
        return typeof(Calculator).GetProperties().Length;
    }

    /// <summary>
    /// Retrieves the values of specific properties from a Calculator object.
    /// Assumes the object is an instance of the Calculator class.
    /// </summary>
    /// <param name="obj">An instance of the Calculator class.</param>
    /// <returns>A tuple containing values of number, pi, tau, and e properties.</returns>
    public static (double number, double pi, double tau, double e) GetCalculatorPropertyValues(Object obj)
    {
        if (obj.GetType() == typeof(Calculator))
        {
            Calculator calc = obj as Calculator;
            return (calc.Number, calc.Pi, calc.Tau, calc.E);
        }
        else
        {
            return (0, 0, 0, 0);
        }
    }

    /// <summary>
    /// Determines the line number of the return statement in this method.
    /// </summary>
    /// <returns>The line number of the return statement.</returns>
    public static int GetLineNumber()
    {
        return default; //Return the line number
    }
}
