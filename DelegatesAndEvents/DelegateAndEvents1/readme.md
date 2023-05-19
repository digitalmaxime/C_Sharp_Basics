## Delegate
Think of it like a pointer to a function

---
### Func 

Func is a Delegate that returns something

```Func<TResult>``` Takes no params and return a type TResult

```Func<T1, TResult>``` Takes 1 param (of type T1)

```Func<T1, T2, ... T16, TResult>``` Takes up to 16 params

*N.B le dernier paramètre est le type de retour*

---
### Action 

Action is a Delegate that returns ```void```

```Action<T>``` Takes 1 params of type T

```Action<T1, T2, ... T16>``` Takes up to 16 params

---
### Lambda
Any Delegate type can be represented with a lambda expression. 

The parameters and return type has to match.


Lambda's can be async

---
### Events
An event is a wrapper around a delegate. It depends on the delegate.

Use "event" keyword with delegate type variable to declare an event.

keyword : ```event```

An event is always associated with a delegate

The type of the event is Delegate

When an event is raised, the delegate is called back

The delegate associated with an event usually have 2 params as standard practice
- The first one is an object representing the instance that raised the event.
- The second one is a type representing event arguments.