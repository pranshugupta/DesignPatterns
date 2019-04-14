Singleton:

Intent:	Ensure a class has only one instance, and provide a global point of access to it.
		Encapsulated "just-in-time initialization" or "initialization on first use".

Singleton should be considered only if all three of the following criteria are satisfied::
		1. Ownership of the single instance cannot be reasonably assigned
		2. Lazy initialization is desirable
		3. Global access is not otherwise provided for

The Singleton pattern can be extended to support access to an application-specific number of instances.

Advantages over static:
	1. singleton object can be passed as a parameter to other methods.
	2. A Singleton can implement interfaces, allow inheritance.
	3. A Singleton is initialized when the program sigleton class is loaded. While a static class is generally initialized when it is first loaded and it will lead to potential class loader issues.
	4. Singleton class follow the Object Oriented Principles.
	5. Singleton Objects stored on heap while static class stored in stack.
	6. Singleton Objects can have constructor while Static Class cannot.
	7. Singleton Objects can dispose but not static class
	8. Singleton Objects can clone but not with static class


Different ways of creating Singleton instances:
	1. First version (SingletonNotThreadSafe.cs) - not thread-safe
			It is not thread safe so not recommended
	2. Second version(SingletonSimpleThreadSafe.cs) - simple thread-safety
			Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
	3. Third version(SingletonDoubleCheckLocking.cs) - attempted thread-safety using double-check locking.
			It still get performance issue and used double checking.
			Not recommended
	4. Fourth version(SingletonThreadSafeWithoutLock.cs) - not quite as lazy, but thread-safe without using locks.
			If you have static members other than Instance, the first reference to those members will involve creating the instance
			There are complications if one static constructor invokes another which invokes the first again
	5. Fifth version(SingletonFullyLazy.cs) - fully lazy instantiation
			Nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal.
	6. Sixth version(SingletonDotNetLazyType.cs) - using .NET 4's Lazy<T> type
		If you're using .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness really simple. 
		All you need to do is pass a delegate to the constructor which calls the Singleton constructor - which is done most easily with a lambda expression.