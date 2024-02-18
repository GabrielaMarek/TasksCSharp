# C# Projects Overview

This repository contains three C# projects demonstrating various concepts such as classes, inheritance, polymorphism, abstract classes, interfaces, and more. Each project addresses a specific task to showcase different aspects of C# programming.

## Project 1: Library Management System

### Description
This project implements a simple library management system consisting of classes for Books and Library. It allows users to add, remove, search, and display books in a library.

### Classes
- **Book**: Defines properties and methods for managing book details.
- **Library**: Manages a collection of Book objects and provides methods for library operations.

### Execution
- The `Program` class demonstrates the usage of the Library class by adding books, displaying available books, and searching for books by title and author.

## Project 2: Shape Hierarchy with Polymorphism

### Description
This project illustrates inheritance and polymorphism by implementing a shape hierarchy with a base class Shape and derived classes Rectangle and Circle.

### Classes
- **Shape**: Base class defining a method to calculate the area of a shape.
- **Rectangle**: Derived class representing a rectangle with properties for width and height.
- **Circle**: Derived class representing a circle with a property for radius.

### Execution
- The `Program` class creates an array of Shape objects containing instances of Rectangle and Circle. It demonstrates polymorphism by calling the CalculateArea() method on each object.

## Project 3: Banking System with Abstract Classes and Interfaces

### Description
This project implements a banking system with a base abstract class Account and two derived classes: SavingsAccount and CheckingAccount. It also utilizes an interface IInterestBearing for calculating interest.

### Classes
- **Account**: Abstract base class defining properties and methods for basic account functionalities.
- **SavingsAccount**: Inherits from Account and implements the IInterestBearing interface to calculate interest.
- **CheckingAccount**: Inherits directly from Account.

### Interfaces
- **IInterestBearing**: Interface defining a method to calculate interest.

### Execution
- The project demonstrates the usage of abstract methods, interface methods, and polymorphism in managing different types of bank accounts.
