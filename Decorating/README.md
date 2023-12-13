# Decorator Pattern
This library provides an implementation of the decorator pattern that can be accessed using the `IDecorator`, `IDecorator<T>` or `IValueDecorator<T>` interface as well as
the `Decorable`, `Decorable<T>` and `ValueDecorable<T>`.

There are also the `Decorator`, `Decorator<T>` and `ValueDecorator<T>` classes which all provide the functionalities to either decorate another decorator or to function as a root decorator.

Lastly, there is the `IdentityDecorator` class and their generic counterpart which can be used for providing a decorator that applies no modification at all.
