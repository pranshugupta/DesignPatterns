Factory Design Pattern falls under the category of creational design pattern.
It deals with the problem of creating objects (products) without specifying the exact class of object that will be created. The essence of this pattern is to "Define an interface for creating an object, but let the classes that implement the interface decide which class to instantiate. The Factory method lets a class defer instantiation to sub classes.

It would be tedious when the client needs to specify the class name while creating the objects. So, to resolve this problem, we can use Factory pattern. It provides the client a simple way to create the object.

Real-world code demonstrates the Factory method offering flexibility in creating different documents. The derived Document classes Report and Resume instantiate extended versions of the Document class. Here, the Factory Method is called in the constructor of the Document base class.