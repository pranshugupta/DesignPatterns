Abstract Factory patterns acts a super-factory which creates other factories. This pattern is also called as Factory of factories. In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

Participants

    The classes and objects participating in this pattern are:

	AbstractFactory  (ContinentFactory)
		declares an interface for operations that create abstract products
	ConcreteFactory   (AfricaFactory, AmericaFactory)
		implements the operations to create concrete product objects
	AbstractProduct   (Herbivore, Carnivore)
		declares an interface for a type of product object
	Product  (Wildebeest, Lion, Bison, Wolf)
		defines a product object to be created by the corresponding concrete factory
		implements the AbstractProduct interface
	Client  (AnimalWorld)
		uses interfaces declared by AbstractFactory and AbstractProduct classes