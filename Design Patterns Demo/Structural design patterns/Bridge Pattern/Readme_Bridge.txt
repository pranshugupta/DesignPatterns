Intent:
	Bridge pattern is used to separate an abstraction from its implementation so that both can be modified independently.
	This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class. 
	Both types of classes can be modified without affecting to each other.


The classes, interfaces and objects in the above UML class diagram are as follows:
1. Abstraction: (Message.cs)
	This is an abstract class and containing members that define an abstract business object and its functionality. 
	It contains a reference to an object of type Bridge. 
	It can also acts as the base class for other abstractions.
2. Redefined Abstraction: (SystemMessage.cs & UserMessage.cs)
	This is a class which inherits from the Abstraction class. 
	It extends the interface defined by Abstraction class.
3. Bridge: (IMessageSender.cs)
	This is an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class.
4. Bride Concrete Implementation: (EmailSender.cs, WebServiceSender.cs & MSMQSender.cs)
	These are classes which implement the Bridge interface and also provide the implementation details for the associated Abstraction class.

